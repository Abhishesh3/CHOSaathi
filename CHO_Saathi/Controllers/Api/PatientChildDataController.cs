using CHO_Saathi.DTO;
using CHO_Saathi.Models;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NPOI.POIFS.Properties;
using System.Linq;

namespace CHO_Saathi.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientChildDataController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public PatientChildDataController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpPost("PatientChildInformation")]
        public async Task<IActionResult> PatientChildInformation([FromBody] PatientChildRequestDto request)
        {
            if (request == null)
                return BadRequest("Invalid request.");

            // 🔹 Extract PatientGUID safely
            string patientGuid =
                request.patients?.PatientGUID ??
                request.patient_visit?.PatientGUID;

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
                    // 2️⃣ INSERT PATIENT IF NOT EXISTS
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
                            Mobile = request.patients.mobile,
                            MobileId = request.patients.mobileId,
                            FullName = request.patients.fullName,
                            Gender = request.patients.gender
                        };

                        _context.Patients.Add(patient);
                        isNewPatient = true;
                    }

                    // =====================================================
                    // 3️⃣ UPDATE PATIENT (IF JSON SENT)
                    // =====================================================
                    if (request.patients != null)
                    {
                        patient.MobileId = request.patients.mobileId;
                        patient.FullName = request.patients.fullName;
                        patient.SpouseName = request.patients.spouseName;
                        patient.Gender = request.patients.gender;

                        //if (request.patients.dob.HasValue &&
                        //    request.patients.dob.Value.Year >= 1753)
                        //{
                        //    patient.Dob = DateOnly.FromDateTime(request.patients.dob.Value);
                        //}

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
                    }

                    await _context.SaveChangesAsync();

                    // =====================================================
                    // 4️⃣ VISIT UPSERT
                    // =====================================================
                    if (request.patient_visit != null)
                    {
                        var visit = await _context.PatientVisits.FirstOrDefaultAsync(v =>
                            v.PatientGuid == patientGuid &&
                            v.VisitNo == request.patient_visit.visit_no);

                        if (visit == null)
                        {
                            visit = new PatientVisit
                            {
                                PatientGuid = patientGuid,
                                PatientId = patient.PatientId,
                                VisitNo = request.patient_visit.visit_no
                            };

                            _context.PatientVisits.Add(visit);
                        }

                        visit.MobileId = request.patient_visit.mobileId;

                        if (request.patient_visit.visit_date.Year >= 1753)
                            visit.VisitDate = DateOnly.FromDateTime(request.patient_visit.visit_date);

                        if (request.patient_visit.followUpDate.HasValue &&
                            request.patient_visit.followUpDate.Value.Year >= 1753)
                        {
                            visit.FollowUpDate = DateOnly.FromDateTime(request.patient_visit.followUpDate.Value);
                        }
                        else
                        {
                            visit.FollowUpDate = null;
                        }

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
                        visit.CreatedAt = request.patient_visit.createdAt;
                        visit.CreatedBy = request.patient_visit.create_by;
                        visit.SummaryKey = request.patient_visit.SummaryKey;
                        visit.TimeStamp = request.patient_visit.timeStamp;
                    }

                    await _context.SaveChangesAsync();

                    // =====================================================
                    // 5️⃣ IMMUNIZATION UPSERT
                    // =====================================================
                    if (request.immunization != null)
                    {
                        var immunization = await _context.Immunizations
                            .FirstOrDefaultAsync(x =>
                                x.PatientGuid == patientGuid &&
                                x.VisitNo == request.immunization.VisitNo);

                        if (immunization == null)
                        {
                            immunization = new Immunization
                            {
                                PatientId = patient.PatientId,
                                PatientGuid = patientGuid,
                                VisitNo = request.immunization.VisitNo
                            };

                            _context.Immunizations.Add(immunization);
                        }

                        immunization.MobileId = request.immunization.MobileId;
                        immunization.TimeStamp = request.immunization.TimeStamp;
                        immunization.IsVerified = request.immunization.IsVerified;
                        immunization.IsCompleted = request.immunization.IsCompleted;
                        immunization.SelectedVaccines = request.immunization.SelectedVaccines;
                    }

                    // =====================================================
                    // 6️⃣ COUGH TEST UPSERT
                    // =====================================================
                    if (request.cough_test != null)
                    {
                        var cough = await _context.CoughTests
                            .FirstOrDefaultAsync(x =>
                                x.PatientGuid == patientGuid &&
                                x.VisitNo == request.cough_test.VisitNo);

                        if (cough == null)
                        {
                            cough = new CoughTest
                            {
                                PatientId = patient.PatientId,
                                PatientGuid = patientGuid,
                                VisitNo = request.cough_test.VisitNo
                            };

                            _context.CoughTests.Add(cough);
                        }

                        cough.MobileId = request.cough_test.MobileId;
                        cough.TimeStamp = request.cough_test.TimeStamp;
                        cough.BreathAMin = request.cough_test.BreathAMin;
                        cough.CoughDuration = request.cough_test.CoughDuration;
                        cough.OxygenSatuaration = request.cough_test.OxygenSatuaration;
                        cough.ChestIndrawing = request.cough_test.ChestIndrawing;
                    }

                    // =====================================================
                    // 7️⃣ DIARRHEA TEST UPSERT
                    // =====================================================
                    if (request.diarrhea_test != null)
                    {
                        var diarrhea = await _context.DiarrheaTests
                            .FirstOrDefaultAsync(x =>
                                x.PatientGuid == patientGuid &&
                                x.VisitNo == request.diarrhea_test.VisitNo);

                        if (diarrhea == null)
                        {
                            diarrhea = new DiarrheaTest
                            {
                                PatientId = patient.PatientId,
                                PatientGuid = patientGuid,
                                VisitNo = request.diarrhea_test.VisitNo
                            };

                            _context.DiarrheaTests.Add(diarrhea);
                        }

                        diarrhea.MobileId = request.diarrhea_test.MobileId;
                        diarrhea.TimeStamp = request.diarrhea_test.TimeStamp;
                        diarrhea.BloodInStool = request.diarrhea_test.BloodInStool;
                        diarrhea.DurationDiarrhea = request.diarrhea_test.DurationDiarrhea;
                        diarrhea.Unconsious = request.diarrhea_test.Unconsious;
                        diarrhea.SunkenEyes = request.diarrhea_test.SunkenEyes;
                        diarrhea.UnableToDrink = request.diarrhea_test.UnableToDrink;
                        diarrhea.SkinPinchVerySlow = request.diarrhea_test.SkinPinchVerySlow;
                        diarrhea.Restless = request.diarrhea_test.Restless;
                        diarrhea.DrinkEagerly = request.diarrhea_test.DrinkEagerly;
                        diarrhea.SkinPinchSlow = request.diarrhea_test.SkinPinchSlow;
                    }

                    // =====================================================
                    // 8️⃣ FEVER TEST UPSERT
                    // =====================================================
                    if (request.fever_test != null)
                    {
                        var fever = await _context.FeverTests
                            .FirstOrDefaultAsync(x =>
                                x.PatientGuid == patientGuid &&
                                x.VisitNo == request.fever_test.VisitNo);

                        if (fever == null)
                        {
                            fever = new FeverTest
                            {
                                PatientId = patient.PatientId,
                                PatientGuid = patientGuid,
                                VisitNo = request.fever_test.VisitNo
                            };

                            _context.FeverTests.Add(fever);
                        }

                        fever.MobileId = request.fever_test.MobileId;
                        fever.TimeStamp = request.fever_test.TimeStamp;
                        fever.Temperature = request.fever_test.Temperature;
                        fever.MalariaTestDone = request.fever_test.MalariaTestDone;
                        fever.MalariaRdt = request.fever_test.MalariaRdt;
                        fever.StiffNeck = request.fever_test.StiffNeck;
                    }

                    // =====================================================
                    // 9️⃣ PHYSICAL TEST UPSERT
                    // =====================================================
                    if (request.physical_test != null)
                    {
                        var physical = await _context.PhysicalTests
                            .FirstOrDefaultAsync(x =>
                                x.PatientGuid == patientGuid &&
                                x.VisitNo == request.physical_test.VisitNo);

                        if (physical == null)
                        {
                            physical = new PhysicalTest
                            {
                                PatientId = patient.PatientId,
                                PatientGuid = patientGuid,
                                VisitNo = request.physical_test.VisitNo
                            };

                            _context.PhysicalTests.Add(physical);
                        }

                        physical.MobileId = request.physical_test.MobileId;
                        physical.TimeStamp = request.physical_test.TimeStamp;
                        physical.OdemaFeet = request.physical_test.OdemaFeet;
                        physical.Height = request.physical_test.Height;
                        physical.MuacReading = request.physical_test.MuacReading;
                        physical.PalmerPallor = request.physical_test.PalmerPallor;
                        physical.Haemoglobin = request.physical_test.Haemoglobin;
                    }

                    await _context.SaveChangesAsync();
                    await transaction.CommitAsync();

                    return Ok(new
                    {
                        status = true,
                        message = isNewPatient
                            ? "PatientChild inserted successfully"
                            : "PatientChild updated successfully",
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

        //[HttpPost("PatientChildInformation")]
        //public async Task<IActionResult> PatientChildInformation([FromBody] PatientChildRequestDto request)
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
        //        visit.CreatedBy = request.patient_visit.create_by;
        //        visit.SummaryKey = request.patient_visit.SummaryKey;

        //        await _context.SaveChangesAsync();

        //        // 3 immunization
        //        if (request.immunization != null)
        //        {
        //            var immunization = await _context.Immunizations.FirstOrDefaultAsync(x => x.PatientGuid == patient.PatientGuid && x.VisitNo == request.immunization.VisitNo);
        //            if (immunization == null)
        //            {
        //                immunization = new Immunization
        //                {
        //                    PatientId = patient.PatientId,
        //                    PatientGuid = patient.PatientGuid,
        //                    VisitNo = request.immunization.VisitNo
        //                };
        //                _context.Immunizations.Add(immunization);
        //            }
        //            immunization.MobileId = request.immunization.MobileId;
        //            immunization.TimeStamp = request.immunization.TimeStamp;
        //            immunization.IsVerified = request.immunization.IsVerified;
        //            immunization.IsCompleted = request.immunization.IsCompleted;
        //            immunization.SelectedVaccines = request.immunization.SelectedVaccines;
        //        }


        //        // 4 cough_test
        //        if (request.cough_test != null)
        //        {
        //            var cough = await _context.CoughTests
        //                .FirstOrDefaultAsync(x => x.PatientGuid == patient.PatientGuid && x.VisitNo == request.cough_test.VisitNo);

        //            if (cough == null)
        //            {
        //                cough = new CoughTest
        //                {
        //                    PatientId = patient.PatientId,
        //                    PatientGuid = patient.PatientGuid,
        //                    VisitNo = request.cough_test.VisitNo
        //                };
        //                _context.CoughTests.Add(cough);
        //            }
        //            cough.MobileId = request.cough_test.MobileId;
        //            cough.TimeStamp = request.cough_test.TimeStamp;
        //            cough.BreathAMin = request.cough_test.BreathAMin;
        //            cough.CoughDuration = request.cough_test.CoughDuration;
        //            cough.OxygenSatuaration = request.cough_test.OxygenSatuaration;
        //            cough.ChestIndrawing = request.cough_test.ChestIndrawing;
        //        }

        //        // 5 diarrhea_test
        //        if (request.diarrhea_test != null)
        //        {
        //            var diarrhea = await _context.DiarrheaTests
        //                .FirstOrDefaultAsync(x => x.PatientGuid == patient.PatientGuid && x.VisitNo == request.diarrhea_test.VisitNo);

        //            if (diarrhea == null)
        //            {
        //                diarrhea = new DiarrheaTest
        //                {
        //                    PatientId = patient.PatientId,
        //                    PatientGuid = patient.PatientGuid,
        //                    VisitNo = request.diarrhea_test.VisitNo
        //                };
        //                _context.DiarrheaTests.Add(diarrhea);
        //            }
        //            diarrhea.MobileId = request.diarrhea_test.MobileId;
        //            diarrhea.TimeStamp = request.diarrhea_test.TimeStamp;
        //            diarrhea.BloodInStool = request.diarrhea_test.BloodInStool;
        //            diarrhea.DurationDiarrhea = request.diarrhea_test.DurationDiarrhea;
        //            diarrhea.Unconsious = request.diarrhea_test.Unconsious;
        //            diarrhea.SunkenEyes = request.diarrhea_test.SunkenEyes;
        //            diarrhea.UnableToDrink = request.diarrhea_test.UnableToDrink;
        //            diarrhea.SkinPinchVerySlow = request.diarrhea_test.SkinPinchVerySlow;
        //            diarrhea.Restless = request.diarrhea_test.Restless;
        //            diarrhea.DrinkEagerly = request.diarrhea_test.DrinkEagerly;
        //            diarrhea.SkinPinchSlow = request.diarrhea_test.SkinPinchSlow;
        //        }

        //        // 6 fever_test
        //        if (request.fever_test != null)
        //        {
        //            var fever = await _context.FeverTests
        //                .FirstOrDefaultAsync(x => x.PatientGuid == patient.PatientGuid && x.VisitNo == request.fever_test.VisitNo);

        //            if (fever == null)
        //            {
        //                fever = new FeverTest
        //                {
        //                    PatientId = patient.PatientId,
        //                    PatientGuid = patient.PatientGuid,
        //                    VisitNo = request.fever_test.VisitNo
        //                };
        //                _context.FeverTests.Add(fever);
        //            }
        //            fever.MobileId = request.fever_test.MobileId;
        //            fever.TimeStamp = request.fever_test.TimeStamp;
        //            fever.Temperature = request.fever_test.Temperature;
        //            fever.MalariaTestDone = request.fever_test.MalariaTestDone;
        //            fever.MalariaRdt = request.fever_test.MalariaRdt;
        //            fever.StiffNeck = request.fever_test.StiffNeck;
        //        }

        //        // 7 physical_test
        //        if (request.physical_test != null)
        //        {
        //            var physical = await _context.PhysicalTests
        //                .FirstOrDefaultAsync(x => x.PatientGuid == patient.PatientGuid && x.VisitNo == request.physical_test.VisitNo);

        //            if (physical == null)
        //            {
        //                physical = new PhysicalTest
        //                {
        //                    PatientId = patient.PatientId,
        //                    PatientGuid = patient.PatientGuid,
        //                    VisitNo = request.physical_test.VisitNo
        //                };
        //                _context.PhysicalTests.Add(physical);
        //            }
        //            physical.MobileId = request.physical_test.MobileId;
        //            physical.TimeStamp = request.physical_test.TimeStamp;
        //            physical.OdemaFeet = request.physical_test.OdemaFeet;
        //            physical.Height = request.physical_test.Height;
        //            physical.MuacReading = request.physical_test.MuacReading;
        //            physical.PalmerPallor = request.physical_test.PalmerPallor;
        //            physical.Haemoglobin = request.physical_test.Haemoglobin;
        //        }

        //        // 8 PatientType
        //        //request.patient_type.patientType = "greater than 2 Months";


        //        await _context.SaveChangesAsync();

        //        //await SaveImmunizationVaccines(request.immunization, patient.PatientGuid, patient.PatientId);

        //        return Ok(new
        //        {
        //            status = true,
        //            message = isNewPatient ? "PatientChild inserted successfully" : "PatientChild updated successfully",
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

        public static long GeneratePatientId()
        {
            long ticks = DateTime.UtcNow.Ticks % 100000;
            int random = Random.Shared.Next(100, 1000);

            return long.Parse($"100{ticks:D5}{random}");
        }

        // Get Patient Child Data API
        [HttpPost("GetPatientChildInformation")]
        public async Task<IActionResult> GetPatientChildInformation()
        {
            int userID = Convert.ToInt32(HttpContext.Request.Form["UserId"]);
            // 1️⃣ PATIENTS
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

            // 3️⃣ CHILD MODULE TABLES
            var immunizations = await _context.Immunizations
                .Where(x => x.PatientId.HasValue && patientIds.Contains(x.PatientId.Value))
                .ToListAsync();

            var coughTests = await _context.CoughTests
                .Where(x => x.PatientId.HasValue && patientIds.Contains(x.PatientId.Value))
                .ToListAsync();

            var diarrheaTests = await _context.DiarrheaTests
                .Where(x => x.PatientId.HasValue && patientIds.Contains(x.PatientId.Value))
                .ToListAsync();

            var feverTests = await _context.FeverTests
                .Where(x => x.PatientId.HasValue && patientIds.Contains(x.PatientId.Value))
                .ToListAsync();

            var physicalTests = await _context.PhysicalTests
                .Where(x => x.PatientId.HasValue && patientIds.Contains(x.PatientId.Value))
                .ToListAsync();

            // 4️⃣ RESPONSE (Patient → Visits → Modules)
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
                    v.SummaryKey
                }).ToList(),

                immunization = immunizations.Select(i => new
                {
                    i.PatientId,
                    i.PatientGuid,
                    i.VisitNo,
                    i.MobileId,
                    i.SelectedVaccines,
                    i.IsCompleted,
                    i.IsVerified,
                    i.TimeStamp
                }).ToList(),

                cough_test = coughTests.Select(c => new
                {
                    c.PatientId,
                    c.PatientGuid,
                    c.VisitNo,
                    c.MobileId,
                    c.CoughDuration,
                    c.BreathAMin,
                    c.ChestIndrawing,
                    c.OxygenSatuaration,
                    c.TimeStamp
                }).ToList(),

                diarrhea_test = diarrheaTests.Select(d => new
                {
                    d.PatientId,
                    d.PatientGuid,
                    d.VisitNo,
                    d.MobileId,
                    d.DurationDiarrhea,
                    d.Unconsious,
                    d.BloodInStool,
                    d.DrinkEagerly,
                    d.Restless,
                    d.SunkenEyes,
                    d.UnableToDrink,
                    d.SkinPinchVerySlow,
                    d.SkinPinchSlow,
                    d.TimeStamp
                }).ToList(),

                fever_test = feverTests.Select(f => new
                {
                    f.PatientId,
                    f.PatientGuid,
                    f.VisitNo,
                    f.MobileId,
                    f.Temperature,
                    f.MalariaTestDone,
                    f.MalariaRdt,
                    f.StiffNeck,
                    f.TimeStamp
                }).ToList(),

                physical_test = physicalTests.Select(p => new
                {
                    p.PatientId,
                    p.PatientGuid,
                    p.VisitNo,
                    p.MobileId,
                    p.Height,
                    p.Haemoglobin,
                    p.MuacReading,
                    p.OdemaFeet,
                    p.PalmerPallor,
                    p.TimeStamp
                }).ToList()
            };

            return Ok(response);

        }


    }
}
