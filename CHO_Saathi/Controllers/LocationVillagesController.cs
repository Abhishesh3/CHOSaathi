using CHO_Saathi.Common;
using CHO_Saathi.Models;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CHO_Saathi.Controllers
{
    public class LocationVillagesController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment Environment;

        public LocationVillagesController(ApplicationDBContext context, Microsoft.AspNetCore.Hosting.IHostingEnvironment environment)
        {
            _context = context;
            Environment = environment;
        }

        public async Task<IActionResult> Index()
        {
            int pageSize = 10;
            int pageIndex = 1;

            ViewData["FacilityTypeId"] = new SelectList(_context.LocationFacilityTypes.Where(m => m.IsDeleted == 0).OrderBy(m => m.FacilityType), "FacilityTypeId", "FacilityType");

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
            // ---------- Bind Block Dropdown (Initially blank or All) ----------
            ViewBag.BlockID = new List<SelectListItem>
            {
                new SelectListItem { Value = "0", Text = "All" }
            };

            // ---------- Load Village List ----------
            var query = _context.LocationVillages
                .Where(m => m.IsDeleted == 0)
                .Include(l => l.State)
                .Include(l => l.District)
                .Include(l => l.Block)
                .Include(l => l.FacilityType)
                .Include(l => l.Facility)
                .Include(l => l.SubFacility)
                .OrderBy(m => m.State.StateName)
                .ThenBy(m => m.District)
                .ThenBy(m => m.Block)
                .ThenBy(m => m.Village)
                .AsNoTracking();

            var countUser = query.Count();
            var result = query.Skip(pageSize * (pageIndex - 1)).Take(pageSize);
            var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);

            TempData["pageIndex"] = pageIndex;
            TempData["PageSize"] = pageSize;
            TempData["MaxPageIndex"] = pageNo;

            return View(await result.ToListAsync());
        }

        public IActionResult getServerdt(int pageIndex, int pageSize, string State, string District, string Block, string FacilityTypeID, string Facility, string SubFacility, string selectedValue, string txtSearch)
        {
            var query = _context.LocationVillages.
                         Where(m => m.IsDeleted == 0
                         && (State == "0" || m.StateId == Convert.ToInt32(State))
                         && (District == "0" || m.DistrictId == Convert.ToInt32(District))
                         && (Block == "0" || m.BlockId == Convert.ToInt32(Block))
                         && (FacilityTypeID == "0" || m.FacilityTypeId == Convert.ToInt32(FacilityTypeID))
                         && (Facility == "0" || m.FacilityId == Convert.ToInt32(Facility))
                         && (SubFacility == "0" || m.SubFacilityId == Convert.ToInt32(SubFacility))
                         && (string.IsNullOrEmpty(txtSearch) || m.Village.Contains(txtSearch)))
                         .Include(l => l.State)
                         .Include(l => l.District)
                         .Include(l => l.Block)
                         .Include(l => l.FacilityType)
                         .Include(l => l.Facility)
                         .Include(l => l.SubFacility)
                         .OrderBy(m => m.State.StateName)
                         .ThenBy(m => m.District.District)
                         .ThenBy(m => m.Block)
                         .ThenBy(m => m.Village)
                         .AsNoTracking();

            var countUser = query.Count();
            var result = query.Skip(pageSize * (pageIndex - 1)).Take(pageSize);

            var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
            TempData["pageIndex"] = pageIndex;
            TempData["PageSize"] = pageSize;
            TempData["MaxPageIndex"] = pageNo;
            ViewBag.BlockView = result;

            return PartialView("_PVVillage", result.ToList());
        }

        public IActionResult Create()
        {
            ViewBag.StateList = _context.LocationStates
                .Where(x => x.IsDeleted == 0)
                .OrderBy(x => x.StateName)
                .Select(x => new SelectListItem
                {
                    Value = x.StateId.ToString(),
                    Text = x.StateName
                })
                .ToList();

            ViewBag.FacilityType = _context.LocationFacilityTypes
                .Where(x => x.IsDeleted == 0)
                .OrderBy(x => x.FacilityType)
                .Select(x => new SelectListItem
                {
                    Value = x.FacilityTypeId.ToString(),
                    Text = x.FacilityType
                })
                .ToList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LocationVillage locationVillage)
        {
            LoadDropdowns();

            locationVillage.CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
            locationVillage.CreatedOn = DateTime.Now;
            locationVillage.IsDeleted = 0;

            _context.LocationVillages.Add(locationVillage);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private void LoadDropdowns()
        {
            ViewBag.StateList = _context.LocationStates
                .Where(x => x.IsDeleted == 0)
                .Select(x => new SelectListItem
                {
                    Value = x.StateId.ToString(),
                    Text = x.StateName
                })
                .ToList();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            var locationVillage = await _context.LocationVillages.FindAsync(id);
            if (locationVillage == null)
            {
                return NotFound();
            }
            ViewData["CreatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationVillage.CreatedBy);
            ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationVillage.Updatedby);

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
                .Where(x => x.IsDeleted == 0 && x.StateId == locationVillage.StateId)
                .OrderBy(x => x.District)
                .Select(x => new SelectListItem
                {
                    Value = x.DistrictId.ToString(),
                    Text = x.District
                })
                .ToList();

            ViewBag.BlockID = _context.LocationBlocks
                .Where(x => x.IsDeleted == 0 && x.DistrictId == locationVillage.DistrictId)
                .OrderBy(x => x.District)
                .Select(x => new SelectListItem
                {
                    Value = x.BlockId.ToString(),
                    Text = x.BlockName
                })
                .ToList();

            ViewBag.FacilityType = _context.LocationFacilityTypes
                .OrderBy(x => x.FacilityType)
                .Select(x => new SelectListItem
                {
                    Value = x.FacilityTypeId.ToString(),
                    Text = x.FacilityType
                })
                .ToList();

            ViewBag.FacilityID = _context.LocationFacilities
                .Where(x => x.IsDeleted == 0 && x.BlockId == locationVillage.BlockId)
                .OrderBy(x => x.District)
                .Select(x => new SelectListItem
                {
                    Value = x.FacilityId.ToString(),
                    Text = x.FacilityName
                })
                .ToList();

            ViewBag.SubFacilityID = _context.LocationSubFacilities
                .Where(x => x.IsDeleted == 0 && x.FacilityId == locationVillage.FacilityId)
                .OrderBy(x => x.District)
                .Select(x => new SelectListItem
                {
                    Value = x.SubFacilityId.ToString(),
                    Text = x.SubFacility
                })
                .ToList();

            return View(locationVillage);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(LocationVillage locationVillage)
        {
            // Validate State
            if (locationVillage.StateId == 0)
            {
                TempData["message"] = "Please Select State..!!";

                ViewData["CreatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationVillage.CreatedBy);
                ViewData["DistrictID"] = new SelectList(_context.LocationDistricts.Where(m => m.IsDeleted == 0)
                    .OrderBy(m => m.District), "DistrictID", "District", locationVillage.DistrictId);
                ViewData["StateID"] = new SelectList(_context.LocationStates.Where(m => m.IsDeleted == 0)
                    .OrderBy(m => m.StateName), "StateID", "StateName", locationVillage.StateId);
                ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationVillage.Updatedby);

                return View(locationVillage);
            }

            // Validate District
            if (locationVillage.DistrictId == 0)
            {
                TempData["message"] = "Please Select District..!!";

                ViewData["CreatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationVillage.CreatedBy);
                ViewData["DistrictID"] = new SelectList(_context.LocationDistricts.Where(m => m.IsDeleted == 0)
                    .OrderBy(m => m.District), "DistrictID", "District", locationVillage.DistrictId);
                ViewData["StateID"] = new SelectList(_context.LocationStates.Where(m => m.IsDeleted == 0)
                    .OrderBy(m => m.StateName), "StateID", "StateName", locationVillage.StateId);
                ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationVillage.Updatedby);

                return View(locationVillage);
            }

            try
            {
                // Fetch existing village
                var existingVillage = await _context.LocationVillages
                    .FirstOrDefaultAsync(m => m.VillageId == locationVillage.VillageId);

                if (existingVillage == null)
                {
                    return NotFound();
                }

                // Update main Block entry
                existingVillage.Village = locationVillage.Village;
                existingVillage.VillageCode = locationVillage.VillageCode;
                existingVillage.StateId = locationVillage.StateId;
                existingVillage.DistrictId = locationVillage.DistrictId;
                existingVillage.BlockId = locationVillage.BlockId;
                existingVillage.Updatedby = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
                existingVillage.UpdatedOn = DateTime.Now;
                existingVillage.IsDeleted = 0;

                // Save all changes
                _context.Update(existingVillage);

                await _context.SaveChangesAsync();

                TempData["message"] = "Village updated successfully!";
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocationVillageExists(locationVillage.VillageId))
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
            var locationVillage = await _context.LocationVillages
                        .Include(l => l.District)
                        .Include(l => l.State)
                        .Include(l => l.Block)
                        .Include(l => l.Facility)
                        .Include(l => l.SubFacility)
                        .FirstOrDefaultAsync(m => m.VillageId == id);
            if (locationVillage == null)
            {
                return NotFound();
            }

            return View(locationVillage);

        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var locationVillage = await _context.LocationVillages.FindAsync(id);
            locationVillage.IsDeleted = 1;
            _context.Update(locationVillage);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        private bool LocationVillageExists(int id)
        {
            return _context.LocationVillages.Any(e => e.VillageId == id);
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

        public JsonResult GetBlock(int DistrictId)
        {
            try
            {
                var block = _context.LocationBlocks
                    .Where(m => m.DistrictId == DistrictId)
                    .OrderBy(m => m.BlockName)
                    .Select(m => new
                    {
                        blockID = m.BlockId,
                        blockName = m.BlockName,
                    }).ToList();
                return Json(block);
            }
            catch (Exception)
            {
                return Json("0");
            }
        }

        public JsonResult GetFacility(int BlockId)
        {
            try
            {
                var facility = _context.LocationFacilities
                    .Where(p => p.BlockId == BlockId)
                    .OrderBy(p => p.FacilityName)
                    .Select(p => new
                    {
                        facilityID = p.FacilityId,
                        facilityName = p.FacilityName
                    }).ToList();
                return Json(facility);
            }
            catch (Exception)
            {
                return Json("0");
            }
        }

        public JsonResult GetSubFacility(int FacilityId)
        {
            try
            {
                var subFacility = _context.LocationSubFacilities
                    .Where(m => m.FacilityId == FacilityId)
                    .OrderBy(m => m.SubFacility)
                    .Select(m => new
                    {
                        subFacilityID = m.SubFacilityId,
                        subFacility = m.SubFacility
                    }).ToList();
                return Json(subFacility);
            }
            catch (Exception)
            {
                return Json("0");
            }
        }

        public ActionResult ExportToExcel(int StateId, int DistrictId, int BlockId, int FacilityTypeId, int FacilityId, int SubFacilityId, string VillageName)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlParameter[] s = new SqlParameter[]
                {
                    new SqlParameter("@StateID", StateId),
                    new SqlParameter("@DistrictID", DistrictId),
                    new SqlParameter("@BlockID", BlockId),
                    new SqlParameter("@FacilityTypeID", FacilityTypeId),
                    new SqlParameter("@FacilityID", FacilityId),
                    new SqlParameter("@SubFacilityID", SubFacilityId),
                    new SqlParameter("@VillageName", VillageName)
                };

                dt = CommonController.Procedure_Query_ToDataTable(_context, "USP_Village_Fetch_Excel", CommandType.StoredProcedure, s);

                if (dt != null && dt.Rows.Count > 0)
                {
                    // ✅ Add S.No column only once at the first position
                    if (!dt.Columns.Contains("S.No"))
                    {
                        dt.Columns.Add("S.No", typeof(int)).SetOrdinal(0);
                    }

                    // Fill serial numbers
                    int counter = 1;
                    foreach (DataRow dr in dt.Rows)
                    {
                        dr["S.No"] = counter++;
                    }

                    string filePath = "Location_Village_Data";
                    string ExcelTabName = "Location Village";

                    string webRootPath = Environment.WebRootPath;
                    string sFileDir = Path.Combine(webRootPath, "DataBackup/");

                    if (!Directory.Exists(sFileDir))
                        Directory.CreateDirectory(sFileDir);

                    string Fullfilename = filePath + "_" + DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss") + ".xlsx";

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var ws = wb.Worksheets.Add(dt, ExcelTabName);
                        ws.Table(0).ShowAutoFilter = false;
                        ws.Table(0).Theme = XLTableTheme.TableStyleLight12;
                        ws.Columns().AdjustToContents();

                        using (MemoryStream stream = new MemoryStream())
                        {
                            wb.SaveAs(stream);
                            return File(stream.ToArray(),
                                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                                        Fullfilename);
                        }
                    }
                }
                else
                {
                    TempData["message"] = "No Record Found..!!";
                    return RedirectToAction("Index", "LocationVillages");
                }
            }
            catch (Exception ex)
            {
                TempData["message"] = "Error while exporting!";
                return RedirectToAction("Index", "LocationVillages");
            }
        }
    }
}
