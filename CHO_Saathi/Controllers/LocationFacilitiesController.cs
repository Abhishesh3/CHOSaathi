using CHO_Saathi.Models;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mono.TextTemplating;
using NPOI.SS.UserModel;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHO_Saathi.Controllers
{
    public class LocationFacilitiesController : Controller
    {
        private readonly ApplicationDBContext _context;

        public LocationFacilitiesController(ApplicationDBContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {
                int pageSize = 10;
                int pageIndex = 1;

                ViewData["StateID"] = new SelectList(_context.LocationStates.Where(m => m.IsDeleted == 0).OrderBy(m => m.StateName), "StateId", "StateName");
                ViewData["FaclityTypeID"] = new SelectList(_context.LocationFacilityTypes.Where(m => m.IsDeleted == 0).OrderBy(m => m.FacilityType), "FacilityTypeId", "FacilityType");
                var applicationDBContext = _context.LocationFacilities
                    .Where(m => m.IsDeleted == 0).OrderBy(m => m.State.StateName)
                    .Include(l => l.Block).Include(l => l.District).Include(l => l.FacilityType).Include(l => l.State).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                var countUser = _context.LocationFacilities.Where(m => m.IsDeleted == 0).Count();
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

        public IActionResult getServerdt(int pageSize,int pageIndex,string State, string District,string Block,string FacilityType,string selectedValue,string txtSearch)
        {
            if (!string.IsNullOrEmpty(State) && !string.IsNullOrEmpty(District) && !string.IsNullOrEmpty(Block) && !string.IsNullOrEmpty(FacilityType))
            {
                if (txtSearch == null)
                {
                    if (State == "0" && District == "0" && Block == "0" && FacilityType == "0")
                    {
                        var applicationDBContext = _context.LocationFacilities.Where(m => m.IsDeleted == 0).OrderBy(m => m.State.StateName).Include(l => l.Block).Include(l => l.District).Include(l => l.FacilityType).Include(l => l.State).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                        var countUser = _context.LocationFacilities.Where(m => m.IsDeleted == 0).Count();
                        var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                        TempData["pageIndex"] = pageIndex;
                        TempData["PageSize"] = pageSize;
                        TempData["MaxPageIndex"] = pageNo;
                        ViewBag.BlockView = applicationDBContext;

                        return PartialView("_PVFaclities", applicationDBContext);
                    }
                    else if (State == "0" && District == "0" && Block == "0" && FacilityType != "0")
                    {
                        var applicationDBContext = _context.LocationFacilities.Where(m => m.IsDeleted == 0 && m.FacilityTypeId == Convert.ToInt32(FacilityType)).OrderBy(m => m.State.StateName).Include(l => l.Block).Include(l => l.District).Include(l => l.FacilityType).Include(l => l.State).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                        var countUser = _context.LocationFacilities.Where(m => m.IsDeleted == 0 && m.FacilityTypeId == Convert.ToInt32(FacilityType)).Count();
                        var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                        TempData["pageIndex"] = pageIndex;
                        TempData["PageSize"] = pageSize;
                        TempData["MaxPageIndex"] = pageNo;
                        ViewBag.BlockView = applicationDBContext;

                        return PartialView("_PVFaclities", applicationDBContext);
                    }
                    else if (State != "0" && District == "0" && Block == "0" && FacilityType == "0")
                    {
                        var applicationDBContext = _context.LocationFacilities.Where(m => m.StateId == Convert.ToInt32(State) && m.IsDeleted == 0).OrderBy(m => m.State.StateName).Include(l => l.Block).Include(l => l.District).Include(l => l.FacilityType).Include(l => l.State).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                        var countUser = _context.LocationFacilities.Where(m => m.StateId == Convert.ToInt32(State) && m.IsDeleted == 0).Count();
                        var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                        TempData["pageIndex"] = pageIndex;
                        TempData["PageSize"] = pageSize;
                        TempData["MaxPageIndex"] = pageNo;
                        ViewBag.BlockView = applicationDBContext;

                        return PartialView("_PVFaclities", applicationDBContext);
                    }
                    else if (State != "0" && District != "0" && Block == "0" && FacilityType == "0")
                    {
                        var applicationDBContext = _context.LocationFacilities.Where(m => m.StateId == Convert.ToInt32(State) && m.DistrictId == Convert.ToInt32(District) && m.IsDeleted == 0).OrderBy(m => m.State.StateName).Include(l => l.Block).Include(l => l.District).Include(l => l.FacilityType).Include(l => l.State).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                        var countUser = _context.LocationFacilities.Where(m => m.StateId == Convert.ToInt32(State) && m.DistrictId == Convert.ToInt32(District) && m.IsDeleted == 0).Count();
                        var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                        TempData["pageIndex"] = pageIndex;
                        TempData["PageSize"] = pageSize;
                        TempData["MaxPageIndex"] = pageNo;
                        ViewBag.BlockView = applicationDBContext;

                        return PartialView("_PVFaclities", applicationDBContext);
                    }
                    else if (State != "0" && District != "0" && Block != "0" && FacilityType == "0")
                    {
                        var applicationDBContext = _context.LocationFacilities.Where(m => m.StateId == Convert.ToInt32(State) && m.DistrictId == Convert.ToInt32(District) && m.BlockId == Convert.ToInt32(Block) && m.IsDeleted == 0).OrderBy(m => m.State.StateName).Include(l => l.Block).Include(l => l.District).Include(l => l.FacilityType).Include(l => l.State).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                        var countUser = _context.LocationFacilities.Where(m => m.StateId == Convert.ToInt32(State) && m.DistrictId == Convert.ToInt32(District) && m.BlockId == Convert.ToInt32(Block) && m.IsDeleted == 0).Count();
                        var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                        TempData["pageIndex"] = pageIndex;
                        TempData["PageSize"] = pageSize;
                        TempData["MaxPageIndex"] = pageNo;
                        ViewBag.BlockView = applicationDBContext;

                        return PartialView("_PVFaclities", applicationDBContext);
                    }
                    else if (State != "0" && District != "0" && Block != "0" && FacilityType != "0")
                    {
                        var applicationDBContext = _context.LocationFacilities.Where(m => m.StateId == Convert.ToInt32(State) && m.DistrictId == Convert.ToInt32(District) && m.BlockId == Convert.ToInt32(Block) && m.FacilityTypeId == Convert.ToInt32(FacilityType) && m.IsDeleted == 0).OrderBy(m => m.State.StateName).Include(l => l.Block).Include(l => l.District).Include(l => l.FacilityType).Include(l => l.State).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                        var countUser = _context.LocationFacilities.Where(m => m.StateId == Convert.ToInt32(State) && m.DistrictId == Convert.ToInt32(District) && m.BlockId == Convert.ToInt32(Block) && m.FacilityTypeId == Convert.ToInt32(FacilityType) && m.IsDeleted == 0).Count();
                        var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                        TempData["pageIndex"] = pageIndex;
                        TempData["PageSize"] = pageSize;
                        TempData["MaxPageIndex"] = pageNo;
                        ViewBag.BlockView = applicationDBContext;

                        return PartialView("_PVFaclities", applicationDBContext);
                    }
                    else
                    {
                        var applicationDBContext = _context.LocationFacilities.Where(m => m.IsDeleted == 0).OrderBy(m => m.State.StateName).Include(l => l.Block).Include(l => l.District).Include(l => l.FacilityType).Include(l => l.State).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                        var countUser = _context.LocationFacilities.Where(m => m.IsDeleted == 0).Count();
                        var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                        TempData["pageIndex"] = pageIndex;
                        TempData["PageSize"] = pageSize;
                        TempData["MaxPageIndex"] = pageNo;
                        ViewBag.BlockView = applicationDBContext;

                        return PartialView("_PVFaclities", applicationDBContext);
                    }
                }
                else
                {
                    var applicationDBContext = _context.LocationFacilities.Where(m => m.IsDeleted == 0).OrderBy(m => m.State.StateName)
                        .Include(l => l.Block).Include(l => l.District)
                        .Include(l => l.FacilityType).Include(l => l.State).ToList()
                        .Where(m=>m.FacilityName.ToString().Contains(txtSearch))
                        .Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                    var countUser = _context.LocationFacilities.Where(m => m.IsDeleted == 0)
                         .Include(l => l.Block).Include(l => l.District)
                        .Include(l => l.FacilityType).Include(l => l.State).ToList()
                        .Where(m => m.FacilityName.ToString().Contains(txtSearch)).Count();
                    var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                    TempData["pageIndex"] = pageIndex;
                    TempData["PageSize"] = pageSize;
                    TempData["MaxPageIndex"] = pageNo;
                    ViewBag.BlockView = applicationDBContext;

                    return PartialView("_PVFaclities", applicationDBContext);
                }
               
            }
            // return View();
            return PartialView("/Views/LocationFacilities/_PVFaclities.cshtml");
        }

        public IActionResult Details()
        {
            return View();
        }


        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {
                ViewData["CreatedBy"] = new SelectList(_context.Users, "UserId", "Password");
                
                ViewData["FacilityTypeId"] = new SelectList(_context.LocationFacilityTypes.Where(m => m.IsDeleted == 0).OrderBy(m => m.FacilityType), "FacilityTypeId", "FacilityType");
                ViewData["StateId"] = new SelectList(_context.LocationStates.Where(m => m.IsDeleted == 0).OrderBy(m => m.StateName), "StateId", "StateName");
                ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserId", "Password");
                return View();

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
         
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LocationFacility locationFacility)
        {
            if (locationFacility.StateId != 0)
            {
                if (locationFacility.DistrictId != 0)
                {
                    if (locationFacility.BlockId != 0)
                    {
                        if (locationFacility.FacilityTypeId != 0)
                        {
                            locationFacility.CreatedBy =
                                Convert.ToInt32(HttpContext.Session.GetString("UserId"));
                            locationFacility.CreatedOn = DateTime.Now;
                            locationFacility.IsDeleted = 0;

                            _context.Add(locationFacility);
                            await _context.SaveChangesAsync();

                            //--------------------------------- Facility ML Insertion --------------------------------------------//

                           

                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            TempData["message"] = "Please Select Facility Type..!!";
                        }
                    }
                    else
                    {
                        TempData["message"] = "Please Select Block..!!";
                    }
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

            // ---------------- Rebind Dropdowns ---------------- //

            ViewBag.StateList = _context.LocationStates
                .Where(x => x.IsDeleted == 0)
                .OrderBy(x => x.StateName)
                .Select(x => new SelectListItem
                {
                    Value = x.StateId.ToString(),
                    Text = x.StateName
                })
                .ToList();

            ViewBag.DistrictList = _context.LocationDistricts
                .Where(x => x.IsDeleted == 0 && x.StateId == locationFacility.StateId)
                .OrderBy(x => x.District)
                .Select(x => new SelectListItem
                {
                    Value = x.DistrictId.ToString(),
                    Text = x.District
                })
                .ToList();

            ViewBag.BlockList = _context.LocationBlocks
                .Where(x => x.IsDeleted == 0 && x.DistrictId == locationFacility.DistrictId)
                .OrderBy(x => x.BlockName)
                .Select(x => new SelectListItem
                {
                    Value = x.BlockId.ToString(),
                    Text = x.BlockName
                })
                .ToList();

            ViewBag.FacilityTypeList = _context.LocationFacilityTypes
                .Where(x => x.IsDeleted == 0)
                .OrderBy(x => x.FacilityType)
                .Select(x => new SelectListItem
                {
                    Value = x.FacilityTypeId.ToString(),
                    Text = x.FacilityType
                })
                .ToList();

            ViewData["CreatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationFacility.CreatedBy);
            ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationFacility.UpdatedBy);

            return View(locationFacility);
        }


        public async Task<IActionResult> Edit(int? id)
        {

            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {
                //int RoleId = Convert.ToInt32(HttpContext.Session.GetString("RoleId"));

                //int MenuID = _context.MstMenus.Where(m => m.Controller == "LocationFacilities" && m.Action == "Index").Select(m => m.MenuId).FirstOrDefault();

                //var DisplayRight = _context.RoleMenus.Where(c => c.RoleId == RoleId && c.MenuId == MenuID).Select(p => p.Display).FirstOrDefault();


                if (id == null)
                {
                    return NotFound();
                }

                var locationFacility = await _context.LocationFacilities.FindAsync(id);
                if (locationFacility == null)
                {
                    return NotFound();
                }
                ViewData["BlockID"] = new SelectList(_context.LocationBlocks.Where(m => m.IsDeleted == 0).OrderBy(m => m.BlockName), "BlockId", "BlockName", locationFacility.BlockId);
                ViewData["CreatedBy"] = new SelectList(_context.Users, "UserId", "Password", locationFacility.CreatedBy);
                ViewData["DistrictID"] = new SelectList(_context.LocationDistricts.Where(m => m.IsDeleted == 0).OrderBy(m => m.District), "DistrictId", "District", locationFacility.DistrictId);
                ViewData["FacilityTypeID"] = new SelectList(_context.LocationFacilityTypes.Where(m => m.IsDeleted == 0).OrderBy(m => m.FacilityType), "FacilityTypeId", "FacilityType", locationFacility.FacilityTypeId);
                ViewData["StateID"] = new SelectList(_context.LocationStates.Where(m => m.IsDeleted == 0).OrderBy(m => m.StateName), "StateId", "StateName", locationFacility.StateId);
                ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserId", "Password", locationFacility.UpdatedBy);
                return View(locationFacility);

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }


        }


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(LocationFacility locationFacility)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (locationFacility.StateId == 0)
        //        {
        //            TempData["message"] = "Please Select State..!!";
        //        }
        //        else if (locationFacility.DistrictId == 0)
        //        {
        //            TempData["message"] = "Please Select District..!!";
        //        }
        //        else if (locationFacility.BlockId == 0)
        //        {
        //            TempData["message"] = "Please Select Block..!!";
        //        }
        //        else if (locationFacility.FacilityTypeId == 0)
        //        {
        //            TempData["message"] = "Please Select Facility Type..!!";
        //        }
        //        else
        //        {
        //            try
        //            {
        //                var existingFacility = await _context.LocationFacilities.FindAsync(id);
        //                if (existingFacility != null)
        //                {
        //                    existingFacility.FacilityTypeId = locationFacility.FacilityTypeId;
        //                    existingFacility.FacilityName = locationFacility.FacilityName;
        //                    existingFacility.FacilityCode = locationFacility.FacilityCode;
        //                    existingFacility.FacilityAddress = locationFacility.FacilityAddress;
        //                    existingFacility.FacilityContactNo = locationFacility.FacilityContactNo;
        //                    existingFacility.BlockId = locationFacility.BlockId;
        //                    existingFacility.DistrictId = locationFacility.DistrictId;
        //                    existingFacility.StateId = locationFacility.StateId;
        //                    existingFacility.IsDeleted = locationFacility.IsDeleted;
        //                    existingFacility.UpdatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
        //                    existingFacility.UpdatedOn = DateTime.Now;
        //                    //existingFacility.HFRId = locationFacility.HFRID;

        //                    _context.Update(existingFacility);
        //                    await _context.SaveChangesAsync();

        //                    // Triggers Facility ML Insertion
        //                    //var facilityMLs = await _context.LocationFacilityMLs.Where(m => m.FacilityID == id).ToListAsync();
        //                    //facilityMLs.ForEach(m =>
        //                    //{
        //                    //    m.FacilityID = locationFacility.FacilityID;
        //                    //    m.FacilityName = locationFacility.FacilityName;
        //                    //    m.FacilityAddress = locationFacility.FacilityAddress;
        //                    //    m.FacilityContactNo = locationFacility.FacilityContactNo;
        //                    //});

        //                    //_context.UpdateRange(facilityMLs);
        //                    //await _context.SaveChangesAsync();

        //                    return RedirectToAction(nameof(Index));
        //                }
        //                else
        //                {
        //                    return NotFound();
        //                }
        //            }
        //            catch (DbUpdateConcurrencyException)
        //            {
        //                if (!LocationFacilityExists(locationFacility.FacilityId))
        //                {
        //                    return NotFound();
        //                }
        //                else
        //                {
        //                    throw;
        //                }
        //            }
        //        }
        //    }

        //    ViewData["BlockID"] = new SelectList(_context.LocationBlocks.Where(m => m.IsDeleted == 0).OrderBy(m => m.BlockName), "BlockID", "BlockName", locationFacility.BlockId);
        //    ViewData["CreatedBy"] = new SelectList(_context.Users, "UserId", "Password", locationFacility.CreatedBy);
        //    ViewData["DistrictID"] = new SelectList(_context.LocationDistricts.Where(m => m.IsDeleted == 0).OrderBy(m => m.District), "DistrictID", "District", locationFacility.DistrictId);
        //    ViewData["FacilityTypeID"] = new SelectList(_context.LocationFacilityTypes.Where(m => m.IsDeleted == 0).OrderBy(m => m.FacilityType), "FacilityTypeID", "FacilityType", locationFacility.FacilityTypeId);
        //    ViewData["StateID"] = new SelectList(_context.LocationStates.Where(m => m.IsDeleted == 0).OrderBy(m => m.StateName), "StateID", "StateName", locationFacility.StateId);
        //    ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserId", "Password", locationFacility.UpdatedBy);

        //    return View(locationFacility);
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(LocationFacility locationFacility)
        {
            // Validate State
            if (locationFacility.StateId == 0)
            {
                TempData["message"] = "Please Select State..!!";
                LoadFacilityDropdowns(locationFacility);
                return View(locationFacility);
            }

            // Validate District
            if (locationFacility.DistrictId == 0)
            {
                TempData["message"] = "Please Select District..!!";
                LoadFacilityDropdowns(locationFacility);
                return View(locationFacility);
            }

            // Validate Block
            if (locationFacility.BlockId == 0)
            {
                TempData["message"] = "Please Select Block..!!";
                LoadFacilityDropdowns(locationFacility);
                return View(locationFacility);
            }

            // Validate Facility Type
            if (locationFacility.FacilityTypeId == 0)
            {
                TempData["message"] = "Please Select Facility Type..!!";
                LoadFacilityDropdowns(locationFacility);
                return View(locationFacility);
            }

            try
            {
                // Fetch existing facility
                var existingFacility = await _context.LocationFacilities
                    .FirstOrDefaultAsync(m => m.FacilityId == locationFacility.FacilityId);

                if (existingFacility == null)
                {
                    return NotFound();
                }

                // Update Facility master
                existingFacility.FacilityTypeId = locationFacility.FacilityTypeId;
                existingFacility.FacilityName = locationFacility.FacilityName;
                existingFacility.FacilityCode = locationFacility.FacilityCode;
                existingFacility.FacilityAddress = locationFacility.FacilityAddress;
                existingFacility.FacilityContactNo = locationFacility.FacilityContactNo;
                existingFacility.StateId = locationFacility.StateId;
                existingFacility.DistrictId = locationFacility.DistrictId;
                existingFacility.BlockId = locationFacility.BlockId;
                existingFacility.IsDeleted = locationFacility.IsDeleted;
                existingFacility.UpdatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
                existingFacility.UpdatedOn = DateTime.Now;

                _context.Update(existingFacility);

                // OPTIONAL: Update Facility ML entries (if required later)
                /*
                var relatedMLs = _context.LocationFacilityMLs
                    .Where(m => m.FacilityID == existingFacility.FacilityId)
                    .ToList();

                foreach (var ml in relatedMLs)
                {
                    ml.FacilityName = locationFacility.FacilityName;
                    ml.FacilityAddress = locationFacility.FacilityAddress;
                    ml.FacilityContactNo = locationFacility.FacilityContactNo;
                }

                _context.UpdateRange(relatedMLs);
                */

                await _context.SaveChangesAsync();

                TempData["message"] = "Facility updated successfully!";
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocationFacilityExists(locationFacility.FacilityId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }

        private void LoadFacilityDropdowns(LocationFacility locationFacility)
        {
            ViewData["BlockID"] = new SelectList(
                _context.LocationBlocks.Where(m => m.IsDeleted == 0).OrderBy(m => m.BlockName),
                "BlockID", "BlockName", locationFacility.BlockId);

            ViewData["DistrictID"] = new SelectList(
                _context.LocationDistricts.Where(m => m.IsDeleted == 0).OrderBy(m => m.District),
                "DistrictID", "District", locationFacility.DistrictId);

            ViewData["StateID"] = new SelectList(
                _context.LocationStates.Where(m => m.IsDeleted == 0).OrderBy(m => m.StateName),
                "StateID", "StateName", locationFacility.StateId);

            ViewData["FacilityTypeID"] = new SelectList(
                _context.LocationFacilityTypes.Where(m => m.IsDeleted == 0).OrderBy(m => m.FacilityType),
                "FacilityTypeID", "FacilityType", locationFacility.FacilityTypeId);

            ViewData["CreatedBy"] = new SelectList(_context.Users, "UserId", "Password", locationFacility.CreatedBy);
            ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserId", "Password", locationFacility.UpdatedBy);
        }



        public JsonResult GetDistrict(int stateid)
        {
            try
            {
                return Json(_context.LocationDistricts.Where(m => m.StateId == stateid && m.IsDeleted==0).OrderBy(p => p.District).ToList());
            }
            catch (Exception ex)
            {
                return Json("0");
            }
        }

        public JsonResult GetBlock(int districtId)
        {
            try
            {
                var blocks = _context.LocationBlocks
                    .Where(m => m.DistrictId == districtId && m.IsDeleted == 0)
                    .OrderBy(p => p.BlockName)
                    .Select(x => new
                    {
                        blockId = x.BlockId,
                        blockName = x.BlockName
                    })
                    .ToList();

                return Json(blocks);
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message });
            }
        }



        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locationFacility = await _context.LocationFacilities
                .Include(l => l.Block)
                
                .Include(l => l.District)
                .Include(l => l.FacilityType)
                .Include(l => l.State)
                
                .FirstOrDefaultAsync(m => m.FacilityId == id);
            if (locationFacility == null)
            {
                return NotFound();
            }

            return View(locationFacility);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var locationFacility = await _context.LocationFacilities.FindAsync(id);
            locationFacility.IsDeleted = 1;
            _context.Update(locationFacility);
            await _context.SaveChangesAsync();

            //---------------------------------Triggers Faclilty ML Insertion--------------------------------------------//
            //var FacilityVL = _context.LocationFacilityMLs.Where(m => m.FacilityID == id).FirstOrDefault();

            //if (FacilityVL != null)
            //{
            //    _context.LocationFacilityMLs.Remove(FacilityVL);
            //    await _context.SaveChangesAsync();
            //}
            //else
            //{

            //}
            return RedirectToAction(nameof(Index));
        }

        private bool LocationFacilityExists(int id)
        {
            return _context.LocationFacilities.Any(e => e.FacilityId == id);
        }
    }
}
