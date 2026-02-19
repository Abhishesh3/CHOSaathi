using CHO_Saathi.DTO;
using CHO_Saathi.Models;
using DocumentFormat.OpenXml.InkML;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NPOI.POIFS.Properties;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using static NPOI.HSSF.Util.HSSFColor;

namespace CHO_Saathi.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientDataController : Controller
    {
        private readonly ApplicationDBContext _context;

        public PatientDataController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpPost("PatientPWInformation")]
        public async Task<IActionResult> PatientPWInformation([FromBody] PatientFullRequestDto request)
        {
            try
            {
                if (request == null)
                    return BadRequest("Invalid request.");

                Patient? patient = null;
                bool isNewPatient = false;

                // --------------------------------------------------
                // 1️⃣ HANDLE PATIENT (Only if patient section exists)
                // --------------------------------------------------
                if (request.patients != null)
                {
                    patient = await _context.Patients
                        .FirstOrDefaultAsync(p => p.PatientGuid == request.patients.PatientGUID);

                    if (patient == null)
                    {
                        // ➕ INSERT
                        patient = new Patient
                        {
                            PatientId = GeneratePatientId(),
                            PatientGuid = request.patients.PatientGUID,
                            CreatedAt = request.patients.createdAt,
                            CreatedBy = request.patients.createdBy
                        };

                        _context.Patients.Add(patient);
                        isNewPatient = true;
                    }

                    // 🔄 UPDATE (Insert + Update both)
                    patient.MobileId = request.patients.mobileId;
                    patient.FullName = request.patients.fullName;
                    patient.SpouseName = request.patients.spouseName;
                    patient.Gender = request.patients.gender;
                    patient.Dob = DateOnly.FromDateTime(request.patients.dob);
                    patient.YearOfAge = request.patients.yearOfAge;
                    patient.MonthOfAge = request.patients.monthOfAge;
                    patient.WeeksOfAge = request.patients.weeksOfAge;
                    patient.TotalMonths = request.patients.totalMonths;
                    patient.TotalWeeks = request.patients.totalWeeks;
                    patient.AgeType = request.patients.ageType;
                    patient.HeightCm = (double)request.patients.heightCm;
                    patient.WeightKg = (double)request.patients.weightKg;
                    patient.Mobile = request.patients.mobile;
                    patient.VillageId = request.patients.village_id.ToString();
                    patient.VillageName = request.patients.villageName;
                    patient.CenterId = request.patients.centerId.ToString();
                    patient.PatientType = request.patients.patientType;
                    patient.AncRegistered = request.patients.ancRegistered;
                    patient.IsPregnant = request.patients.isPregnant;
                    patient.IsWomanPregnant = request.patients.isWomanPregnant;
                    patient.LmpDate = request.patients.lmp_date;
                    patient.FlowType = request.patients.flowType;
                    patient.Status = request.patients.status;
                    patient.IsActive = request.patients.isActive;

                    await _context.SaveChangesAsync();
                }

                // --------------------------------------------------
                // 2️⃣ VISIT SECTION
                // --------------------------------------------------

                // If patient section not sent, fetch using visit.PatientGUID
                if (patient == null && request.patient_visit != null)
                {
                    patient = await _context.Patients
                        .FirstOrDefaultAsync(p => p.PatientGuid == request.patient_visit.PatientGUID);

                    if (patient == null)
                        return BadRequest("Patient not found. Cannot insert visit without patient.");
                }

                if (request.patient_visit != null)
                {
                    var visit = await _context.PatientVisits.FirstOrDefaultAsync(v =>
                        v.PatientGuid == patient.PatientGuid &&
                        v.VisitNo == request.patient_visit.visit_no);

                    if (visit == null)
                    {
                        visit = new PatientVisit
                        {
                            PatientGuid = request.patient_visit.PatientGUID,
                            PatientId = patient.PatientId
                        };

                        _context.PatientVisits.Add(visit);
                    }

                    visit.MobileId = request.patient_visit.mobileId;
                    visit.VisitNo = request.patient_visit.visit_no;
                    visit.VisitDate = DateOnly.FromDateTime(request.patient_visit.visit_date);
                    //visit.FollowUpDate = DateOnly.FromDateTime(request.patient_visit.followUpDate);
                    visit.FollowUpDate = request.patient_visit.followUpDate.HasValue
    ? DateOnly.FromDateTime(request.patient_visit.followUpDate.Value)
    : null;

                    visit.GaWeeks = request.patient_visit.ga_weeks;
                    visit.AgeInYears = request.patient_visit.age_in_years;
                    visit.AgeInMonths = request.patient_visit.age_in_months;
                    visit.AgeInWeeks = request.patient_visit.age_in_weeks;
                    visit.AgeInDays = request.patient_visit.age_in_days;
                    visit.Symptoms = request.patient_visit.symptoms;
                    visit.DangerSign = request.patient_visit.dangerSign;
                    visit.Referred = request.patient_visit.referred;
                    visit.ReferredLocation = request.patient_visit.referred_location;
                    visit.CurrentStatus = request.patient_visit.currentStatus;
                    visit.TimeStamp = request.patient_visit.timeStamp;
                    visit.TimeStamp = request.patient_visit.timeStamp;
                    visit.SummaryKey = request.patient_visit.SummaryKey;

                    await _context.SaveChangesAsync();
                }

                // --------------------------------------------------
                // 3️⃣ RESULTS (Only if patient exists)
                // --------------------------------------------------
                if (patient != null)
                {
                    await UpsertPwResults(request, patient);
                }

                return Ok(new
                {
                    status = true,
                    message = isNewPatient ? "Patient inserted successfully" : "Patient updated successfully",
                    response = new
                    {
                        status = 1,
                        message = "Success",
                        patientId = patient.PatientId
                    }
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        //[HttpPost("PatientPWInformation")]
        //public async Task<IActionResult> PatientPWInformation([FromBody] PatientFullRequestDto request)
        //{
        //    try
        //    {
        //        // Check Existing Patient (by PatientGUID)
        //        var patient = await _context.Patients.FirstOrDefaultAsync(p => p.PatientGuid == request.patients.PatientGUID);

        //        bool isNewPatient = false;

        //        if (patient == null)
        //        {
        //            // ➕ INSERT
        //            patient = new Patient
        //            {   
        //                PatientId=GeneratePatientId(),
        //                PatientGuid = request.patients.PatientGUID,
        //                CreatedAt = request.patients.createdAt,
        //                CreatedBy = request.patients.createdBy
        //            };

        //            _context.Patients.Add(patient);
        //            isNewPatient = true;
        //        }

        //        // UPDATE (for both insert & update)
        //        patient.MobileId = request.patients.mobileId;
        //        patient.FullName = request.patients.fullName;
        //        patient.SpouseName = request.patients.spouseName;
        //        patient.Gender = request.patients.gender;
        //        patient.Dob = DateOnly.FromDateTime(request.patients.dob);
        //        patient.YearOfAge = request.patients.yearOfAge;
        //        patient.MonthOfAge = request.patients.monthOfAge;
        //        patient.WeeksOfAge = request.patients.weeksOfAge;
        //        patient.TotalMonths = request.patients.totalMonths;
        //        patient.TotalWeeks = request.patients.totalWeeks;
        //        patient.AgeType = request.patients.ageType;
        //        patient.HeightCm = (double)request.patients.heightCm;
        //        patient.WeightKg = (double)request.patients.weightKg;
        //        patient.Mobile = request.patients.mobile;
        //        patient.VillageId = request.patients.village_id.ToString();
        //        patient.VillageName = request.patients.villageName;
        //        patient.CenterId = request.patients.centerId.ToString();
        //        patient.PatientType = request.patients.patientType;
        //        patient.AncRegistered = request.patients.ancRegistered;
        //        patient.IsPregnant = request.patients.isPregnant;
        //        patient.IsWomanPregnant = request.patients.isWomanPregnant;
        //        patient.LmpDate = request.patients.lmp_date;
        //        patient.FlowType = request.patients.flowType;
        //        patient.Status = request.patients.status;
        //        patient.IsActive = request.patients.isActive;

        //        await _context.SaveChangesAsync();

        //        // 2️ VISIT (Upsert by PatientGuid + VisitNo)

        //        var visit = await _context.PatientVisits.FirstOrDefaultAsync(v =>
        //            v.PatientGuid == patient.PatientGuid &&
        //            v.VisitNo == request.patient_visit.visit_no);

        //        if (visit == null)
        //        {
        //            visit = new PatientVisit
        //            {
        //                PatientGuid = request.patient_visit.PatientGUID,
        //                PatientId = patient.PatientId
        //            };
        //            _context.PatientVisits.Add(visit);
        //        }

        //        visit.MobileId = request.patient_visit.mobileId;
        //        visit.VisitNo = request.patient_visit.visit_no;
        //        visit.VisitDate = DateOnly.FromDateTime(request.patient_visit.visit_date);
        //        visit.FollowUpDate = DateOnly.FromDateTime(request.patient_visit.followUpDate);
        //        visit.GaWeeks = request.patient_visit.ga_weeks;
        //        visit.AgeInYears = request.patient_visit.age_in_years;
        //        visit.AgeInMonths = request.patient_visit.age_in_months;
        //        visit.AgeInWeeks = request.patient_visit.age_in_weeks;
        //        visit.AgeInDays = request.patient_visit.age_in_days;
        //        visit.Symptoms = request.patient_visit.symptoms;
        //        visit.DangerSign = request.patient_visit.dangerSign;
        //        visit.Referred = request.patient_visit.referred;
        //        visit.ReferredLocation = request.patient_visit.referred_location;
        //        visit.CurrentStatus = request.patient_visit.currentStatus;
        //        visit.TimeStamp = request.patient_visit.timeStamp;
        //        visit.CreatedAt = request.patient_visit.createdAt;
        //        visit.SummaryKey = request.patient_visit.SummaryKey;
        //        await UpsertPwResults(request, patient);

        //        //await transaction.CommitAsync();

        //        return Ok(new
        //        {
        //            status = true,
        //            message = isNewPatient ? "Patient inserted successfully" : "Patient updated successfully",
        //            response = new
        //            {
        //                status = 1,
        //                message = "Success",
        //                patientId = patient.PatientId
        //            }
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        //await transaction.RollbackAsync();
        //        return StatusCode(500, ex.Message);
        //    }
        //}

        private async Task UpsertPwResults(PatientFullRequestDto request, Patient patient)
        {
            string patientGuid = patient.PatientGuid;
            int visitNo = request.patient_visit.visit_no;

            // ❌ Remove old results
            _context.PwAskForResults.RemoveRange(
                _context.PwAskForResults.Where(x => x.PatientGuid == patientGuid && x.VisitNo == visitNo));

            _context.PwExaminationResults.RemoveRange(
                _context.PwExaminationResults.Where(x => x.PatientGuid == patientGuid && x.VisitNo == visitNo));

            _context.PwPastHistoryResults.RemoveRange(
                _context.PwPastHistoryResults.Where(x => x.PatientGuid == patientGuid && x.VisitNo == visitNo));

            await _context.SaveChangesAsync();

            // ➕ Insert fresh data
            await SavePwResult(request.pw_ask_for_result, patientGuid, "ASK", patient.PatientId);
            await SavePwResult(request.pw_examination_result, patientGuid, "EXAM", patient.PatientId);
            await SavePwResult(request.pw_past_history_result, patientGuid, "PAST", patient.PatientId);
        }
        private async Task SavePwResult(PwResultDto result, string patientGuid, string type, long patientId)
        {
            var questions = JsonConvert.DeserializeObject<List<QuestionAnswerDto>>(result.data);

            var PatGUID = _context.Patients.Where(p => p.MobileId == result.mobileId).FirstOrDefault();

            foreach (var q in questions)
            {
                int? qIdInt = null;
                if (int.TryParse(q.Q_Id, out var parsedQId))
                {
                    qIdInt = parsedQId;
                }

                if (type == "ASK")
                    _context.PwAskForResults.Add(new PwAskForResult
                    {
                        PatientGuid = patientGuid,
                        PatientId = patientId,
                        MobileId = result.mobileId,
                        VisitNo = result.visitNo,
                        VisitDate = DateOnly.FromDateTime(result.visitDate),
                        Data=result.data,
                        QId = qIdInt,
                        Answer = q.Answer
                    });

                if (type == "EXAM")
                    _context.PwExaminationResults.Add(new PwExaminationResult
                    {
                        PatientGuid = patientGuid,
                        PatientId = patientId,
                        MobileId = result.mobileId,
                        VisitNo = result.visitNo,
                        VisitDate = DateOnly.FromDateTime(result.visitDate),
                        Data = result.data,
                        QId = qIdInt,
                        Answer = q.Answer
                    });

                if (type == "PAST")
                    _context.PwPastHistoryResults.Add(new PwPastHistoryResult
                    {
                        PatientGuid = patientGuid,
                        PatientId = patientId,
                        MobileId = result.mobileId,
                        VisitNo = result.visitNo,
                        VisitDate = DateOnly.FromDateTime(result.visitDate),
                        Data = result.data,
                        QId = qIdInt,
                        Answer = q.Answer
                    });
            }

            await _context.SaveChangesAsync();
        }
        public static long GeneratePatientId()
        {
            long ticks = DateTime.UtcNow.Ticks % 100000;
            int random = Random.Shared.Next(100, 1000);

            return long.Parse($"100{ticks:D5}{random}");
        }

        // Get Patient PW Data API
        [HttpPost("GetPatientPWInformation")]
        public async Task<IActionResult> GetPatientPWInformation()
        {
            int userID = Convert.ToInt32(HttpContext.Request.Form["UserId"]);
            // 1️⃣ PATIENTS BY CREATED BY
            var patients = await _context.Patients
                .Where(p => p.CreatedBy == userID)
                .ToListAsync();

            if (!patients.Any())
                return NotFound("Patient not found");

            var patientIds = patients.Select(p => p.PatientId).ToList();

            // 2️⃣ VISITS
            var visits = await _context.PatientVisits
                .Where(v => patientIds.Contains(v.PatientId))
                .ToListAsync();

            // 3️⃣ PW RESULTS
            var askResults = await _context.PwAskForResults
                .Where(x => patientIds.Contains(x.PatientId))
                .ToListAsync();

            var examResults = await _context.PwExaminationResults
                .Where(x => patientIds.Contains(x.PatientId))
                .ToListAsync();

            var pastResults = await _context.PwPastHistoryResults
                .Where(x => patientIds.Contains(x.PatientId))
                .ToListAsync();

            // 4️⃣ BUILD RESPONSE
            var response = new
            {
                patients = patients.Select(p => new
                {
                    PatientGUID = p.PatientGuid,
                    patientId = p.PatientId,
                    mobileId = p.MobileId,
                    centerId = p.CenterId,
                    createdAt = p.CreatedAt?.ToString("yyyy-MM-dd"),
                    createdBy = p.CreatedBy,
                    dob = p.Dob.ToString("yyyy-MM-dd"),
                    flowType = p.FlowType,
                    fullName = p.FullName,
                    gender = p.Gender,
                    healthWorkerId = p.HealthWorkerId,
                    heightCm = p.HeightCm,
                    isPregnant = p.IsPregnant,
                    mobile = p.Mobile,
                    abhaId = p.AbhaId,
                    patientType = p.PatientType,
                    monthOfAge = p.MonthOfAge,
                    spouseName = p.SpouseName,
                    status = p.Status,
                    villageName = p.VillageName,
                    village_id = p.VillageId,
                    ageType = p.AgeType,
                    weeksOfAge = p.WeeksOfAge,
                    weightKg = p.WeightKg,
                    yearOfAge = p.YearOfAge,
                    followUpDate = p.FollowUpDate,
                    totalWeeks = p.TotalWeeks,
                    totalMonths = p.TotalMonths,
                    rchId = p.RchId,
                    isActive = p.IsActive,
                    deathDate = p.DeathDate,
                    caseCloseDate = p.CaseCloseDate,
                    lmpDate = p.LmpDate,
                    eddDate = p.EddDate,
                    ancRegistered = p.AncRegistered,
                    isWomanPregnant = p.IsWomanPregnant,
                }),

                patient_visit = visits.Select(v => new
                {
                    v.PatientGuid,
                    v.PatientId,
                    v.MobileId,
                    v.TimeStamp,
                    v.VisitNo,
                    v.AgeInYears,
                    v.AgeInMonths,
                    v.AgeInWeeks,
                    v.AgeInDays,
                    v.Referred,
                    v.GaWeeks,
                    v.ReferredLocation,
                    followUpDate = v.FollowUpDate?.ToString("yyyy-MM-dd"),
                    v.DischargeDate,
                    v.DeathDate,
                    visit_date = v.VisitDate?.ToString("yyyy-MM-dd"),
                    v.CreatedBy,
                    v.DangerSign,
                    v.Symptoms,
                    v.OtherSymptom,
                    v.CurrentStatus,
                    v.Temperature,
                }),

                pw_ask_for_result = BuildPwResultList(askResults),
                pw_examination_result = BuildPwResultList(examResults),
                pw_past_history_result = BuildPwResultList(pastResults)
            };

            return Ok(response);
        }


        private List<object> BuildPwResultList<T>(List<T> results) where T : class
        {
            if (results == null || results.Count == 0)
                return new List<object>();

            return results.Select(r =>
            {
                dynamic x = r;
                return new
                {
                    patientId = x.PatientId,
                    PatientGUID = x.PatientGuid,
                    mobileId = x.MobileId,
                    visitDate = x.VisitDate?.ToString("yyyy-MM-dd"),
                    visitNo = x.VisitNo,
                    data = x.Data,
                };
            }).ToList<object>();
        }

    }

}

