using CHO_Saathi.DTO;
using CHO_Saathi.Models;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NPOI.POIFS.Properties;
using System.Linq;
using System.Reflection;
using static CHO_Saathi.Controllers.ANMController;

namespace CHO_Saathi.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientCmpDataController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public PatientCmpDataController(ApplicationDBContext context)
        {
            _context = context;
        }



        [HttpPost("PatientCMPInformation")]
        public async Task<IActionResult> PatientCMPInformation([FromBody] PatientCmpRequestDto request)
        {
            if (request == null)
                return BadRequest("Invalid request.");

            // 🔹 Extract PatientGUID safely
            string patientGuid =
                request.patients?.PatientGUID ??
                request.cmp_patient_visit?.PatientGUID ??
                request.cmp_ask_for_result?.PatientGUID ??
                request.cmp_examination_result?.PatientGUID ??
                request.cmp_past_history_result?.PatientGUID;

            if (string.IsNullOrWhiteSpace(patientGuid))
                return BadRequest("PatientGUID is required.");

            var strategy = _context.Database.CreateExecutionStrategy();

            return await strategy.ExecuteAsync<IActionResult>(async () =>
            {
                using var transaction = await _context.Database.BeginTransactionAsync();

                try
                {
                    bool isNewPatient = false;

                    // =====================================================
                    // 1️⃣ CHECK EXISTING PATIENT
                    // =====================================================
                    var patient = await _context.Patients
                        .FirstOrDefaultAsync(p => p.PatientGuid == patientGuid);

                    // =====================================================
                    // 2️⃣ INSERT PATIENT (IF NOT EXISTS)
                    // =====================================================
                    if (patient == null)
                    {
                        if (request.patients == null)
                            return BadRequest("Patient data required for new patient.");

                        if (string.IsNullOrWhiteSpace(request.patients.mobile))
                            return BadRequest("Mobile number is required.");

                        patient = new Patient
                        {
                            PatientId = GeneratePatientId(),
                            PatientGuid = patientGuid,
                            CreatedAt = request.patients.createdAt,
                            CreatedBy = request.patients.createdBy,

                            // Required DB fields
                            Mobile = request.patients.mobile,
                            MobileId = request.patients.mobileId,
                            FullName = request.patients.fullName,
                            Gender = request.patients.gender
                        };

                        _context.Patients.Add(patient);
                        isNewPatient = true;
                    }

                    // =====================================================
                    // 3️⃣ UPDATE PATIENT (ONLY IF JSON SENT)
                    // =====================================================
                    if (request.patients != null)
                    {
                        if (!string.IsNullOrWhiteSpace(request.patients.mobile))
                            patient.Mobile = request.patients.mobile;

                        patient.MobileId = request.patients.mobileId;
                        patient.FullName = request.patients.fullName;
                        patient.SpouseName = request.patients.spouseName;
                        patient.Gender = request.patients.gender;

                        //if (request.patients.dob != default)
                        //    patient.Dob = DateOnly.FromDateTime((DateTime)request.patients.dob);

                        if (request.patients.dob.HasValue &&
                            request.patients.dob.Value.Year >= 1753)
                        {
                            patient.Dob = DateOnly.FromDateTime(request.patients.dob.Value);
                        }


                        patient.YearOfAge = request.patients.yearOfAge;
                        patient.MonthOfAge = request.patients.monthOfAge;
                        patient.WeeksOfAge = request.patients.weeksOfAge;
                        patient.TotalMonths = request.patients.totalMonths;
                        patient.TotalWeeks = request.patients.totalWeeks;
                        patient.AgeType = request.patients.ageType;

                        patient.HeightCm = (double)request.patients.heightCm;
                        patient.WeightKg = (double)request.patients.weightKg;

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
                    }

                    await _context.SaveChangesAsync();

                    // =====================================================
                    // 4️⃣ VISIT UPSERT
                    // =====================================================
                    if (request.cmp_patient_visit != null)
                    {
                        var visit = await _context.CmpPatientVisits
                            .FirstOrDefaultAsync(v =>
                                v.PatientGuid == patientGuid &&
                                v.VisitNo == request.cmp_patient_visit.VisitNo);

                        if (visit == null)
                        {
                            visit = new CmpPatientVisit
                            {
                                PatientGuid = patientGuid,
                                PatientId = patient.PatientId
                            };

                            _context.CmpPatientVisits.Add(visit);
                        }

                        visit.MobileId = request.cmp_patient_visit.MobileId;
                        visit.VisitNo = request.cmp_patient_visit.VisitNo;
                        //visit.VisitDate = request.cmp_patient_visit.VisitDate;
                        //visit.FollowUpDate = request.cmp_patient_visit.FollowUpDate;

                        if (request.cmp_patient_visit.VisitDate.HasValue &&
                            request.cmp_patient_visit.VisitDate.Value.Year >= 1753)
                        {
                            visit.VisitDate = request.cmp_patient_visit.VisitDate.Value;
                        }

                        if (request.cmp_patient_visit.FollowUpDate.HasValue &&
                            request.cmp_patient_visit.FollowUpDate.Value.Year >= 1753)
                        {
                            visit.FollowUpDate = request.cmp_patient_visit.FollowUpDate.Value;
                        }
                        else
                        {
                            visit.FollowUpDate = null;
                        }


                        visit.AgeInYears = request.cmp_patient_visit.AgeInYears;
                        visit.AgeInMonths = request.cmp_patient_visit.AgeInMonths;
                        visit.AgeInWeeks = request.cmp_patient_visit.AgeInWeeks;
                        visit.AgeInDays = request.cmp_patient_visit.AgeInDays;
                        visit.Symptoms = request.cmp_patient_visit.Symptoms;
                        visit.DangerSign = request.cmp_patient_visit.DangerSign;
                        visit.Referred = request.cmp_patient_visit.Referred;
                        visit.ReferredLocation = request.cmp_patient_visit.ReferredLocation;
                        visit.CurrentStatus = request.cmp_patient_visit.CurrentStatus;
                        visit.CreatedAt = request.cmp_patient_visit.CreatedAt;
                        visit.CreatedBy = request.cmp_patient_visit.CreatedBy;
                        visit.SummaryKey = request.cmp_patient_visit.SummaryKey;
                        visit.TimeStamp = request.cmp_patient_visit.TimeStamp;

                        await _context.SaveChangesAsync();
                    }

                    // =====================================================
                    // 5️⃣ RESULTS UPSERT
                    // =====================================================
                    await UpsertPwResults(request, patient);

                    await transaction.CommitAsync();

                    return Ok(new
                    {
                        status = true,
                        message = isNewPatient
                            ? "CmpPatient inserted successfully"
                            : "CmpPatient updated successfully",
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
                    await transaction.RollbackAsync();

                    return StatusCode(500, new
                    {
                        status = false,
                        message = "Database operation failed",
                        error = ex.InnerException?.Message ?? ex.Message
                    });
                }
            });
        }

        //[HttpPost("PatientCMPInformation")]
        //public async Task<IActionResult> PatientCMPInformation([FromBody] PatientCmpRequestDto request)
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
        //                PatientId = GeneratePatientId(),
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

        //        var visit = await _context.CmpPatientVisits.FirstOrDefaultAsync(v =>
        //            v.PatientGuid == patient.PatientGuid &&
        //            v.VisitNo == request.cmp_patient_visit.VisitNo);

        //        if (visit == null)
        //        {
        //            visit = new CmpPatientVisit
        //            {
        //                PatientGuid = request.cmp_patient_visit.PatientGUID,
        //                PatientId = patient.PatientId
        //            };
        //            _context.CmpPatientVisits.Add(visit);
        //        }

        //        visit.MobileId = request.cmp_patient_visit.MobileId;
        //        visit.VisitNo = request.cmp_patient_visit.VisitNo;
        //        visit.VisitDate = request.cmp_patient_visit.VisitDate;

        //        visit.FollowUpDate = request.cmp_patient_visit.FollowUpDate;
        //        visit.AgeInYears = request.cmp_patient_visit.AgeInYears;
        //        visit.AgeInMonths = request.cmp_patient_visit.AgeInMonths;
        //        visit.AgeInWeeks = request.cmp_patient_visit.AgeInWeeks;
        //        visit.AgeInDays = request.cmp_patient_visit.AgeInDays;
        //        visit.Symptoms = request.cmp_patient_visit.Symptoms;
        //        visit.DangerSign = request.cmp_patient_visit.DangerSign;
        //        visit.Referred = request.cmp_patient_visit.Referred;
        //        visit.ReferredLocation = request.cmp_patient_visit.ReferredLocation;
        //        visit.CurrentStatus = request.cmp_patient_visit.CurrentStatus;
        //        visit.CreatedAt = request.cmp_patient_visit.CreatedAt;
        //        visit.TimeStamp = request.cmp_patient_visit.TimeStamp;

        //        visit.CreatedBy = request.cmp_patient_visit.CreatedBy;
        //        visit.SummaryKey = request.cmp_patient_visit.SummaryKey;

        //        await _context.SaveChangesAsync();

        //        // 3️ PW RESULTS (DELETE & INSERT to avoid duplicates)
        //        await UpsertPwResults(request, patient);

        //        //await transaction.CommitAsync();

        //        return Ok(new
        //        {
        //            status = true,
        //            message = isNewPatient ? "CmpPatient inserted successfully" : "CmpPatient updated successfully",
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

        private async Task UpsertPwResults(PatientCmpRequestDto request, Patient patient)
        {
            string patientGuid = patient.PatientGuid;
            int visitNo = request.cmp_patient_visit.VisitNo;

            // ❌ Remove old results
            _context.PwAskForResults.RemoveRange(
                _context.PwAskForResults.Where(x => x.PatientGuid == patientGuid && x.VisitNo == visitNo));

            _context.PwExaminationResults.RemoveRange(
                _context.PwExaminationResults.Where(x => x.PatientGuid == patientGuid && x.VisitNo == visitNo));

            _context.PwPastHistoryResults.RemoveRange(
                _context.PwPastHistoryResults.Where(x => x.PatientGuid == patientGuid && x.VisitNo == visitNo));

            await _context.SaveChangesAsync();

            // ➕ Insert fresh data
            await SavePwResult(request.cmp_ask_for_result, patientGuid, "ASK", patient.PatientId);
            await SavePwResult(request.cmp_examination_result, patientGuid, "EXAM", patient.PatientId);
            await SavePwResult(request.cmp_past_history_result, patientGuid, "PAST", patient.PatientId);
        }
        private async Task SavePwResult(CmpResultDto result, string patientGuid, string type, long patientId)
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
                    _context.CmpAskForResults.Add(new CmpAskForResult
                    {
                        PatientGuid = patientGuid,
                        PatientId = patientId,
                        MobileId = result.mobileId,
                        VisitNo = result.visitNo,
                        VisitDate = DateOnly.FromDateTime((DateTime)result.visitDate),
                        Data = result.data,
                        QId = qIdInt,
                        Answer = q.Answer
                    });

                if (type == "EXAM")
                    _context.CmpExaminationResults.Add(new CmpExaminationResult
                    {
                        PatientGuid = patientGuid,
                        PatientId = patientId,
                        MobileId = result.mobileId,
                        VisitNo = result.visitNo,
                        VisitDate = DateOnly.FromDateTime((DateTime)result.visitDate),
                        Data = result.data,
                        QId = qIdInt,
                        Answer = q.Answer
                    });

                if (type == "PAST")
                    _context.CmpPastHistoryResults.Add(new CmpPastHistoryResult
                    {
                        PatientGuid = patientGuid,
                        PatientId = patientId,
                        MobileId = result.mobileId,
                        VisitNo = result.visitNo,
                        VisitDate = DateOnly.FromDateTime((DateTime)result.visitDate),
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

        // Get Patient CMP Data API
        [HttpPost("GetPatientCMPInformation")]
        public async Task<IActionResult> GetPatientCMPInformation()
        {
            int userID = Convert.ToInt32(HttpContext.Request.Form["UserId"]);
            // 1️⃣ Patients
            var patients = await _context.Patients
                .Where(p => p.CreatedBy == userID)
                .ToListAsync();

            if (!patients.Any())
                return NotFound("Patient not found");

            var patientIds = patients.Select(p => p.PatientId).ToList();

            // 2️⃣ CMP Visits
            var visits = await _context.CmpPatientVisits
                .Where(v => v.PatientId.HasValue && patientIds.Contains(v.PatientId.Value))
                .ToListAsync();

            // 3️⃣ CMP Results
            var askResults = await _context.CmpAskForResults
                .Where(x => x.PatientId.HasValue && patientIds.Contains(x.PatientId.Value))
                .ToListAsync();

            var examResults = await _context.CmpExaminationResults
                .Where(x => x.PatientId.HasValue && patientIds.Contains(x.PatientId.Value))
                .ToListAsync();

            var pastResults = await _context.CmpPastHistoryResults
                .Where(x => x.PatientId.HasValue && patientIds.Contains(x.PatientId.Value))
                .ToListAsync();

            // 4️⃣ RESPONSE (FLAT ARRAYS)
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
                }).ToList(),

                cmp_patient_visit = visits.Select(visit => new
                {
                    PatientGUID = visit.PatientGuid,
                    patientId = visit.PatientId,
                    mobileId = visit.MobileId,
                    timeStamp = visit.TimeStamp,
                    visit_no = visit.VisitNo,
                    age_in_years = visit.AgeInYears,
                    age_in_months = visit.AgeInMonths,
                    age_in_weeks = visit.AgeInWeeks,
                    age_in_days = visit.AgeInDays,
                    referred = visit.Referred,
                    referred_location = visit.ReferredLocation,
                    followUpDate = visit.FollowUpDate?.ToString("yyyy-MM-dd"),
                    dischargeDate= visit.DischargeDate,
                    deathDate = visit.DeathDate,
                    visit_date = visit.VisitDate?.ToString("yyyy-MM-dd"),
                    createdAt = visit.CreatedAt,
                    create_by = visit.CreatedBy,
                    dangerSign = visit.DangerSign,
                    symptoms = visit.Symptoms,
                    visit.OtherSymptom,
                    currentStatus = visit.CurrentStatus,
                    feverDay = visit.FeverDay,
                    headacheDay = visit.HeadacheDay,
                    respiratoryDay = visit.RespiratoryDay,
                    abdominalpainDay = visit.AbdominalpainDay,
                    diarrheaDay = visit.DiarrheaDay,
                    constipationDay = visit.ConstipationDay,
                    backpainDay = visit.BackpainDay,
                    jointpainDay = visit.JointpainDay,
                    skinlesionDay = visit.SkinlesionDay,
                    coughDay = visit.CoughDay,
                    summaryKey = visit.SummaryKey
                }).ToList(),

                cmp_ask_for_result = BuildPwResponseList(askResults),
                cmp_examination_result = BuildPwResponseList(examResults),
                cmp_past_history_result = BuildPwResponseList(pastResults)
            };

            return Ok(response);
        }


        private List<object> BuildPwResponseList<T>(List<T> results) where T : class
        {
            return results
                .GroupBy(r => new
                {
                    PatientId = r.GetType().GetProperty("PatientId")?.GetValue(r),
                    VisitNo = r.GetType().GetProperty("VisitNo")?.GetValue(r)
                })
                .Select(g =>
                {
                    dynamic first = g.First();

                    var data = g.Select(r => new
                    {
                        answer = r.GetType().GetProperty("Answer")?.GetValue(r),
                        q_id = r.GetType().GetProperty("QId")?.GetValue(r)?.ToString()
                    });

                    return new
                    {
                        patientId = first.PatientId,
                        PatientGUID = first.PatientGuid,
                        mobileId = first.MobileId,
                        visitDate = first.VisitDate?.ToString("yyyy-MM-dd"),
                        visitNo = first.VisitNo,
                        data = JsonConvert.SerializeObject(data),
                    };
                })
                .ToList<object>();
        }


    }
}
