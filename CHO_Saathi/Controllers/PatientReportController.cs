using CHO_Saathi.Common;
using CHO_Saathi.Models;
using CHO_Saathi.ViewComponents;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CHO_Saathi.Controllers
{
    public class PatientReportController : Controller
    {
        private readonly ApplicationDBContext _context;

        public PatientReportController(ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            try
            {
                ViewBag.State = _context.LocationStates
                .Where(d => d.IsDeleted == 0)
                .OrderBy(d => d.StateName)
                .Select(d => new SelectListItem
                {
                    Value = d.StateId.ToString(),
                    Text = d.StateName
                })
                .ToList();

                ViewBag.Year = _context.MstYears
                .OrderBy(d => d.YearName)
                .Select(d => new SelectListItem
                {
                    Value = d.YearId.ToString(),
                    Text = d.YearName
                })
                .ToList();

                ViewBag.Month = _context.MstMonths
                .OrderBy(d => d.MonthId)
                .Select(d => new SelectListItem
                {
                    Value = d.MonthId.ToString(),
                    Text = d.Month
                })
                .ToList();

                ViewBag.Symptoms = _context.CommonSymptomsWebs
                 .Where(d => d.IsDeleted == 0)
                 .OrderBy(d => d.SymptomsName)
                 .Select(d => new SelectListItem
                 {
                     Value = d.SymptomTypeId.ToString(),
                     Text = d.SymptomsName
                 })
                 .ToList();

                return View();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IActionResult getPatientCardCountReport(int StateId = 0, int DistrictId = 0, int BlockId = 0, int FacilityId = 0, int SubfacilityId = 0, int YearId = 0, int MonthId = 0, int SymptomsId = 0)
        {
            try
            {
                
                var param = new SqlParameter[]
                {
                    new SqlParameter("@StateId",StateId),
                    new SqlParameter("@DistrictId",DistrictId),
                    new SqlParameter("@BlockId",BlockId),
                    new SqlParameter("@FacilityId",FacilityId),
                    new SqlParameter("@SubfacilityId",SubfacilityId),
                    new SqlParameter("@Year",YearId),
                    new SqlParameter("@Month",MonthId),
                    new SqlParameter("@SymptomsId",SymptomsId),
                    new SqlParameter("@PageNumber","1"),
                    new SqlParameter("@pageSize","10"),
                };

                DataSet result = CommonController.Procedure_DataSet("USP_Patients_Fetch", param);

                List<PatientInformationViewModel> obj = new List<PatientInformationViewModel>();

                var report = new PatientInformationViewModel
                {
                    patientDetails = CommonController.ConvertDataTable<PatientDetails>(result.Tables[1]),
                    patientGraphData = CommonController.ConvertDataTable<PatientGraphData>(result.Tables[2]),
                    emergencyServiceCounts = CommonController.ConvertDataTable<EmergencyServiceCount>(result.Tables[3]),
                };
                return PartialView("_PVPatientCardCount", report);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult getPatientReport(int pageIndex = 0, int pageSize = 0, int StateId = 0, int DistrictId = 0, int BlockId = 0, int FacilityId = 0, int SubfacilityId = 0, int YearId = 0, int MonthId = 0, int SymptomsId = 0)
        {
            try
            {
                if (pageSize <= 0) pageSize = 10;
                if (pageIndex <= 0) pageIndex = 1;

                var param = new SqlParameter[]
                {
                    new SqlParameter("@StateId",StateId),
                    new SqlParameter("@DistrictId",DistrictId),
                    new SqlParameter("@BlockId",BlockId),
                    new SqlParameter("@FacilityId",FacilityId),
                    new SqlParameter("@SubfacilityId",SubfacilityId),
                    new SqlParameter("@Year",YearId),
                    new SqlParameter("@Month",MonthId),
                    new SqlParameter("@SymptomsId",SymptomsId),
                    new SqlParameter("@PageNumber",pageIndex),
                    new SqlParameter("@pageSize",pageSize),
                };

                DataSet result = CommonController.Procedure_DataSet("USP_Patients_Fetch", param);

                List<PatientInformationViewModel> obj = new List<PatientInformationViewModel>();

                var report = new PatientInformationViewModel
                {
                    patientDetails = CommonController.ConvertDataTable<PatientDetails>(result.Tables[1]),
                    patientGraphData = CommonController.ConvertDataTable<PatientGraphData>(result.Tables[2]),
                    emergencyServiceCounts = CommonController.ConvertDataTable<EmergencyServiceCount>(result.Tables[3]),
                };

                int countUser = Convert.ToInt32(result.Tables[0].Rows[0].ItemArray[0]);
                var pageNo = countUser % pageSize != 0 ? (countUser / pageSize) + 1 : (countUser / pageSize);
                TempData["PageIndex"] = pageIndex;
                TempData["PageSize"] = pageSize;
                TempData["MaxPageIndex"] = pageNo;
                return PartialView("_PVPatientReport", report);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public JsonResult GetDistricts(int stateId)
        {
            var districts = _context.LocationDistricts
                .Where(b => b.StateId == stateId && b.IsDeleted == 0)
                .OrderBy(b => b.District)
                .Select(b => new { b.DistrictId, b.District })
                .ToList();

            return Json(districts);
        }

        // Get Blocks for a District (AJAX)
        [HttpGet]
        public JsonResult GetBlocks(int districtId)
        {
            var blocks = _context.LocationBlocks
                .Where(b => b.DistrictId == districtId && b.IsDeleted == 0)
                .OrderBy(b => b.BlockName)
                .Select(b => new { b.BlockId, b.BlockName })
                .ToList();

            return Json(blocks);
        }

        [HttpGet]
        public JsonResult GetFacility(int blockId)
        {
            var facility = _context.LocationFacilities
                .Where(b => b.BlockId == blockId && b.IsDeleted == 0)
                .OrderBy(b => b.FacilityName)
                .Select(b => new { b.FacilityId, b.FacilityName })
                .ToList();

            return Json(facility);
        }

        [HttpGet]
        public JsonResult GetSubfacility(int facilityId)
        {
            var subFacility = _context.LocationSubFacilities
                .Where(b => b.FacilityId == facilityId && b.IsDeleted == 0)
                .OrderBy(b => b.SubFacility)
                .Select(b => new { b.SubFacilityId, b.SubFacility })
                .ToList();

            return Json(subFacility);
        }

        public ActionResult ExportToExcel(int StateId = 0, int DistrictId = 0, int BlockId = 0, int FacilityId = 0, int SubfacilityId = 0, int YearId = 0, int MonthId = 0, int SymptomsId = 0)
        {
            try
            {
                string filePath = "Patient_Data";
                string ExcelTabName = "Patients";

                var param = new SqlParameter[]
                {
                    new SqlParameter("@StateId", StateId),
                    new SqlParameter("@DistrictId", DistrictId),
                    new SqlParameter("@BlockId", BlockId),
                    new SqlParameter("@FacilityId",FacilityId),
                    new SqlParameter("@SubfacilityId",SubfacilityId),
                    new SqlParameter("@Year",YearId),
                    new SqlParameter("@Month",MonthId),
                    new SqlParameter("@SymptomsId",SymptomsId),
                };

                DataTable dtTable = CommonController.Procedure_Query_ToDataTable(
                    _context, "USP_Patients_Fetch_Excel", CommandType.StoredProcedure, param
                );

                if (dtTable != null && dtTable.Rows.Count > 0)
                {

                    if (dtTable.Columns.Contains("SNo"))
                        dtTable.Columns["SNo"].ColumnName = "S.No";
                    else if (dtTable.Columns.Contains("S_No"))
                        dtTable.Columns["S_No"].ColumnName = "S.No";

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var ws = wb.Worksheets.Add(dtTable, ExcelTabName);

                        ws.Table(0).ShowAutoFilter = false;
                        ws.Table(0).Theme = XLTableTheme.TableStyleLight12;
                        ws.Columns().AdjustToContents();


                        int idCol = dtTable.Columns.IndexOf("sno");
                        if (idCol >= 0)
                            ws.Column(idCol + 1).Hide();

                        using (var stream = new MemoryStream())
                        {
                            wb.SaveAs(stream);
                            stream.Position = 0;

                            string downloadFileName = filePath + "_" +
                                DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss") + ".xlsx";

                            return File(stream.ToArray(),
                                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                                downloadFileName);
                        }
                    }
                }
                else
                {
                    TempData["message"] = "No Record Found..!!";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
                TempData["message"] = "Error while exporting data!";
                return RedirectToAction("Index");
            }
        }



        public ActionResult ExportMedicalServices()
        {
            try
            {
                string filePath = "Medical_Emergency_Data";
                string ExcelTabName = "Medical_Emergency";

                DataTable dtTable = CommonController.Procedure_Query_ToDataTable(
                    _context, "USP_Medical_Emergency_Fetch_Excel", CommandType.StoredProcedure, null
                );

                if (dtTable != null && dtTable.Rows.Count > 0)
                {
                    if (dtTable.Columns.Contains("SNo"))
                        dtTable.Columns["me_id"].ColumnName = "S.No";
                    else if (dtTable.Columns.Contains("S_No"))
                        dtTable.Columns["me_id"].ColumnName = "S.No";

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var ws = wb.Worksheets.Add(dtTable, ExcelTabName);

                        ws.Table(0).ShowAutoFilter = false;
                        ws.Table(0).Theme = XLTableTheme.TableStyleLight12;
                        ws.Columns().AdjustToContents();

                        using (var stream = new MemoryStream())
                        {
                            wb.SaveAs(stream);
                            stream.Position = 0;

                            string downloadFileName = filePath + "_" +
                                DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss") + ".xlsx";

                            return File(stream.ToArray(),
                                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                                downloadFileName);
                        }
                    }
                }
                else
                {
                    TempData["message"] = "No Record Found..!!";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
                TempData["message"] = "Error while exporting data!";
                return RedirectToAction("Index");
            }
        }


        public ActionResult ReferredPatient()
        {
            try
            {
                string filePath = "Referred_Patient_Data";
                string ExcelTabName = "Referred_Patient";

                DataTable dtTable = CommonController.Procedure_Query_ToDataTable(
                    _context, "USP_Referral_Patient_Fetch_Excel", CommandType.StoredProcedure, null
                );

                if (dtTable != null && dtTable.Rows.Count > 0)
                {
                    if (dtTable.Columns.Contains("SNo"))
                        dtTable.Columns["sno"].ColumnName = "S.No";
                    else if (dtTable.Columns.Contains("S_No"))
                        dtTable.Columns["sno"].ColumnName = "S.No";

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var ws = wb.Worksheets.Add(dtTable, ExcelTabName);

                        ws.Table(0).ShowAutoFilter = false;
                        ws.Table(0).Theme = XLTableTheme.TableStyleLight12;
                        ws.Columns().AdjustToContents();

                        using (var stream = new MemoryStream())
                        {
                            wb.SaveAs(stream);
                            stream.Position = 0;

                            string downloadFileName = filePath + "_" +
                                DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss") + ".xlsx";

                            return File(stream.ToArray(),
                                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                                downloadFileName);
                        }
                    }
                }
                else
                {
                    TempData["message"] = "No Record Found..!!";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
                TempData["message"] = "Error while exporting data!";
                return RedirectToAction("Index");
            }
        }

        private bool PatientExists(int id)
        {
            return _context.Patients.Any(e => e.Sno == id);
        }

    }
}
