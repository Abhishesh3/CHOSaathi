using CHO_Saathi.Models;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace RCH_UserManagement.Controllers
{
    public class LocationSubFacilitiesController : Controller
    {

        private readonly ApplicationDBContext _context;

        public LocationSubFacilitiesController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: LocationSubFacilities
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {
                int pageSize = 10;
                int pageIndex = 1;

                //ViewData["StateID"] = new SelectList(_context.LocationStates.Where(m => m.IsDeleted == 0).OrderBy(m => m.StateName), "StateID", "StateName");
                ViewBag.StateID = new SelectList(_context.LocationStates.Where(x => x.IsDeleted == 0).OrderBy(x => x.StateName).ToList(), "StateId", "StateName");

                ViewData["FacilityTypeId"] = new SelectList(_context.LocationFacilityTypes.Where(m => m.IsDeleted == 0).OrderBy(m => m.FacilityType), "FacilityTypeId", "FacilityType");

                var applicationDBContext = _context.LocationSubFacilities.Where(m => m.IsDeleted == 0).OrderBy(m => m.State.StateName).ThenBy(m => m.District.District).ThenBy(m => m.Block.BlockName).Include(l => l.Block).Include(l => l.District).Include(l => l.Facility).Include(l => l.FacilityType).Include(l => l.State).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                var countUser = _context.LocationSubFacilities.Where(m => m.IsDeleted == 0).Count();
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

        public IActionResult getServerdt(int pageSize, int pageIndex, string State, string District, string Block, string FacilityType, string Facility, string selectedValue, string txtSearch)
        {
            if (!string.IsNullOrEmpty(State) && !string.IsNullOrEmpty(District) && !string.IsNullOrEmpty(Block) && !string.IsNullOrEmpty(FacilityType) && !string.IsNullOrEmpty(Facility))
            {
                if (txtSearch == null)
                {

                    if (State == "0" && District == "0" && Block == "0" && FacilityType == "0" && Facility == "0")
                    {
                        var applicationDBContext = _context.LocationSubFacilities.Where(m => m.IsDeleted == 0).OrderBy(m => m.State.StateName).ThenBy(m => m.District.District).ThenBy(m => m.Block.BlockName).Include(l => l.Block).Include(l => l.District).Include(l => l.Facility).Include(l => l.FacilityType).Include(l => l.State).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                        var countUser = _context.LocationSubFacilities.Where(m => m.IsDeleted == 0).Count();
                        var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                        TempData["pageIndex"] = pageIndex;
                        TempData["PageSize"] = pageSize;
                        TempData["MaxPageIndex"] = pageNo;
                        ViewBag.SubFacilityView = applicationDBContext;
                        return PartialView("_PVSubFaclities", applicationDBContext.ToList());
                    }
                    else if (State == "0" && District == "0" && Block == "0" && FacilityType != "0" && Facility == "0")
                    {
                        var applicationDBContext = _context.LocationSubFacilities.Where(m => m.IsDeleted == 0 && m.FacilityTypeId == Convert.ToInt32(FacilityType)).OrderBy(m => m.State.StateName).ThenBy(m => m.District.District).ThenBy(m => m.Block.BlockName).Include(l => l.Block).Include(l => l.District).Include(l => l.Facility).Include(l => l.FacilityType).Include(l => l.State).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                        var countUser = _context.LocationSubFacilities.Where(m => m.IsDeleted == 0 && m.FacilityTypeId == Convert.ToInt32(FacilityType)).Count();
                        var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                        TempData["pageIndex"] = pageIndex;
                        TempData["PageSize"] = pageSize;
                        TempData["MaxPageIndex"] = pageNo;
                        ViewBag.SubFacilityView = applicationDBContext;
                        return PartialView("_PVSubFaclities", applicationDBContext.ToList());
                    }
                    else if (State != "0" && District == "0" && Block == "0" && FacilityType == "0" && Facility == "0")
                    {
                        var applicationDBContext = _context.LocationSubFacilities.Where(m => m.StateId == Convert.ToInt32(State) && m.IsDeleted == 0).OrderBy(m => m.State.StateName).ThenBy(m => m.District.District).ThenBy(m => m.Block.BlockName).Include(l => l.Block).Include(l => l.District).Include(l => l.Facility).Include(l => l.FacilityType).Include(l => l.State).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                        var countUser = _context.LocationSubFacilities.Where(m => m.StateId == Convert.ToInt32(State) && m.IsDeleted == 0).Count();
                        var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                        TempData["pageIndex"] = pageIndex;
                        TempData["PageSize"] = pageSize;
                        TempData["MaxPageIndex"] = pageNo;
                        ViewBag.SubFacilityView = applicationDBContext;
                        return PartialView("_PVSubFaclities", applicationDBContext.ToList());
                    }
                    else if (State != "0" && District != "0" && Block == "0" && FacilityType == "0" && Facility == "0")
                    {

                        var applicationDBContext = _context.LocationSubFacilities.Where(m => m.StateId == Convert.ToInt32(State) && m.DistrictId == Convert.ToInt32(District) && m.IsDeleted == 0).OrderBy(m => m.State.StateName).ThenBy(m => m.District.District).ThenBy(m => m.Block.BlockName).Include(l => l.Block).Include(l => l.District).Include(l => l.Facility).Include(l => l.FacilityType).Include(l => l.State).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                        var countUser = _context.LocationSubFacilities.Where(m => m.StateId == Convert.ToInt32(State) && m.DistrictId == Convert.ToInt32(District) && m.IsDeleted == 0).Count();
                        var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                        TempData["pageIndex"] = pageIndex;
                        TempData["PageSize"] = pageSize;
                        TempData["MaxPageIndex"] = pageNo;
                        ViewBag.SubFacilityView = applicationDBContext;
                        return PartialView("_PVSubFaclities", applicationDBContext.ToList());
                    }
                    else if (State != "0" && District != "0" && Block != "0" && FacilityType == "0" && Facility == "0")
                    {
                        var applicationDBContext = _context.LocationSubFacilities.Where(m => m.StateId == Convert.ToInt32(State) && m.DistrictId == Convert.ToInt32(District) && m.BlockId == Convert.ToInt32(Block) && m.IsDeleted == 0).OrderBy(m => m.State.StateName).ThenBy(m => m.District.District).ThenBy(m => m.Block.BlockName).Include(l => l.Block).Include(l => l.District).Include(l => l.Facility).Include(l => l.FacilityType).Include(l => l.State).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                        var countUser = _context.LocationSubFacilities.Where(m => m.StateId == Convert.ToInt32(State) && m.DistrictId == Convert.ToInt32(District) && m.BlockId == Convert.ToInt32(Block) && m.IsDeleted == 0).Count();
                        var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                        TempData["pageIndex"] = pageIndex;
                        TempData["PageSize"] = pageSize;
                        TempData["MaxPageIndex"] = pageNo;
                        ViewBag.SubFacilityView = applicationDBContext;
                        return PartialView("_PVSubFaclities", applicationDBContext.ToList());
                    }
                    else if (State != "0" && District != "0" && Block != "0" && Facility == "0" && FacilityType != "0")
                    {
                        var applicationDBContext = _context.LocationSubFacilities.Where(m => m.StateId == Convert.ToInt32(State) && m.DistrictId == Convert.ToInt32(District) && m.BlockId == Convert.ToInt32(Block) && m.FacilityTypeId == Convert.ToInt32(FacilityType) && m.IsDeleted == 0).OrderBy(m => m.State.StateName).ThenBy(m => m.District.District).ThenBy(m => m.Block.BlockName).Include(l => l.Block).Include(l => l.District).Include(l => l.Facility).Include(l => l.FacilityType).Include(l => l.State).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                        var countUser = _context.LocationSubFacilities.Where(m => m.StateId == Convert.ToInt32(State) && m.DistrictId == Convert.ToInt32(District) && m.BlockId == Convert.ToInt32(Block) && m.FacilityTypeId == Convert.ToInt32(FacilityType) && m.IsDeleted == 0).Count();
                        var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                        TempData["pageIndex"] = pageIndex;
                        TempData["PageSize"] = pageSize;
                        TempData["MaxPageIndex"] = pageNo;
                        ViewBag.SubFacilityView = applicationDBContext;
                        return PartialView("_PVSubFaclities", applicationDBContext.ToList());
                    }
                    else if (State != "0" && District != "0" && Block != "0" && Facility != "0" && FacilityType == "0")
                    {
                        var applicationDBContext = _context.LocationSubFacilities.Where(m => m.StateId == Convert.ToInt32(State) && m.DistrictId == Convert.ToInt32(District) && m.BlockId == Convert.ToInt32(Block) && m.FacilityId == Convert.ToInt32(Facility) && m.IsDeleted == 0).OrderBy(m => m.State.StateName).ThenBy(m => m.District.District).ThenBy(m => m.Block.BlockName).Include(l => l.Block).Include(l => l.District).Include(l => l.Facility).Include(l => l.FacilityType).Include(l => l.State).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                        var countUser = _context.LocationSubFacilities.Where(m => m.StateId == Convert.ToInt32(State) && m.DistrictId == Convert.ToInt32(District) && m.BlockId == Convert.ToInt32(Block) && m.FacilityId == Convert.ToInt32(Facility) && m.IsDeleted == 0).Count();
                        var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                        TempData["pageIndex"] = pageIndex;
                        TempData["PageSize"] = pageSize;
                        TempData["MaxPageIndex"] = pageNo;
                        ViewBag.SubFacilityView = applicationDBContext;
                        return PartialView("_PVSubFaclities", applicationDBContext.ToList());
                    }
                    else if (State != "0" && District != "0" && Block != "0" && Facility != "0" && FacilityType != "0")
                    {
                        var applicationDBContext = _context.LocationSubFacilities.Where(m => m.StateId == Convert.ToInt32(State) && m.DistrictId == Convert.ToInt32(District) && m.BlockId == Convert.ToInt32(Block) && m.FacilityId == Convert.ToInt32(Facility) && m.FacilityTypeId == Convert.ToInt32(FacilityType) && m.IsDeleted == 0).OrderBy(m => m.State.StateName).ThenBy(m => m.District.District).ThenBy(m => m.Block.BlockName).Include(l => l.Block).Include(l => l.District).Include(l => l.Facility).Include(l => l.FacilityType).Include(l => l.State).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                        var countUser = _context.LocationSubFacilities.Where(m => m.StateId == Convert.ToInt32(State) && m.DistrictId == Convert.ToInt32(District) && m.BlockId == Convert.ToInt32(Block) && m.FacilityId == Convert.ToInt32(Facility) && m.FacilityTypeId == Convert.ToInt32(FacilityType) && m.IsDeleted == 0).Count();
                        var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                        TempData["pageIndex"] = pageIndex;
                        TempData["PageSize"] = pageSize;
                        TempData["MaxPageIndex"] = pageNo;
                        ViewBag.SubFacilityView = applicationDBContext;
                        return PartialView("_PVSubFaclities", applicationDBContext.ToList());
                    }
                    else
                    {
                        var applicationDBContext = _context.LocationSubFacilities.Where(m => m.IsDeleted == 0).OrderBy(m => m.State.StateName).ThenBy(m => m.District.District).ThenBy(m => m.Block.BlockName).Include(l => l.Block).Include(l => l.District).Include(l => l.Facility).Include(l => l.FacilityType).Include(l => l.State).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                        var countUser = _context.LocationSubFacilities.Where(m => m.IsDeleted == 0).Count();
                        var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                        TempData["pageIndex"] = pageIndex;
                        TempData["PageSize"] = pageSize;
                        TempData["MaxPageIndex"] = pageNo;
                        ViewBag.SubFacilityView = applicationDBContext;
                        return PartialView("_PVSubFaclities", applicationDBContext.ToList());
                    }

                }
                else
                {
                    var query = _context.LocationSubFacilities
                                .Where(m => m.IsDeleted == 0 && m.SubFacility.Contains(txtSearch))
                                .OrderBy(m => m.State.StateName).ThenBy(m => m.District.District).ThenBy(m => m.Block.BlockName)
                                .Include(l => l.Block)
                                .Include(l => l.District)
                                .Include(l => l.Facility)
                                .Include(l => l.FacilityType)
                                .Include(l => l.State)
                                .AsNoTracking();

                    var totalRecords = query.Count();

                    var pageNo = totalRecords / pageSize + (totalRecords % pageSize > 0 ? 1 : 0);

                    var paginatedData = query.Skip(pageSize * (pageIndex - 1))
                                             .Take(pageSize)
                                             .ToList();

                    TempData["pageIndex"] = pageIndex;
                    TempData["PageSize"] = pageSize;
                    TempData["MaxPageIndex"] = pageNo;
                    ViewBag.SubFacilityView = paginatedData;

                    return PartialView("/Views/LocationSubFacilities/_PVSubFaclities.cshtml", paginatedData);

                }
            }
            // return View();
            return PartialView("/Views/LocationSubFacilities/_PVSubFaclities.cshtml");
        }


        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {
                ViewBag.StateID = new SelectList(_context.LocationStates.Where(x => x.IsDeleted == 0).OrderBy(x => x.StateName).ToList(), "StateId", "StateName");

                ViewData["CreatedBy"] = new SelectList(_context.Users, "UserId", "Password");

                ViewData["FacilityTypeId"] = new SelectList(_context.LocationFacilityTypes.Where(m => m.IsDeleted == 0).OrderBy(m => m.FacilityType), "FacilityTypeId", "FacilityType");

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
        public async Task<IActionResult> Create(LocationSubFacility locationSubFacility)
        {
            // 1️⃣ Validate required fields
            if (locationSubFacility.StateId == 0)
            {
                TempData["message"] = "Please Select State..!!";
            }
            else if (locationSubFacility.DistrictId == 0)
            {
                TempData["message"] = "Please Select District..!!";
            }
            else if (locationSubFacility.BlockId == 0)
            {
                TempData["message"] = "Please Select Block..!!";
            }
            else if (locationSubFacility.FacilityTypeId == 0)
            {
                TempData["message"] = "Please Select Facility Type..!!";
            }
            else if (locationSubFacility.FacilityId == 0)
            {
                TempData["message"] = "Please Select Facility..!!";
            }
            else
            {
                // 2️⃣ All validations passed, insert record
                locationSubFacility.CreatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
                locationSubFacility.CreatedOn = DateTime.Now;
                locationSubFacility.IsDeleted = 0;

                _context.Add(locationSubFacility);
                await _context.SaveChangesAsync();

                // Success, redirect to Index
                return RedirectToAction(nameof(Index));
            }

            // 3️⃣ Rebind dropdowns for returning View
            PopulateDropdowns(locationSubFacility);

            // 4️⃣ Return view with the entered model
            return View(locationSubFacility);
        }

        // Helper method to populate all dropdowns safely
        private void PopulateDropdowns(LocationSubFacility model)
        {
            ViewBag.StateList = _context.LocationStates
                .Where(x => x.IsDeleted == 0)
                .OrderBy(x => x.StateName)
                .Select(x => new SelectListItem { Value = x.StateId.ToString(), Text = x.StateName })
                .ToList();

            ViewBag.DistrictList = _context.LocationDistricts
                .Where(x => x.IsDeleted == 0 && x.StateId == model.StateId)
                .OrderBy(x => x.District)
                .Select(x => new SelectListItem { Value = x.DistrictId.ToString(), Text = x.District })
                .ToList() ?? new List<SelectListItem>();

            ViewBag.BlockList = _context.LocationBlocks
                .Where(x => x.IsDeleted == 0 && x.DistrictId == model.DistrictId)
                .OrderBy(x => x.BlockName)
                .Select(x => new SelectListItem { Value = x.BlockId.ToString(), Text = x.BlockName })
                .ToList() ?? new List<SelectListItem>();

            ViewBag.FacilityTypeList = _context.LocationFacilityTypes
                .Where(x => x.IsDeleted == 0)
                .OrderBy(x => x.FacilityType)
                .Select(x => new SelectListItem { Value = x.FacilityTypeId.ToString(), Text = x.FacilityType })
                .ToList();

            ViewBag.FacilityList = _context.LocationFacilities
                .Where(x => x.IsDeleted == 0 && x.BlockId == model.BlockId)
                .OrderBy(x => x.FacilityName)
                .Select(x => new SelectListItem { Value = x.FacilityId.ToString(), Text = x.FacilityName })
                .ToList() ?? new List<SelectListItem>();

            ViewData["CreatedBy"] = new SelectList(_context.Users, "UserID", "UserName", model.CreatedBy);
            ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserID", "UserName", model.UpdatedBy);
        }




        public async Task<IActionResult> Edit(int? id)
        {
            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {
                var locationSubFacility = await _context.LocationSubFacilities.FindAsync(id);
                if (locationSubFacility == null)
                {
                    return NotFound();
                }

                ViewBag.StateID = new SelectList(_context.LocationStates.Where(x => x.IsDeleted == 0).OrderBy(x => x.StateName).ToList(), "StateId", "StateName");

                ViewBag.DistrictID = new SelectList(_context.LocationDistricts.Where(x => x.IsDeleted == 0).OrderBy(x => x.District).ToList(), "DistrictId", "District");

                ViewBag.BlockID = new SelectList(_context.LocationBlocks.Where(x => x.IsDeleted == 0).OrderBy(x => x.BlockName).ToList(), "BlockId", "BlockName");


                ViewData["CreatedBy"] = new SelectList(_context.Users, "UserId", "Password");

                ViewData["FacilityTypeId"] = new SelectList(_context.LocationFacilityTypes.Where(m => m.IsDeleted == 0).OrderBy(m => m.FacilityType), "FacilityTypeId", "FacilityType");

                ViewBag.FacilityID = new SelectList(_context.LocationFacilities.Where(m => m.IsDeleted == 0).OrderBy(m => m.FacilityName), "FacilityId", "FacilityName");

                ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserId", "Password");
                return View(locationSubFacility);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(LocationSubFacility locationSubFacility)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            if (locationSubFacility.StateId == 0)
        //            {
        //                TempData["message"] = "Please Select State..!!";
        //            }
        //            else if (locationSubFacility.DistrictId == 0)
        //            {
        //                TempData["message"] = "Please Select District..!!";
        //            }
        //            else if (locationSubFacility.BlockId == 0)
        //            {
        //                TempData["message"] = "Please Select Block..!!";
        //            }
        //            else if (locationSubFacility.FacilityTypeId == 0)
        //            {
        //                TempData["message"] = "Please Select Facility Type..!!";
        //            }
        //            else
        //            {
        //                var existingSubFacility = await _context.LocationSubFacilities.FindAsync(id);
        //                if (existingSubFacility != null)
        //                {
        //                    existingSubFacility.FacilityTypeId = locationSubFacility.FacilityTypeId;
        //                    existingSubFacility.SubFacility = locationSubFacility.SubFacility;
        //                    existingSubFacility.SubFacilityCode = locationSubFacility.SubFacilityCode;
        //                    existingSubFacility.FacilityId = locationSubFacility.FacilityId;
        //                    existingSubFacility.BlockId = locationSubFacility.BlockId;
        //                    existingSubFacility.DistrictId = locationSubFacility.DistrictId;
        //                    existingSubFacility.StateId = locationSubFacility.StateId;
        //                    existingSubFacility.IsDeleted = locationSubFacility.IsDeleted;
        //                    existingSubFacility.UpdatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
        //                    existingSubFacility.UpdatedOn = DateTime.Now;

        //                    _context.Update(existingSubFacility);
        //                    await _context.SaveChangesAsync();


        //                    return RedirectToAction(nameof(Index));

        //                }
        //                else
        //                {
        //                    return NotFound();
        //                }
        //            }
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!LocationSubFacilityExists(locationSubFacility.SubFacilityId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //    }

        //    ViewData["BlockID"] = new SelectList(_context.LocationBlocks.Where(m => m.IsDeleted == 0), "BlockID", "BlockName", locationSubFacility.BlockId);
        //    ViewData["CreatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationSubFacility.CreatedBy);
        //    ViewData["DistrictID"] = new SelectList(_context.LocationDistricts.Where(m => m.IsDeleted == 0), "DistrictID", "District", locationSubFacility.DistrictId);
        //    ViewData["FacilityID"] = new SelectList(_context.LocationFacilities.Where(m => m.IsDeleted == 0), "FacilityID", "FacilityName", locationSubFacility.FacilityId);
        //    ViewData["FacilityTypeID"] = new SelectList(_context.LocationFacilityTypes.Where(m => m.IsDeleted == 0), "FacilityTypeID", "FacilityType", locationSubFacility.FacilityTypeId);
        //    ViewData["StateID"] = new SelectList(_context.LocationStates.Where(m => m.IsDeleted == 0), "StateID", "StateName", locationSubFacility.StateId);
        //    ViewData["UpdatedBy"] = new SelectList(_context.Users, "UserID", "Password", locationSubFacility.UpdatedBy);

        //    return View(locationSubFacility);
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(LocationSubFacility locationSubFacility)
        {
            // Validate State
            if (locationSubFacility.StateId == 0)
            {
                TempData["message"] = "Please Select State..!!";
                LoadSubFacilityDropdowns(locationSubFacility);
                return View(locationSubFacility);
            }

            // Validate District
            if (locationSubFacility.DistrictId == 0)
            {
                TempData["message"] = "Please Select District..!!";
                LoadSubFacilityDropdowns(locationSubFacility);
                return View(locationSubFacility);
            }

            // Validate Block
            if (locationSubFacility.BlockId == 0)
            {
                TempData["message"] = "Please Select Block..!!";
                LoadSubFacilityDropdowns(locationSubFacility);
                return View(locationSubFacility);
            }

            // Validate Facility Type
            if (locationSubFacility.FacilityTypeId == 0)
            {
                TempData["message"] = "Please Select Facility Type..!!";
                LoadSubFacilityDropdowns(locationSubFacility);
                return View(locationSubFacility);
            }

            try
            {
                // Fetch existing Sub Facility
                var existingSubFacility = await _context.LocationSubFacilities
                    .FirstOrDefaultAsync(m => m.SubFacilityId == locationSubFacility.SubFacilityId);

                if (existingSubFacility == null)
                {
                    return NotFound();
                }

                // Update Sub Facility master
                existingSubFacility.FacilityTypeId = locationSubFacility.FacilityTypeId;
                existingSubFacility.SubFacility = locationSubFacility.SubFacility;
                existingSubFacility.SubFacilityCode = locationSubFacility.SubFacilityCode;
                existingSubFacility.FacilityId = locationSubFacility.FacilityId;
                existingSubFacility.StateId = locationSubFacility.StateId;
                existingSubFacility.DistrictId = locationSubFacility.DistrictId;
                existingSubFacility.BlockId = locationSubFacility.BlockId;
                existingSubFacility.IsDeleted = locationSubFacility.IsDeleted;
                existingSubFacility.UpdatedBy = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
                existingSubFacility.UpdatedOn = DateTime.Now;

                _context.Update(existingSubFacility);
                await _context.SaveChangesAsync();

                TempData["message"] = "Sub Facility updated successfully!";
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocationSubFacilityExists(locationSubFacility.SubFacilityId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }

        private void LoadSubFacilityDropdowns(LocationSubFacility model)
        {
            ViewData["StateID"] = new SelectList(
                _context.LocationStates.Where(m => m.IsDeleted == 0),
                "StateID", "StateName", model.StateId);

            ViewData["DistrictID"] = new SelectList(
                _context.LocationDistricts.Where(m => m.IsDeleted == 0),
                "DistrictID", "District", model.DistrictId);

            ViewData["BlockID"] = new SelectList(
                _context.LocationBlocks.Where(m => m.IsDeleted == 0),
                "BlockID", "BlockName", model.BlockId);

            ViewData["FacilityTypeID"] = new SelectList(
                _context.LocationFacilityTypes.Where(m => m.IsDeleted == 0),
                "FacilityTypeID", "FacilityType", model.FacilityTypeId);

            ViewData["FacilityID"] = new SelectList(
                _context.LocationFacilities.Where(m => m.IsDeleted == 0),
                "FacilityID", "FacilityName", model.FacilityId);
        }



        public JsonResult GetDistrict(int stateid)
        {
            try
            {
                var districts = _context.LocationDistricts
                    .Where(m => m.StateId == stateid && m.IsDeleted == 0)
                    .OrderBy(p => p.District)
                    .Select(d => new
                    {
                        districtId = d.DistrictId,  // lowercase to match JS
                        district = d.District
                    })
                    .ToList();

                return Json(districts);
            }
            catch (Exception ex)
            {
                return Json(new List<object>());
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


        public JsonResult GetFacility(int blockId)
        {
            try
            {
                var facilities = _context.LocationFacilities
                    .Where(m => m.BlockId == blockId && m.IsDeleted == 0)
                    .OrderBy(p => p.FacilityName)
                    .Select(f => new { facilityID = f.FacilityId, facilityName = f.FacilityName })
                    .ToList();

                return Json(facilities);
            }
            catch (Exception ex)
            {
                return Json("0");
            }
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetString("UserId") != null || HttpContext.Session.GetString("UserId") != "" || Convert.ToInt32(HttpContext.Session.GetString("UserId")) != 0)
            {

                var locationSubFacility = await _context.LocationSubFacilities
                        .Include(l => l.Block)

                        .Include(l => l.District)
                        .Include(l => l.Facility)
                        .Include(l => l.FacilityType)
                        .Include(l => l.State)

                        .FirstOrDefaultAsync(m => m.SubFacilityId == id);
                if (locationSubFacility == null)
                {
                    return NotFound();
                }

                return View(locationSubFacility);

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
            var locationSubFacility = await _context.LocationSubFacilities.FindAsync(id);
            locationSubFacility.IsDeleted = 1;
            _context.Update(locationSubFacility);
            await _context.SaveChangesAsync();

            //---------------------------------Triggers locationSubFaclities ML Delete--------------------------------------------//

           
            return RedirectToAction(nameof(Index));
        }

        private bool LocationSubFacilityExists(int id)
        {
            return _context.LocationSubFacilities.Any(e => e.SubFacilityId == id);
        }
    }
}
