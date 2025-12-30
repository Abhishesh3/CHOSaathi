using CHO_Saathi.Models;
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CHO_Saathi.Controllers
{
    public class LocationBlocksController : Controller
    {
        private readonly ApplicationDBContext _context;

        public LocationBlocksController(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            int pageSize = 10;
            int pageIndex = 1;

            // ---------- Bind State Dropdown ----------
            ViewBag.StateID = _context.LocationStates
                .Where(x => x.IsDeleted == 0)
                .OrderBy(x => x.StateName)
                .Select(x => new SelectListItem
                {
                    Value = x.StateId.ToString(),
                    Text = x.StateName
                }).ToList();

            // ---------- Bind District Dropdown (Initially blank or All) ----------
            ViewBag.DistrictID = new List<SelectListItem>
            {
                new SelectListItem { Value = "0", Text = "All" }
            };

            // ---------- Load Block List ----------
            var query = _context.LocationBlocks
                .Where(m => m.IsDeleted == 0)
                .Include(l => l.State)
                .Include(l => l.District)
                .OrderBy(m => m.State.StateName)
                .ThenBy(m => m.District)
                .ThenBy(m => m.BlockName)
                .AsNoTracking();

            var countUser = query.Count();
            var result = query.Skip(pageSize * (pageIndex - 1)).Take(pageSize);
            var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);

            TempData["pageIndex"] = pageIndex;
            TempData["PageSize"] = pageSize;
            TempData["MaxPageIndex"] = pageNo;

            return View(await result.ToListAsync());
        }


        public IActionResult getServerdt(int pageIndex, int pageSize, string State, string District, string selectedValue, string txtSearch)
        {
            var query = _context.LocationBlocks.
                         Where(m => m.IsDeleted == 0
                         && (State == "0" || m.StateId == Convert.ToInt32(State))
                         && (District == "0" || m.DistrictId == Convert.ToInt32(District))
                         && (string.IsNullOrEmpty(txtSearch) || m.BlockName.Contains(txtSearch)))
                         .Include(l => l.State)
                         .Include(l => l.District)
                         .OrderBy(m => m.State.StateName)
                         .ThenBy(m => m.District.District)
                         .ThenBy(m => m.BlockName)
                         .AsNoTracking();

            var countUser = query.Count();
            var result = query.Skip(pageSize * (pageIndex - 1)).Take(pageSize);

            var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
            TempData["pageIndex"] = pageIndex;
            TempData["PageSize"] = pageSize;
            TempData["MaxPageIndex"] = pageNo;
            ViewBag.BlockView = result;

            return PartialView("_PVBlock", result.ToList());
        }

        public IActionResult Create()
        {
            ViewData["CreatedBy"] = new SelectList(_context.Users, "UserID", "Password");
            ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserID", "Password");


            ViewBag.StateList = _context.LocationStates
                .Where(x => x.IsDeleted == 0)
                .OrderBy(x => x.StateName)
                .Select(x => new SelectListItem
                {
                    Value = x.StateId.ToString(),
                    Text = x.StateName
                })
                .ToList();

            return View(new LocationBlock());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LocationBlock locationBlock)
        {
            if (locationBlock.StateId != 0)
            {
                if (locationBlock.DistrictId != 0)
                {
                    locationBlock.CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
                    locationBlock.CreatedOn = DateTime.Now;
                    locationBlock.IsDeleted = 0;
                    _context.Add(locationBlock);
                    await _context.SaveChangesAsync();

                    //---------------------------------Triggers locationBlock ML Insertion--------------------------------------------//

                    List<LocationBlockMl> BlockML = new List<LocationBlockMl>();

                    BlockML.Add(new LocationBlockMl
                    {
                        BlockId = locationBlock.BlockId,
                        BlockName = locationBlock.BlockName,
                        LangId = 15
                    });
                    BlockML.Add(new LocationBlockMl
                    {
                        BlockId = locationBlock.BlockId,
                        BlockName = locationBlock.BlockName,
                        LangId = 2
                    });
                    _context.AddRange(BlockML);
                    _context.SaveChanges();

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["message"] = "Please Select District..!!";
                }
            }
            else
            {
                TempData["message"] = "Please Select State..!!";
            }

            ViewData["CreatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationBlock.CreatedBy);
          
            ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationBlock.UpdatedBy);

            ViewBag.StateList = _context.LocationStates
                .Where(x => x.IsDeleted == 0)
                .OrderBy(x => x.StateName)
                .Select(x => new SelectListItem
                {
                    Value = x.StateId.ToString(),
                    Text = x.StateName
                })
                .ToList();

            return View(new LocationBlock());
        }

        public async Task<IActionResult> Edit(int? id)
        {
            var locationBlock = await _context.LocationBlocks.FindAsync(id);
            if (locationBlock == null)
            {
                return NotFound();
            }

            ViewData["CreatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationBlock.CreatedBy);
            ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationBlock.UpdatedBy);

            ViewBag.StateList = _context.LocationStates
                .Where(x => x.IsDeleted == 0)
                .OrderBy(x => x.StateName)
                .Select(x => new SelectListItem
                {
                    Value = x.StateId.ToString(),
                    Text = x.StateName
                })
                .ToList();

            ViewBag.DistrictID = _context.LocationDistricts
                .Where(x => x.IsDeleted == 0 && x.StateId == locationBlock.StateId)
                .OrderBy(x => x.District)
                .Select(x => new SelectListItem
                {
                    Value = x.DistrictId.ToString(),
                    Text = x.District
                })
                .ToList();

            return View(locationBlock);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(LocationBlock locationBlock)
        {
            // Validate State
            if (locationBlock.StateId == 0)
            {
                TempData["message"] = "Please Select State..!!";

                ViewData["CreatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationBlock.CreatedBy);
                ViewData["DistrictID"] = new SelectList(_context.LocationDistricts.Where(m => m.IsDeleted == 0)
                    .OrderBy(m => m.District), "DistrictID", "District", locationBlock.DistrictId);
                ViewData["StateID"] = new SelectList(_context.LocationStates.Where(m => m.IsDeleted == 0)
                    .OrderBy(m => m.StateName), "StateID", "StateName", locationBlock.StateId);
                ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationBlock.UpdatedBy);

                return View(locationBlock);
            }

            // Validate District
            if (locationBlock.DistrictId == 0)
            {
                TempData["message"] = "Please Select District..!!";

                ViewData["CreatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationBlock.CreatedBy);
                ViewData["DistrictID"] = new SelectList(_context.LocationDistricts.Where(m => m.IsDeleted == 0)
                    .OrderBy(m => m.District), "DistrictID", "District", locationBlock.DistrictId);
                ViewData["StateID"] = new SelectList(_context.LocationStates.Where(m => m.IsDeleted == 0)
                    .OrderBy(m => m.StateName), "StateID", "StateName", locationBlock.StateId);
                ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationBlock.UpdatedBy);

                return View(locationBlock);
            }

            try
            {
                // Fetch existing block
                var existingBlock = await _context.LocationBlocks
                    .FirstOrDefaultAsync(m => m.BlockId == locationBlock.BlockId);

                if (existingBlock == null)
                {
                    return NotFound();
                }

                // Update main Block entry
                existingBlock.BlockName = locationBlock.BlockName;
                existingBlock.BlockCode = locationBlock.BlockCode;
                existingBlock.StateId = locationBlock.StateId;
                existingBlock.DistrictId = locationBlock.DistrictId;
                existingBlock.UpdatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
                existingBlock.UpdatedOn = DateTime.Now;
                existingBlock.IsDeleted = 0;

                // Update related Block ML entries
                var relatedMLs = _context.LocationBlockMls
                    .Where(m => m.BlockId == existingBlock.BlockId)
                    .ToList();

                foreach (var ml in relatedMLs)
                {
                    ml.BlockName = locationBlock.BlockName;
                }

                // Save all changes
                _context.Update(existingBlock);
                _context.UpdateRange(relatedMLs);

                await _context.SaveChangesAsync();

                TempData["message"] = "Block updated successfully!";
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocationBlockExists(locationBlock.BlockId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }


        public async Task<IActionResult> Delete(int? id)
        {
            var locationBlock = await _context.LocationBlocks
                        .Include(l => l.District)
                        .Include(l => l.State)
                        .FirstOrDefaultAsync(m => m.BlockId == id);
            if (locationBlock == null)
            {
                return NotFound();
            }

            return View(locationBlock);

        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var locationBlock = await _context.LocationBlocks.FindAsync(id);
            locationBlock.IsDeleted = 1;
            _context.Update(locationBlock);
            await _context.SaveChangesAsync();

            //---------------------------------Triggers locationState ML Delete--------------------------------------------//

            var BlockIDVL = _context.LocationBlockMls.Where(m => m.BlockId == id).FirstOrDefault();

            if (BlockIDVL != null)
            {
                _context.LocationBlockMls.Remove(BlockIDVL);
                await _context.SaveChangesAsync();
            }
            else
            {

            }
            return RedirectToAction(nameof(Index));
        }

        private bool LocationBlockExists(int id)
        {
            return _context.LocationBlocks.Any(e => e.BlockId == id);
        }

        public JsonResult GetDistrict(int stateid)
        {
            try
            {
                var districts = _context.LocationDistricts
                    .Where(m => m.StateId == stateid && m.IsDeleted == 0)
                    .OrderBy(p => p.District)
                    .Select(x => new
                    {
                        districtID = x.DistrictId,
                        district = x.District
                    })
                    .ToList();

                return Json(districts);
            }
            catch
            {
                return Json("0");
            }
        }

    }
}
