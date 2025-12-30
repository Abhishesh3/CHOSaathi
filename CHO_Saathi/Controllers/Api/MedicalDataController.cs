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
    public class MedicalDataController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public MedicalDataController(ApplicationDBContext context)
        {
            _context = context;
        }




        [HttpPost("Patient_Visit")]
        public async Task<IActionResult> Patient_Visit([FromBody] UnifiedRequest request)
        {
            List<CmpAskForResult> AskForResult = new List<CmpAskForResult>();
            List<CmpExaminationResult> ExaminationResult = new List<CmpExaminationResult>();
            List<CmpPastHistoryResult> PastHistoryResult = new List<CmpPastHistoryResult>();
            List<PatientVisit> PatientVisit = new List<PatientVisit>();

          
                if (request.AskForResult != null)
                {
                    var existingAsk = await _context.CmpAskForResults
                        .FirstOrDefaultAsync(m => m.MobileId == request.AskForResult.MobileId);

                    if (existingAsk != null)
                    {

                        existingAsk.PatientId = request.AskForResult.PatientId;
                        existingAsk.MobileId = request.AskForResult.MobileId;
                        existingAsk.VisitNo = request.AskForResult.VisitNo;
                        existingAsk.VisitDate = request.AskForResult.VisitDate;
                        existingAsk.Data = request.AskForResult.Data;

                        _context.Update(existingAsk);
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        request.AskForResult.Sno = 0; // Let SQL Server auto-generate the ID
                        _context.CmpAskForResults.Add(request.AskForResult);
                    }
                }
            
          
                if (request.ExaminationResult != null)
                {
                    var existingExam = await _context.CmpExaminationResults
                        .FirstOrDefaultAsync(m => m.MobileId == request.ExaminationResult.MobileId);

                    if (existingExam != null)
                    {
                        existingExam.PatientId = request.ExaminationResult.PatientId;
                        existingExam.MobileId = request.ExaminationResult.MobileId;
                        existingExam.VisitNo = request.ExaminationResult.VisitNo;
                        existingExam.VisitDate = request.ExaminationResult.VisitDate;
                        existingExam.Data = request.ExaminationResult.Data;
                        _context.Update(existingExam);
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        request.ExaminationResult.Sno = 0;
                        _context.CmpExaminationResults.Add(request.ExaminationResult);
                    }
                }
          
           
                if (request.PastHistoryResult != null)
                {
                    var existingPast = await _context.CmpPastHistoryResults
                        .FirstOrDefaultAsync(m => m.MobileId == request.PastHistoryResult.MobileId);

                    if (existingPast != null)
                    {
                        existingPast.PatientId = request.PastHistoryResult.PatientId;
                        existingPast.MobileId = request.PastHistoryResult.MobileId;
                        existingPast.VisitNo = request.PastHistoryResult.VisitNo;
                        existingPast.VisitDate = request.PastHistoryResult.VisitDate;
                        existingPast.Data = request.PastHistoryResult.Data;
                        _context.Update(existingPast);
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        request.PastHistoryResult.Sno = 0;
                        _context.CmpPastHistoryResults.Add(request.PastHistoryResult);
                    }
                }
          

                if (request.PatientVisit != null)
                {
                    var existingPatient = await _context.CmpPatientVisits
                        .FirstOrDefaultAsync(m => m.MobileId == request.PatientVisit.MobileId);

                    if (existingPatient != null)
                    {

                        existingPatient.PatientId = request.PatientVisit.PatientId;
                        existingPatient.MobileId = request.PatientVisit.MobileId;
                        existingPatient.TimeStamp = request.PatientVisit.TimeStamp;
                        existingPatient.VisitNo = request.PatientVisit.VisitNo;
                        existingPatient.AgeInYears = request.PatientVisit.AgeInYears;
                        existingPatient.AgeInMonths = request.PatientVisit.AgeInMonths;
                        existingPatient.AgeInWeeks = request.PatientVisit.AgeInWeeks;
                        existingPatient.AgeInDays = request.PatientVisit.AgeInDays;
                        existingPatient.Referred = request.PatientVisit.Referred;
                        existingPatient.ReferredLocation = request.PatientVisit.ReferredLocation;
                        existingPatient.FollowUpDate = request.PatientVisit.FollowUpDate;
                        existingPatient.DischargeDate = request.PatientVisit.DischargeDate;
                        existingPatient.DeathDate = request.PatientVisit.DeathDate;
                        existingPatient.VisitDate = request.PatientVisit.VisitDate;
                        existingPatient.CreatedAt = request.PatientVisit.CreatedAt;
                        existingPatient.CreatedBy = request.PatientVisit.CreatedBy;
                        existingPatient.DangerSign = request.PatientVisit.DangerSign;
                        existingPatient.Symptoms = request.PatientVisit.Symptoms;
                        existingPatient.OtherSymptom = request.PatientVisit.OtherSymptom;
                        existingPatient.CurrentStatus = request.PatientVisit.CurrentStatus;
                        existingPatient.FeverDay = request.PatientVisit.FeverDay;
                        existingPatient.HeadacheDay = request.PatientVisit.HeadacheDay;
                        existingPatient.RespiratoryDay = request.PatientVisit.RespiratoryDay;
                        existingPatient.AbdominalpainDay = request.PatientVisit.AbdominalpainDay;
                        existingPatient.DiarrheaDay = request.PatientVisit.DiarrheaDay;
                        existingPatient.ConstipationDay = request.PatientVisit.ConstipationDay;
                        existingPatient.BackpainDay = request.PatientVisit.BackpainDay;
                        existingPatient.JointpainDay = request.PatientVisit.JointpainDay;
                        existingPatient.SkinlesionDay = request.PatientVisit.SkinlesionDay;
                        existingPatient.CoughDay = request.PatientVisit.CoughDay;
                        _context.Update(existingPatient);
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        request.PatientVisit.PatientVisitId = 0;
                        _context.CmpPatientVisits.Add(request.PatientVisit);
                    }
                }
            


            if (AskForResult.Count > 0)
            {
                _context.AddRange(AskForResult);
            }

            if (ExaminationResult.Count > 0)
            {
                _context.AddRange(ExaminationResult);
            }

            if (PastHistoryResult.Count > 0)
            {
                _context.AddRange(PastHistoryResult);
            }

            if (PatientVisit.Count > 0)
            {
                _context.AddRange(PatientVisit);
            }

            _context.SaveChanges();
            return Ok("Status:Success");

            //await _context.SaveChangesAsync();
            //return Ok(request);
        }

        //[HttpPost("Patient_Visit")]
        //public async Task<IActionResult> Patient_Visit([FromBody] UnifiedRequest request)
        //{
        //    if (request.AskForResult != null)
        //    {
        //        var existing = await _context.CmpAskForResults.Where(m => m.MobileId == request.AskForResult.MobileId).FirstOrDefaultAsync();
        //        if (existing != null)
        //        {
        //            _context.Entry(existing).CurrentValues.SetValues(request.AskForResult);
        //            await _context.SaveChangesAsync();
        //        }
        //        else
        //        {
        //            request.AskForResult.Sno = 0;
        //            _context.CmpAskForResults.Add(request.AskForResult);
        //        }

        //    }

        //    if (request.PastHistoryResult != null)
        //    {
        //        var existing = await _context.CmpPastHistoryResults.Where(m => m.MobileId == request.PastHistoryResult.MobileId).FirstOrDefaultAsync();
        //        if (existing != null)
        //            _context.Entry(existing).CurrentValues.SetValues(request.PastHistoryResult);
        //        await _context.SaveChangesAsync();
        //        else

        //            _context.CmpPastHistoryResults.Add(request.PastHistoryResult);
        //    }

        //    if (request.ExaminationResult != null)
        //    {
        //        var existing = await _context.CmpExaminationResults.Where(m => m.MobileId == request.ExaminationResult.MobileId).FirstOrDefaultAsync();
        //        if (existing != null)
        //            _context.Entry(existing).CurrentValues.SetValues(request.ExaminationResult);
        //        await _context.SaveChangesAsync();
        //        else
        //            _context.CmpExaminationResults.Add(request.ExaminationResult);
        //    }

        //    if (request.PatientVisit != null)
        //    {
        //        var existing = await _context.CmpPatientVisits.Where(m => m.MobileId == request.PatientVisit.MobileId).FirstOrDefaultAsync();
        //        if (existing != null)
        //            _context.Entry(existing).CurrentValues.SetValues(request.PatientVisit);
        //         await _context.SaveChangesAsync();
        //        else
        //            _context.CmpPatientVisits.Add(request.PatientVisit);
        //    }

        //    await _context.SaveChangesAsync();
        //    return Ok(request);
        //}
    }

    public class UnifiedRequest
    {
        public CmpAskForResult? AskForResult { get; set; }
        public CmpPastHistoryResult? PastHistoryResult { get; set; }
        public CmpExaminationResult? ExaminationResult { get; set; }
        public CmpPatientVisit? PatientVisit { get; set; }
    }
}
