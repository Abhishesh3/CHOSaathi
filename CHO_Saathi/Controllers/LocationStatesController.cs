using CHO_Saathi.Common;
using CHO_Saathi.Models;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CHO_Saathi.Controllers
{
    public class LocationStatesController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment Environment;

        public LocationStatesController(ApplicationDBContext context, Microsoft.AspNetCore.Hosting.IHostingEnvironment environment)
        {
            _context = context;
            Environment = environment;
        }
        public async Task<IActionResult> Index()
        {

            if (HttpContext.Session.GetString("UserID") != null || HttpContext.Session.GetString("UserID") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserID")) != 0)
            {
                //int RoleID = Convert.ToInt32(HttpContext.Session.GetString("RoleID"));

                //int MenuID = _context.MstMenus.Where(m => m.Controller == "LocationStates" && m.Action == "Index").Select(m => m.MenuId).FirstOrDefault();
                //var DisplayRight = _context.RoleMenus.Where(c => c.RoleId == RoleID && c.MenuId == MenuID).Select(p => p.Display).FirstOrDefault();

                //if (DisplayRight == true)
                //{
                //    TempData["EditRight"] = _context.RoleMenus.Where(c => c.RoleId == Convert.ToInt32(HttpContext.Session.GetString("RoleID")) && c.MenuId == MenuID).Select(p => p.Edit).FirstOrDefault();

                //    TempData["DeleteRight"] = _context.RoleMenus.Where(c => c.RoleId == Convert.ToInt32(HttpContext.Session.GetString("RoleID")) && c.MenuId == MenuID).Select(p => p.IsDeleted).FirstOrDefault();

                //    TempData["AddRight"] = _context.RoleMenus.Where(c => c.RoleId == Convert.ToInt32(HttpContext.Session.GetString("RoleID")) && c.MenuId == MenuID).Select(p => p.AddNew).FirstOrDefault();

                //    //TempData["AddRight"] = _context.RoleMenus.Where(c => c.RoleID == Convert.ToInt32(HttpContext.Session.GetString("RoleID"))).Select(p => p.AddNew).FirstOrDefault();
                //    int pageSize = 10; int pageIndex = 1;
                //    var applicationDBContext = _context.LocationStates.Where(m => m.IsDeleted == 0).OrderBy(m => m.StateName).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                //    var countUser = _context.LocationStates.Where(m => m.IsDeleted == 0).OrderBy(m => m.StateName).Count();
                //    var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                //    TempData["pageIndex"] = pageIndex;
                //    TempData["PageSize"] = pageSize;
                //    TempData["MaxPageIndex"] = pageNo;

                //    return View(await applicationDBContext.ToListAsync());


                //}
                //else
                //{
                //    return RedirectToAction("Errors", "Error");
                //}



                int pageSize = 10; int pageIndex = 1;
                var applicationDBContext = _context.LocationStates.Where(m => m.IsDeleted == 0).OrderBy(m => m.StateName).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                var countUser = _context.LocationStates.Where(m => m.IsDeleted == 0).OrderBy(m => m.StateName).Count();
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

        public IActionResult getServerdt(int pageIndex, int pageSize, string selectedValue, string txtSearch)
        {
            if (txtSearch == null)
            {
                var applicationDBContext = _context.LocationStates.Where(m => m.IsDeleted == 0).OrderBy(m => m.StateName).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                var countUser = _context.LocationStates.Where(m => m.IsDeleted == 0).Count();
                var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                TempData["pageIndex"] = pageIndex;
                TempData["PageSize"] = pageSize;
                TempData["MaxPageIndex"] = pageNo;
                if (applicationDBContext != null)
                    return PartialView("_PVState", applicationDBContext.ToList());
                else
                    return Json("0");

            }
            else
            {
                var applicationDBContext = _context.LocationStates.Where(m => m.IsDeleted == 0 && m.StateName.Contains(txtSearch)).OrderBy(m => m.StateName).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                var countUser = _context.LocationStates.Where(m => m.IsDeleted == 0 && m.StateName.Contains(txtSearch)).Count();
                var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                TempData["pageIndex"] = pageIndex;
                TempData["PageSize"] = pageSize;
                TempData["MaxPageIndex"] = pageNo;
                if (applicationDBContext != null)
                    return PartialView("_PVState", applicationDBContext.ToList());
                else
                    return Json("0");

            }
        }

        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("UserID") != null || HttpContext.Session.GetString("UserID") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserID")) != 0)
            {
                //int RoleID = Convert.ToInt32(HttpContext.Session.GetString("RoleID"));

                //int MenuID = _context.MstMenus.Where(m => m.Controller == "LocationStates" && m.Action == "Index").Select(m => m.MenuId).FirstOrDefault();

                //var DisplayRight = _context.RoleMenus.Where(c => c.RoleId == RoleID && c.MenuId == MenuID).Select(p => p.Display).FirstOrDefault();

                //if (DisplayRight == true)
                //{
                //    ViewData["CreatedBy"] = new SelectList(_context.Users, "UserID", "Password");
                //    ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserID", "Password");
                //    return View();

                //}
                //else
                //{
                //    return RedirectToAction("Errors", "Error");
                //}

                ViewData["CreatedBy"] = new SelectList(_context.Users, "UserID", "Password");
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
        public async Task<IActionResult> Create([Bind("StateID,StateName,GISid,IsDeleted,StateCode,StateShortName,CreatedBy,CreatedOn,Sequence,UpdatedOn,UpdatedBy")] LocationState locationState)
        {
            if (ModelState.IsValid)
            {

                locationState.CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
                locationState.CreatedOn = DateTime.Now;
                locationState.IsDeleted = 0;
                _context.Add(locationState);
                await _context.SaveChangesAsync();

                //---------------------------------Triggers locationState ML Insertion--------------------------------------------//

                List<LocationStateMl> STML = new List<LocationStateMl>();
                STML.Add(new LocationStateMl
                {
                    StateId = locationState.StateId,
                    StateName = locationState.StateName,
                    LangId = 15
                });
                STML.Add(new LocationStateMl
                {
                    StateId = locationState.StateId,
                    StateName = locationState.StateName,
                    LangId = 2
                });
                _context.AddRange(STML);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            ViewData["CreatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationState.CreatedBy);
            ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationState.UpdatedBy);
            return View(locationState);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (HttpContext.Session.GetString("UserID") != null || HttpContext.Session.GetString("UserID") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserID")) != 0)
            {
                //int RoleID = Convert.ToInt32(HttpContext.Session.GetString("RoleID"));

                //int MenuID = _context.MstMenus.Where(m => m.Controller == "LocationStates" && m.Action == "Index").Select(m => m.MenuId).FirstOrDefault();

                //var DisplayRight = _context.RoleMenus.Where(c => c.RoleId == RoleID && c.MenuId == MenuID).Select(p => p.Display).FirstOrDefault();

                //if (DisplayRight == true)
                //{
                //    if (id == null)
                //    {
                //        return NotFound();
                //    }

                //    var locationState = await _context.LocationStates.FindAsync(id);
                //    if (locationState == null)
                //    {
                //        return NotFound();
                //    }
                //    ViewData["CreatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationState.CreatedBy);
                //    ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationState.UpdatedBy);
                //    return View(locationState);
                //}
                //else
                //{
                //    return RedirectToAction("Errors", "Error");
                //}

                var locationState = await _context.LocationStates.FindAsync(id);
                if (locationState == null)
                {
                    return NotFound();
                }
                ViewData["CreatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationState.CreatedBy);
                ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationState.UpdatedBy);
                return View(locationState);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StateId,StateName,GISid,IsDeleted,StateCode,StateShortName,CreatedBy,CreatedOn,Sequence,UpdatedOn,UpdatedBy")] LocationState locationState)
        {
            if (id != locationState.StateId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    locationState.UpdatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
                    locationState.UpdatedOn = DateTime.Now;
                    locationState.IsDeleted = 0;

                    var StateUser = _context.LocationStates.Where(m => m.StateId == id).FirstOrDefault();

                    StateUser.StateName = locationState.StateName;
                    StateUser.StateShortName = locationState.StateShortName;
                    StateUser.StateCode = locationState.StateCode;
                    StateUser.IsDeleted = locationState.IsDeleted;
                    StateUser.UpdatedBy = locationState.UpdatedBy;
                    StateUser.UpdatedOn = locationState.UpdatedOn;

                    _context.Update(StateUser);
                    await _context.SaveChangesAsync();

                    //---------------------------------Triggers locationState ML Update--------------------------------------------//

                    var StateIDVL = _context.LocationStateMls.Where(m => m.StateId == id).ToList();

                    StateIDVL.ForEach(m => m.StateId = locationState.StateId);
                    StateIDVL.ForEach(m => m.StateName = locationState.StateName);

                    _context.UpdateRange(StateIDVL);
                    await _context.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocationStateExists(locationState.StateId))
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

            ViewData["CreatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationState.CreatedBy);
            ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationState.UpdatedBy);
            return View(locationState);
        }

        private bool LocationStateExists(int id)
        {
            return _context.LocationStates.Any(e => e.StateId == id);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetString("UserID") != null || HttpContext.Session.GetString("UserID") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserID")) != 0)
            {
                //int RoleID = Convert.ToInt32(HttpContext.Session.GetString("RoleID"));

                //int MenuID = _context.MstMenus.Where(m => m.Controller == "LocationStates" && m.Action == "Index").Select(m => m.MenuId).FirstOrDefault();

                //var DisplayRight = _context.RoleMenus.Where(c => c.RoleId == RoleID && c.MenuId == MenuID).Select(p => p.Display).FirstOrDefault();

                //if (DisplayRight == true)
                //{
                //    if (id == null)
                //    {
                //        return NotFound();
                //    }

                //    var locationState = await _context.LocationStates.FirstOrDefaultAsync(m => m.StateId == id);
                //    if (locationState == null)
                //    {
                //        return NotFound();
                //    }

                //    return View(locationState);

                //}
                //else
                //{
                //    return RedirectToAction("Errors", "Error");
                //}

                var locationState = await _context.LocationStates.FirstOrDefaultAsync(m => m.StateId == id);
                if (locationState == null)
                {
                    return NotFound();
                }

                return View(locationState);

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
            var locationState = await _context.LocationStates.FindAsync(id);
            locationState.IsDeleted = 1;
            _context.Update(locationState);
            await _context.SaveChangesAsync();

            //---------------------------------Triggers locationState ML Delete--------------------------------------------//

            var StateIDVL = _context.LocationStateMls.Where(m => m.StateId == id).FirstOrDefault();

            if (StateIDVL != null)
            {
                _context.LocationStateMls.Remove(StateIDVL);
                await _context.SaveChangesAsync();
            }
            else
            {

            }
            return RedirectToAction(nameof(Index));
        }

        public ActionResult ExportToExcel(string Statename)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlParameter[] s = new SqlParameter[]
                {
                    //new SqlParameter("@StateID", StateId),
                    new SqlParameter("@StateName", Statename)
                };

                dt = CommonController.Procedure_Query_ToDataTable(_context, "USP_States_Fetch_Excel", CommandType.StoredProcedure, s);

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

                    string filePath = "Location_State_Data";
                    string ExcelTabName = "Location State";

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
                    return RedirectToAction("Index", "LocationStates");
                }
            }
            catch (Exception ex)
            {
                TempData["message"] = "Error while exporting!";
                return RedirectToAction("Index", "LocationStates");
            }
        }

    }
}
