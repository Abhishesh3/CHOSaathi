using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CHO_Saathi.Models;

namespace CHO_Saathi.Controllers
{
    public class CHOMappedController : Controller
    {
        private readonly ApplicationDBContext _context;

        public CHOMappedController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: CHOMapped
        //public async Task<IActionResult> Index()
        //{
        //    var applicationDBContext = _context.ChoMappeds.Include(c => c.Cho).Include(c => c.Facility).Include(c => c.SubFacility).Include(c => c.Village);
        //    return View(await applicationDBContext.ToListAsync());
        //}


        public async Task<IActionResult> Index(int? id)
        {
            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {
                int RoleId = Convert.ToInt32(HttpContext.Session.GetString("RoleId"));

                int MenuId = _context.MstMenus.Where(m => m.Controller == "CHO" && m.Action == "Index").Select(m => m.MenuId).FirstOrDefault();

                var DisplayRight = _context.RoleMenus.Where(c => c.RoleId == RoleId && c.MenuId == MenuId).Select(p => p.Display).FirstOrDefault();

                if (DisplayRight == true)
                {
                    if (id == null)
                    {
                        return NotFound();
                    }
                    if (id == 0)
                    {
                        return NotFound();
                    }

                    ViewData["choid"] = id;

                    var CHODetails = _context.Chos.Where(m => m.IsDeleted == 0 && m.IsActive == true && m.Choid == id).FirstOrDefault();

                    if (CHODetails != null)
                    {
                        ViewBag.CHOName = CHODetails.Choname;
                        ViewBag.CHOUsername = CHODetails.Username;

                        ViewData["stateName"] = _context.Chos.Where(p => p.Choid == id).Include(p => p.State).Select(p => p.State.StateName).FirstOrDefault();

                        ViewData["DistrictName"] = _context.Chos.Where(p => p.Choid == id).Include(p => p.District).Select(p => p.District.District).FirstOrDefault();

                        ViewData["BlockName"] = _context.Chos.Where(p => p.Choid == id).Include(p => p.Block).Select(p => p.Block.BlockName).FirstOrDefault();

                        ViewData["FacilityType"] = _context.Chos.Where(p => p.Choid == id).Include(p => p.FacilityType).Select(p => p.FacilityType.FacilityType).FirstOrDefault();

                        ViewData["Facility"] = _context.Chos.Where(p => p.Choid == id).Include(p => p.Facility).Select(p => p.Facility.FacilityName).FirstOrDefault();

                        ViewData["SubFacility"] = _context.Chos.Where(p => p.Choid == id).Include(p => p.SubFacility).Select(p => p.SubFacility.SubFacility).FirstOrDefault();

                        ViewData["SubFacilityID"] = _context.Chos.Where(p => p.Choid == id).Include(p => p.SubFacility).Select(p => p.SubFacility.SubFacilityId).FirstOrDefault();



                        ViewData["Facility"] = new SelectList(_context.LocationFacilityTypes.OrderBy(p => p.Sequence), "FacilityTypeId", "FacilityType");

                        //var applicationDBContext = _context.AnmcatchmentAreaTransHists.Where(a => a.Anmid == id).Include(a => a.Village).Include(a => a.Village.Facility).Include(a => a.Village.SubFacility).Include(p => p.Anm).Include(p => p.Anm.Cadre);

                        var applicationDBContext = _context.ChoMappeds.Where(a => a.Choid == id).Include(a => a.Village).Include(a => a.Village.Facility).Include(a => a.Village.SubFacility).Include(p => p.Cho);

                        return View(await applicationDBContext.ToListAsync());
                    }
                    else
                    {
                        TempData["AlertType"] = "danger";
                        TempData["AlertMessage"] = "Inactive users are unable to open location mapping.";
                        return RedirectToAction("Index", "CHO");
                    }

                }
                else
                {
                    return RedirectToAction("Errors", "Error");
                }

            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        [HttpPost]
        public IActionResult getvillage(int SubFacilityId, string Flag, int choid)
        {
            try
            {
                CHOCommonModel CHOCommonModel = new CHOCommonModel();

                CHOCommonModel.LSTLocationVillages = _context.LocationVillages.Include(p => p.Facility).Include(p => p.SubFacility).Where(p => p.SubFacilityId == SubFacilityId).ToList();

                CHOCommonModel.LSTChoMapped = _context.ChoMappeds.Where(p => p.Choid == choid).ToList();

                ViewBag.flag = Flag;

                return PartialView("/Views/CHOMapped/_PVGetForGRPContactList.cshtml", CHOCommonModel);
            }
            catch (Exception e)
            {
                return RedirectToAction(nameof(Index));
            }

        }


        [HttpPost]
        public JsonResult LinkVillage(int choid, int villageid, int FacilityId, int SubFacilityId)
        {

            ChoMapped ancr = new ChoMapped();

            ancr.Choid = choid;
            ancr.VillageId = villageid;
            ancr.FacilityId = FacilityId;
            ancr.SubFacilityId = SubFacilityId;
            ancr.IsDeleted = 0;
            ancr.IsActive = true;
            ancr.CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
            ancr.CreatedOn = DateTime.Now;

            _context.Add(ancr);
            _context.SaveChanges();

            return Json("0");
        }

        [HttpPost]
        public JsonResult removeaddedvillage(int chomappingId)
        {
            try
            {

                var cHO = _context.ChoMappeds.Where(m => m.ChomappingId == chomappingId).FirstOrDefault();
                _context.Remove(cHO);
                _context.SaveChanges();

                return Json("0");
            }
            catch (Exception ex)
            {
                return Json("1");
            }


        }

        // GET: CHOMapped/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var choMapped = await _context.ChoMappeds
                .Include(c => c.Cho)
                .Include(c => c.Facility)
                .Include(c => c.SubFacility)
                .Include(c => c.Village)
                .FirstOrDefaultAsync(m => m.ChomappingId == id);
            if (choMapped == null)
            {
                return NotFound();
            }

            return View(choMapped);
        }

        // GET: CHOMapped/Create
        public IActionResult Create()
        {
            ViewData["Choid"] = new SelectList(_context.Chos, "Choid", "Choid");
            ViewData["FacilityId"] = new SelectList(_context.LocationFacilities, "FacilityId", "FacilityId");
            ViewData["SubFacilityId"] = new SelectList(_context.LocationSubFacilities, "SubFacilityId", "SubFacilityId");
            ViewData["VillageId"] = new SelectList(_context.LocationVillages, "VillageId", "VillageId");
            return View();
        }

        // POST: CHOMapped/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ChomappingId,Choid,FacilityId,SubFacilityId,VillageId,IsDeleted,IsActive,CreatedBy,CreatedOn,UpdatedBy,UpdatedOn")] ChoMapped choMapped)
        {
            if (ModelState.IsValid)
            {
                _context.Add(choMapped);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Choid"] = new SelectList(_context.Chos, "Choid", "Choid", choMapped.Choid);
            ViewData["FacilityId"] = new SelectList(_context.LocationFacilities, "FacilityId", "FacilityId", choMapped.FacilityId);
            ViewData["SubFacilityId"] = new SelectList(_context.LocationSubFacilities, "SubFacilityId", "SubFacilityId", choMapped.SubFacilityId);
            ViewData["VillageId"] = new SelectList(_context.LocationVillages, "VillageId", "VillageId", choMapped.VillageId);
            return View(choMapped);
        }

        // GET: CHOMapped/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var choMapped = await _context.ChoMappeds.FindAsync(id);
            if (choMapped == null)
            {
                return NotFound();
            }
            ViewData["Choid"] = new SelectList(_context.Chos, "Choid", "Choid", choMapped.Choid);
            ViewData["FacilityId"] = new SelectList(_context.LocationFacilities, "FacilityId", "FacilityId", choMapped.FacilityId);
            ViewData["SubFacilityId"] = new SelectList(_context.LocationSubFacilities, "SubFacilityId", "SubFacilityId", choMapped.SubFacilityId);
            ViewData["VillageId"] = new SelectList(_context.LocationVillages, "VillageId", "VillageId", choMapped.VillageId);
            return View(choMapped);
        }

        // POST: CHOMapped/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ChomappingId,Choid,FacilityId,SubFacilityId,VillageId,IsDeleted,IsActive,CreatedBy,CreatedOn,UpdatedBy,UpdatedOn")] ChoMapped choMapped)
        {
            if (id != choMapped.ChomappingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(choMapped);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChoMappedExists(choMapped.ChomappingId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Choid"] = new SelectList(_context.Chos, "Choid", "Choid", choMapped.Choid);
            ViewData["FacilityId"] = new SelectList(_context.LocationFacilities, "FacilityId", "FacilityId", choMapped.FacilityId);
            ViewData["SubFacilityId"] = new SelectList(_context.LocationSubFacilities, "SubFacilityId", "SubFacilityId", choMapped.SubFacilityId);
            ViewData["VillageId"] = new SelectList(_context.LocationVillages, "VillageId", "VillageId", choMapped.VillageId);
            return View(choMapped);
        }

        // GET: CHOMapped/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var choMapped = await _context.ChoMappeds
                .Include(c => c.Cho)
                .Include(c => c.Facility)
                .Include(c => c.SubFacility)
                .Include(c => c.Village)
                .FirstOrDefaultAsync(m => m.ChomappingId == id);
            if (choMapped == null)
            {
                return NotFound();
            }

            return View(choMapped);
        }

        // POST: CHOMapped/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var choMapped = await _context.ChoMappeds.FindAsync(id);
            if (choMapped != null)
            {
                _context.ChoMappeds.Remove(choMapped);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChoMappedExists(int id)
        {
            return _context.ChoMappeds.Any(e => e.ChomappingId == id);
        }
    }
}
