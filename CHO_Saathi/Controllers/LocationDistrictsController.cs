using CHO_Saathi.Common;
using CHO_Saathi.Models;
using CHO_Saathi.ViewComponents;
using ClosedXML.Excel;

//using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CHO_Saathi.Controllers
{
    public class LocationDistrictsController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment Environment;

        public LocationDistrictsController(ApplicationDBContext context, Microsoft.AspNetCore.Hosting.IHostingEnvironment environment)
        {
            _context = context;
            Environment = environment;
        }

        public async Task<IActionResult> Index()
        {
            int pageIndex = 1;
            int pageSize = 10;

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

            // ---------- Load District List ----------
            var query = _context.LocationDistricts.
                        Where(m => m.IsDeleted == 0)
                        .Include(l => l.State)
                        .OrderBy(m => m.State)
                        .OrderBy(m => m.State.StateName)
                        .ThenBy(m => m.District)
                        .AsNoTracking();
            var countUser = query.Count();
            var result = query.Skip(pageSize * (pageIndex - 1)).Take(pageSize);
            var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
            TempData["PageIndex"] = pageIndex;
            TempData["PageSize"] = pageSize;
            TempData["MaxPageIndex"] = pageNo;
            return View(await result.ToListAsync());

        }

        public IActionResult getServerdt(int pageIndex, int pageSize, string State, string selectedValue, string txtSearch)
        {
            if (!string.IsNullOrEmpty(State))
            {
                var query = _context.LocationDistricts
                            .Where(m => m.IsDeleted == 0 && ((State == "0" || m.StateId == Convert.ToInt32(State))
                            && (string.IsNullOrEmpty(txtSearch) || m.District.Contains(txtSearch))
                            && m.IsDeleted == 0))
                            .Include(l => l.State)
                            .OrderBy(m => m.State.StateName)
                            .ThenBy(m => m.District)
                            .AsNoTracking();

                var countUser = query.Count();
                var result = query.Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                TempData["pageIndex"] = pageIndex;
                TempData["PageSize"] = pageSize;
                TempData["MaxPageIndex"] = pageNo;
                ViewBag.VillageView = result;
                return PartialView("_PVDistrict", result.ToList());


            }
            else
            {
                return Json("0");
            }

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

            return View(new LocationDistrict());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LocationDistrict locationDistrict)
        {
            if (locationDistrict.StateId != 0)
            {
                locationDistrict.CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
                locationDistrict.CreatedOn = DateTime.Now;
                locationDistrict.IsDeleted = 0;
                _context.Add(locationDistrict);
                await _context.SaveChangesAsync();

                //---------------------------------Triggers locationDistrict ML Insertion--------------------------------------------//

                List<LocationDistrictMl> DistrictML = new List<LocationDistrictMl>();
                DistrictML.Add(new LocationDistrictMl
                {
                    DistrictId = locationDistrict.DistrictId,
                    District = locationDistrict.District,
                    LangId = 15
                });
                DistrictML.Add(new LocationDistrictMl
                {
                    DistrictId = locationDistrict.DistrictId,
                    District = locationDistrict.District,
                    LangId = 2
                });
                _context.AddRange(DistrictML);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            else
            {
                TempData["message"] = "Please Select State..!!";
            }


            ViewData["CreatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationDistrict.CreatedBy);
            
            ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationDistrict.UpdatedBy);
           
            ViewBag.StateList = _context.LocationStates
                .Where(x => x.IsDeleted == 0)
                .OrderBy(x => x.StateName)
                .Select(x => new SelectListItem
                {
                    Value = x.StateId.ToString(),
                    Text = x.StateName
                })
                .ToList();

            return View(new LocationDistrict());
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (HttpContext.Session.GetString("UserID") != null || HttpContext.Session.GetString("UserID") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserID")) != 0)
            {
                int RoleID = Convert.ToInt32(HttpContext.Session.GetString("RoleID"));

                int MenuID = _context.MstMenus.Where(m => m.Controller == "LocationDistricts" && m.Action == "Index").Select(m => m.MenuId).FirstOrDefault();

                var DisplayRight = _context.RoleMenus.Where(c => c.RoleId == RoleID && c.MenuId == MenuID).Select(p => p.Display).FirstOrDefault();

                var locationDistrict = await _context.LocationDistricts.FindAsync(id);
                if (locationDistrict == null)
                {
                    return NotFound();
                }
                ViewData["CreatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationDistrict.CreatedBy);
               
                ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationDistrict.UpdatedBy);

                ViewBag.StateList = _context.LocationStates
                                .Where(x => x.IsDeleted == 0)
                                .OrderBy(x => x.StateName)
                                .Select(x => new SelectListItem
                                {
                                    Value = x.StateId.ToString(),
                                    Text = x.StateName
                                })
                                .ToList();

                return View(locationDistrict);

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(LocationDistrict locationDistrict)
        {
            if (locationDistrict.StateId == 0)
            {
                TempData["message"] = "Please Select State..!!";

                ViewData["CreatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationDistrict.CreatedBy);
                ViewData["StateID"] = new SelectList(_context.LocationStates.Where(m => m.IsDeleted == 0)
                    .OrderBy(m => m.StateName), "StateID", "StateName", locationDistrict.StateId);
                ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationDistrict.UpdatedBy);

                return View(locationDistrict);
            }

            try
            {
                var existingDistrict = await _context.LocationDistricts
                    .FirstOrDefaultAsync(m => m.DistrictId == locationDistrict.DistrictId);

                if (existingDistrict == null)
                {
                    return NotFound();
                }

                // Update main district
                existingDistrict.District = locationDistrict.District;
                existingDistrict.DistrictCode = locationDistrict.DistrictCode;
                existingDistrict.StateId = locationDistrict.StateId;
                existingDistrict.UpdatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
                existingDistrict.UpdatedOn = DateTime.Now;
                existingDistrict.IsDeleted = 0;

                // Update related ML entries
                var relatedMLs = _context.LocationDistrictMls
                    .Where(m => m.DistrictId == existingDistrict.DistrictId)
                    .ToList();

                foreach (var ml in relatedMLs)
                {
                    ml.District = locationDistrict.District;
                }

                // Save all changes in a single transaction
                _context.Update(existingDistrict);
                _context.UpdateRange(relatedMLs);
                await _context.SaveChangesAsync();

                TempData["message"] = "District updated successfully!";
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocationDistrictExists(locationDistrict.DistrictId))
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
            if (HttpContext.Session.GetString("UserID") != null || HttpContext.Session.GetString("UserID") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserID")) != 0)
            {
                int RoleID = Convert.ToInt32(HttpContext.Session.GetString("RoleID"));

                var locationDistrict = await _context.LocationDistricts

                        .Include(l => l.State)
                        .FirstOrDefaultAsync(m => m.DistrictId == id);
                if (locationDistrict == null)
                {
                    return NotFound();
                }

                return View(locationDistrict);

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
            var locationDistrict = await _context.LocationDistricts.FindAsync(id);
            locationDistrict.IsDeleted = 1;
            _context.Update(locationDistrict);
            await _context.SaveChangesAsync();

            //---------------------------------Triggers locationDistrict ML Delete--------------------------------------------//

            var DistrictIDVL = _context.LocationDistrictMls.Where(m => m.DistrictId == id).FirstOrDefault();

            if (DistrictIDVL != null)
            {
                _context.LocationDistrictMls.Remove(DistrictIDVL);
                await _context.SaveChangesAsync();
            }
            else
            {

            }
            return RedirectToAction(nameof(Index));
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

        private bool LocationDistrictExists(int id)
        {
            return _context.LocationDistricts.Any(e => e.DistrictId == id);
        }

        public ActionResult ExportToExcel(int StateId, string DistrictName)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlParameter[] s = new SqlParameter[]
                {
                    new SqlParameter("@StateID", StateId),
                    new SqlParameter("@DistrictName", DistrictName)
                };

                dt = CommonController.Procedure_Query_ToDataTable(_context, "USP_Districts_Fetch_Excel", CommandType.StoredProcedure, s);

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

                    string filePath = "Location_District_Data";
                    string ExcelTabName = "Location District";

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
                    return RedirectToAction("Index", "LocationDistricts");
                }
            }
            catch (Exception ex)
            {
                TempData["message"] = "Error while exporting!";
                return RedirectToAction("Index", "LocationDistricts");
            }
        }
    }
}
