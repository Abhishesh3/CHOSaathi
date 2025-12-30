using CHO_Saathi.Models;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CHO_Saathi.Controllers
{
    public class LocationFacilityTypesController : Controller
    {
        private readonly ApplicationDBContext _context;

        public LocationFacilityTypesController(ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {
                ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserID", "Password");
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FacilityTypeID,FacilityType,FacilityTypeCode,IsDeleted,Sequence,CreatedBy,CreatedOn,UpdatedOn,UpdatedBy")] LocationFacilityType locationFacilityType)
        {
            if (ModelState.IsValid)
            {
                locationFacilityType.CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
                locationFacilityType.CreatedOn = DateTime.Now;
                locationFacilityType.IsDeleted = 0;
                _context.Add(locationFacilityType);
                await _context.SaveChangesAsync();

                //---------------------------------Triggers FacliltyType ML Insertion--------------------------------------------//

                //List<LocationFacilityTypeML> FacilityTypeML = new List<LocationFacilityTypeML>();

                //FacilityTypeML.Add(new LocationFacilityTypeML
                //{
                //    FacilityTypeID = locationFacilityType.FacilityTypeID,
                //    FacilityType = locationFacilityType.FacilityType,
                //    LangID = 15
                //});
                //FacilityTypeML.Add(new LocationFacilityTypeML
                //{
                //    FacilityTypeID = locationFacilityType.FacilityTypeID,
                //    FacilityType = locationFacilityType.FacilityType,
                //    LangID = 2
                //});

                //_context.AddRange(FacilityTypeML);
                //_context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationFacilityType.UpdatedBy);
            return View(locationFacilityType);
        }

        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {
                int pageSize = 10;
                int pageIndex = 1;

                var applicationDBContext = _context.LocationFacilityTypes
                            .Where(m => m.IsDeleted == 0).OrderBy(m => m.FacilityType)
                            .Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                var countUser = _context.LocationFacilityTypes.Where(m => m.IsDeleted == 0).Count();

                var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                TempData["pageIndex"] = pageIndex;
                TempData["PageSize"] = pageSize;
                TempData["MaxPageIndex"] = pageNo;
                return View(await applicationDBContext.ToListAsync());
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult getServerdt(int pageSize, int pageIndex, string selectedValue, string txtSearch)
        {
            if (txtSearch == null)
            {
                var applicationDBContext = _context.LocationFacilityTypes
                    .Where(m => m.IsDeleted == 0).OrderBy(m => m.FacilityType)
                    .Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                var countUser = _context.LocationFacilityTypes.Where(m => m.IsDeleted == 0).Count();

                var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                TempData["pageIndex"] = pageIndex;
                TempData["PageSize"] = pageSize;
                TempData["MaxPageIndex"] = pageNo;
                return PartialView("_facuiltiesTypePartial", applicationDBContext.ToList());
            }
            else
            {
                var query = _context.LocationFacilityTypes
                    .Where(m => m.IsDeleted == 0 && m.FacilityType.Contains(txtSearch))
                    .OrderBy(m => m.FacilityType)
                    .AsNoTracking();
                var countUser = query.Count();
                var result = query.Skip(pageSize * (pageIndex - 1)).Take(pageSize);

                var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                TempData["pageIndex"] = pageIndex;
                TempData["PageSize"] = pageSize;
                TempData["MaxPageIndex"] = pageNo;
                return PartialView("_facuiltiesTypePartial", result.ToList());
            }
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {
                var locationFacilityType = await _context.LocationFacilityTypes.FindAsync(id);
                if (locationFacilityType == null)
                {
                    return NotFound();
                }
                ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationFacilityType.UpdatedBy);
                return View(locationFacilityType);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FacilityTypeId,FacilityType,FacilityTypeCode,IsDeleted,Sequence,CreatedBy,CreatedOn,UpdatedOn,UpdatedBy")] LocationFacilityType locationFacilityType)
        {
            if (id != locationFacilityType.FacilityTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    locationFacilityType.UpdatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
                    locationFacilityType.UpdatedOn = DateTime.Now;
                    locationFacilityType.IsDeleted = 0;
                    var FacilityType = _context.LocationFacilityTypes.Where(m => m.FacilityTypeId == id).FirstOrDefault();

                    FacilityType.FacilityType = locationFacilityType.FacilityType;
                    FacilityType.FacilityTypeCode = locationFacilityType.FacilityTypeCode;
                    FacilityType.Sequence = locationFacilityType.Sequence;
                    FacilityType.IsDeleted = locationFacilityType.IsDeleted;
                    FacilityType.UpdatedBy = locationFacilityType.UpdatedBy;
                    FacilityType.UpdatedOn = locationFacilityType.UpdatedOn;

                    _context.Update(FacilityType);
                    await _context.SaveChangesAsync();

                    //---------------------------------Triggers FacliltyType ML Update--------------------------------------------//

                    //var FacilityTypeIDVL = _context.LocationFacilityTypeMLs.Where(m => m.FacilityTypeID == id).ToList();

                    //FacilityTypeIDVL.ForEach(m => m.FacilityTypeID = locationFacilityType.FacilityTypeID);
                    //FacilityTypeIDVL.ForEach(m => m.FacilityType = locationFacilityType.FacilityType);

                    //_context.UpdateRange(FacilityTypeIDVL);
                    //await _context.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocationFacilityTypeExists(locationFacilityType.FacilityTypeId))
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
            ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationFacilityType.UpdatedBy);
            return View(locationFacilityType);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {
                var locationFacilityType = await _context.LocationFacilityTypes

                        .FirstOrDefaultAsync(m => m.FacilityTypeId == id);
                if (locationFacilityType == null)
                {
                    return NotFound();
                }

                return View(locationFacilityType);

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var locationFacilityType = await _context.LocationFacilityTypes.FindAsync(id);
            locationFacilityType.IsDeleted = 1;
            _context.Update(locationFacilityType);
            await _context.SaveChangesAsync();

            //---------------------------------Triggers FacliltyType ML Update--------------------------------------------//

            //var FacilityTypeVL = _context.LocationFacilityTypeMLs.Where(m => m.FacilityTypeID == id).FirstOrDefault();

            //if (FacilityTypeVL != null)
            //{
            //    _context.LocationFacilityTypeMLs.Remove(FacilityTypeVL);
            //    await _context.SaveChangesAsync();
            //}
            //else
            //{

            //}
            return RedirectToAction(nameof(Index));
        }

        private bool LocationFacilityTypeExists(int id)
        {
            return _context.LocationFacilityTypes.Any(e => e.FacilityTypeId == id);
        }
    }
}
