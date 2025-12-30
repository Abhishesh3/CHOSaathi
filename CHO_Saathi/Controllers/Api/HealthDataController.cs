
using CHO_Saathi.DTO;
using CHO_Saathi.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace CHO_Saathi.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthDataController : Controller
    {
        private readonly ApplicationDBContext _context;

        public HealthDataController(ApplicationDBContext context)
        {
            _context = context;
        }


        [HttpPost("PatientData")]
        public async Task<IActionResult> PatientData([FromBody] HealthDataDto dto)
        {
            // Save or update patient
            var patient = _context.Patients.FirstOrDefault(p => p.Mobile == dto.Patient.Mobile);
            if (patient == null)
            {
                patient = new Patient
                {
                    FullName = dto.Patient.FullName,
                    Gender = dto.Patient.Gender,
                    Dob = dto.Patient.Dob,
                    Mobile = dto.Patient.Mobile,
                    VillageName = dto.Patient.VillageName,
                    WeightKg = (double)dto.Patient.WeightKg,
                    HeightCm = (double)dto.Patient.HeightCm,
                    YearOfAge = dto.Patient.YearOfAge,
                    CreatedAt = DateTime.Now
                };

                _context.Patients.Add(patient);
                await _context.SaveChangesAsync();
            }
            else
            {
                // Update patient details if needed
                patient.FullName = dto.Patient.FullName;
                patient.Gender = dto.Patient.Gender;
                patient.Dob = dto.Patient.Dob;
                patient.VillageName = dto.Patient.VillageName;
                patient.WeightKg = (double)dto.Patient.WeightKg;
                patient.HeightCm = (double)dto.Patient.HeightCm;
                patient.YearOfAge = dto.Patient.YearOfAge;
                patient.UpdatedAt = DateTime.Now;
                await _context.SaveChangesAsync();
            }

            // Save or update results
            SaveResults(dto.CmpAskForResult, patient.PatientId, "CmpAskForResult");
            SaveResults(dto.CmpExaminationResult, patient.PatientId, "CmpExaminationResult");
            SaveResults(dto.CmpPastHistoryResult, patient.PatientId, "CmpPastHistoryResult");
            SaveResults(dto.PwAskForResult, patient.PatientId, "PwAskForResult");
            SaveResults(dto.PwExaminationResult, patient.PatientId, "PwExaminationResult");
            SaveResults(dto.PwPastHistoryResult, patient.PatientId, "PwPastHistoryResult");

            await _context.SaveChangesAsync();
            return Ok(new { message = "Data saved successfully" });
        }

        private void SaveResults(ResultWrapperDto wrapper, int patientId, string type)
        {
            foreach (var item in wrapper.Data)
            {
                int questionId = int.Parse(item.Q_Id);

                switch (type)
                {
                    case "CmpAskForResult":
                        UpsertResult(_context.CmpAskForResults, patientId, wrapper, questionId, item.Answer);
                        break;

                    case "CmpExaminationResult":
                        UpsertResult(_context.CmpExaminationResults, patientId, wrapper, questionId, item.Answer);
                        break;

                    case "CmpPastHistoryResult":
                        UpsertResult(_context.CmpPastHistoryResults, patientId, wrapper, questionId, item.Answer);
                        break;

                    case "PwAskForResult":
                        UpsertResult(_context.PwAskForResults, patientId, wrapper, questionId, item.Answer);
                        break;

                    case "PwExaminationResult":
                        UpsertResult(_context.PwExaminationResults, patientId, wrapper, questionId, item.Answer);
                        break;

                    case "PwPastHistoryResult":
                        UpsertResult(_context.PwPastHistoryResults, patientId, wrapper, questionId, item.Answer);
                        break;
                }
            }
        }

        private void UpsertResult<T>(DbSet<T> dbSet, int patientId, ResultWrapperDto wrapper, int questionId, string answer) where T : class, new()
        {
            dynamic existing = dbSet.FirstOrDefault(x =>
                EF.Property<int>(x, "MobileId") == wrapper.MobileId &&
                EF.Property<DateOnly>(x, "VisitDate") == wrapper.VisitDate &&
                EF.Property<int>(x, "VisitNo") == wrapper.VisitNo &&
                EF.Property<int>(x, "QId") == questionId);

            if (existing != null)
            {
                existing.Answer = answer; // Update
            }
            else
            {
                var entity = new T();
                entity.GetType().GetProperty("MobileId")?.SetValue(entity, wrapper.MobileId);
                entity.GetType().GetProperty("VisitDate")?.SetValue(entity, wrapper.VisitDate);
                entity.GetType().GetProperty("VisitNo")?.SetValue(entity, wrapper.VisitNo);
                entity.GetType().GetProperty("QId")?.SetValue(entity, questionId);
                entity.GetType().GetProperty("Answer")?.SetValue(entity, answer);

                dbSet.Add(entity);
            }
        }



        //[HttpPost("PatientData")]
        //public async Task<IActionResult> PatientData([FromBody] HealthDataDto dto)
        //{
        //    var patient = new Patient
        //    {
        //        FullName = dto.Patient.FullName,
        //        Gender = dto.Patient.Gender,
        //        Dob = dto.Patient.Dob,
        //        Mobile = dto.Patient.Mobile,
        //        VillageName = dto.Patient.VillageName,
        //        WeightKg = (double)dto.Patient.WeightKg,
        //        HeightCm = (double)dto.Patient.HeightCm,
        //        YearOfAge = dto.Patient.YearOfAge,
        //        CreatedAt = DateTime.Now
        //    };

        //    _context.Patients.Add(patient);
        //    await _context.SaveChangesAsync();

        //    SaveResults(dto.CmpAskForResult, patient.PatientId, "CmpAskForResult");
        //    SaveResults(dto.CmpExaminationResult, patient.PatientId, "CmpExaminationResult");
        //    SaveResults(dto.CmpPastHistoryResult, patient.PatientId, "CmpPastHistoryResult");
        //    SaveResults(dto.PwAskForResult, patient.PatientId, "PwAskForResult");
        //    SaveResults(dto.PwExaminationResult, patient.PatientId, "PwExaminationResult");
        //    SaveResults(dto.PwPastHistoryResult, patient.PatientId, "PwPastHistoryResult");

        //    await _context.SaveChangesAsync();
        //    return Ok(new { message = "Data saved successfully" });
        //}

        //private void SaveResults(ResultWrapperDto wrapper, int patientId, string type)
        //{
        //    foreach (var item in wrapper.Data)
        //    {
        //        var entity = new
        //        {
        //            PatientId = patientId,
        //            MobileId = wrapper.MobileId,
        //            VisitDate = wrapper.VisitDate,
        //            VisitNo = wrapper.VisitNo,
        //            QuestionId = int.Parse(item.Q_Id),
        //            Answer = item.Answer
        //        };

        //        switch (type)
        //        {
        //            case "CmpAskForResult":
        //                _context.CmpAskForResults.Add(new CmpAskForResult
        //                {
        //                    PatientId = entity.PatientId,
        //                    MobileId = entity.MobileId,
        //                    VisitDate = entity.VisitDate,
        //                    VisitNo = entity.VisitNo,
        //                    QId = entity.QuestionId,
        //                    Answer = entity.Answer
        //                });
        //                break;
        //            case "CmpExaminationResult":
        //                _context.CmpExaminationResults.Add(new CmpExaminationResult
        //                {
        //                    PatientId = entity.PatientId,
        //                    MobileId = entity.MobileId,
        //                    VisitDate = entity.VisitDate,
        //                    VisitNo = entity.VisitNo,
        //                    QId = entity.QuestionId,
        //                    Answer = entity.Answer
        //                });
        //                break;
        //            case "CmpPastHistoryResult":
        //                _context.CmpPastHistoryResults.Add(new CmpPastHistoryResult
        //                {
        //                    PatientId = entity.PatientId,
        //                    MobileId = entity.MobileId,
        //                    VisitDate = entity.VisitDate,
        //                    VisitNo = entity.VisitNo,
        //                    QId = entity.QuestionId,
        //                    Answer = entity.Answer
        //                });
        //                break;
        //            case "PwAskForResult":
        //                _context.PwAskForResults.Add(new PwAskForResult
        //                {
        //                    PatientId = entity.PatientId,
        //                    MobileId = entity.MobileId,
        //                    VisitDate = entity.VisitDate,
        //                    VisitNo = entity.VisitNo,
        //                    QId = entity.QuestionId,
        //                    Answer = entity.Answer
        //                });
        //                break;
        //            case "PwExaminationResult":
        //                _context.PwExaminationResults.Add(new PwExaminationResult
        //                {
        //                    PatientId = entity.PatientId,
        //                    MobileId = entity.MobileId,
        //                    VisitDate = entity.VisitDate,
        //                    VisitNo = entity.VisitNo,
        //                    QId = entity.QuestionId,
        //                    Answer = entity.Answer
        //                });
        //                break;
        //            case "PwPastHistoryResult":
        //                _context.PwPastHistoryResults.Add(new PwPastHistoryResult
        //                {
        //                    PatientId = entity.PatientId,
        //                    MobileId = entity.MobileId,
        //                    VisitDate = entity.VisitDate,
        //                    VisitNo = entity.VisitNo,
        //                    QId = entity.QuestionId,
        //                    Answer = entity.Answer
        //                });
        //                break;
        //        }
        //    }
        //}
    }
}
