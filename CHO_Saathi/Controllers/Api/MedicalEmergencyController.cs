using CHO_Saathi.DTO;
using CHO_Saathi.Models;
using CHO_Saathi.ViewComponents;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NPOI.POIFS.Properties;

namespace CHO_Saathi.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalEmergencyController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public MedicalEmergencyController(ApplicationDBContext context)
        {
            _context = context;
        }


        [HttpPost("MedicalEmergencyInformation")]
        public async Task<IActionResult> MedicalEmergencyInformation([FromBody] MedicalEmergencyRequest request)
        {
            try
            {
                bool isInsert = false;
                bool isUpdate = false;

                foreach (var item in request.medical_emergency)
                {
                    // Parse Date & Time
                    DateOnly? refillDate = null;
                    TimeOnly? refillTime = null;

                    if (!string.IsNullOrEmpty(item.capillaryRefillDate))
                        refillDate = DateOnly.ParseExact(item.capillaryRefillDate, "dd-MM-yyyy");

                    if (!string.IsNullOrEmpty(item.capillaryRefillTime))
                        refillTime = TimeOnly.Parse(item.capillaryRefillTime);

                    // 🔍 Check existing by GUID
                    var existing = await _context.MedicalEmergencies
                        .FirstOrDefaultAsync(x => x.MeGuid == item.guid);

                    if (existing == null)
                    {
                        // ➕ INSERT
                        var entity = new MedicalEmergency
                        {
                            MeGuid = item.guid,
                            Step1CallAmbulance = item.step1CallAmbulance,
                            PatientRespond = item.patientRespond,
                            IsPulse = item.isPulse,
                            IsBreathing = item.isBreathing,
                            AssessAirway = item.assessAirway,
                            AssessBreathing = item.assessBreathing,
                            AssessCirculation = item.assessCirculation,
                            Rr = item.rr,
                            Pulse = item.pulse,
                            Systolic = item.systolic,
                            Diastolic = item.diastolic,
                            Spo2 = item.spo2,
                            Crt = item.crt,
                            BloodGlucose = item.bloodGlucose,
                            Rbs = item.rbs,
                            CapillaryRefillDate = refillDate,
                            CapillaryRefillTime = refillTime,
                            ObstructionSign = item.obstructionSign,
                            IsForeignObject = item.isForeignObject,
                            IsChoking = item.isChoking,
                            IsCough = item.isCough,
                            BreathingType = item.breathingType,
                            IsCold = item.isCold,
                            IsBleeding = item.isBleeding,
                            UnconsciousNonTrauma = item.unconsciousNonTrauma,
                            ChestPain = item.chestPain,
                            StrokeSymptoms = item.strokeSymptoms,
                            Trauma = item.trauma,
                            Burns = item.burns,
                            Poisoning = item.poisoning,
                            SnakeBite = item.snakeBite,
                            RespiratoryDistress = item.respiratoryDistress,
                            Seizure = item.seizure,
                            IsEdited = item.isEdited,
                            Anaphylaxis = item.anaphylaxis,
                            Name = item.name,
                            Age = item.age,
                            Mobile = item.mobile,
                            Gender = item.gender
                        };

                        _context.MedicalEmergencies.Add(entity);
                        isInsert = true;
                    }
                    else
                    {
                        // 🔁 UPDATE
                        existing.Step1CallAmbulance = item.step1CallAmbulance;
                        existing.PatientRespond = item.patientRespond;
                        existing.IsPulse = item.isPulse;
                        existing.IsBreathing = item.isBreathing;
                        existing.AssessAirway = item.assessAirway;
                        existing.AssessBreathing = item.assessBreathing;
                        existing.AssessCirculation = item.assessCirculation;
                        existing.Rr = item.rr;
                        existing.Pulse = item.pulse;
                        existing.Systolic = item.systolic;
                        existing.Diastolic = item.diastolic;
                        existing.Spo2 = item.spo2;
                        existing.Crt = item.crt;
                        existing.BloodGlucose = item.bloodGlucose;
                        existing.Rbs = item.rbs;
                        existing.CapillaryRefillDate = refillDate;
                        existing.CapillaryRefillTime = refillTime;
                        existing.ObstructionSign = item.obstructionSign;
                        existing.IsForeignObject = item.isForeignObject;
                        existing.IsChoking = item.isChoking;
                        existing.IsCough = item.isCough;
                        existing.BreathingType = item.breathingType;
                        existing.IsCold = item.isCold;
                        existing.IsBleeding = item.isBleeding;
                        existing.UnconsciousNonTrauma = item.unconsciousNonTrauma;
                        existing.ChestPain = item.chestPain;
                        existing.StrokeSymptoms = item.strokeSymptoms;
                        existing.Trauma = item.trauma;
                        existing.Burns = item.burns;
                        existing.Poisoning = item.poisoning;
                        existing.SnakeBite = item.snakeBite;
                        existing.RespiratoryDistress = item.respiratoryDistress;
                        existing.Seizure = item.seizure;
                        existing.IsEdited = item.isEdited;
                        existing.Anaphylaxis = item.anaphylaxis;
                        existing.Name = item.name;
                        existing.Age = item.age;
                        existing.Mobile = item.mobile;
                        existing.Gender = item.gender;

                        isUpdate = true;
                    }
                }

                await _context.SaveChangesAsync();

                return Ok(new
                {
                    status = true,
                    message = isInsert ? "Medical Emergency data saved successfully"
                                      : "Medical Emergency data updated successfully",
                    response = new
                    {
                        status = 1,
                        message = "Success"
                    }
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
