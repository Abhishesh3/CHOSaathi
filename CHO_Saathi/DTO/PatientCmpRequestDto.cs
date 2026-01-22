using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CHO_Saathi.DTO
{
    public class PatientCmpRequestDto
    {
        public CmpPatientsDto patients { get; set; }
        public CmpPatientVisit1 cmp_patient_visit { get; set; }
        public CmpResultDto cmp_ask_for_result { get; set; }
        public CmpResultDto cmp_examination_result { get; set; }
        public CmpResultDto cmp_past_history_result { get; set; }
    }

    public class CmpPatientsDto
    {
        public long patientId { get; set; }
        public string PatientGUID { get; set; }
        public int mobileId { get; set; }
        public string fullName { get; set; }
        public string spouseName { get; set; }
        public string gender { get; set; }
        public DateTime dob { get; set; }
        public int yearOfAge { get; set; }
        public int monthOfAge { get; set; }
        public int weeksOfAge { get; set; }
        public int totalMonths { get; set; }
        public int totalWeeks { get; set; }
        public int ageType { get; set; }
        public decimal heightCm { get; set; }
        public decimal weightKg { get; set; }
        public string mobile { get; set; }
        public int village_id { get; set; }
        public string villageName { get; set; }
        public int centerId { get; set; }
        public int patientType { get; set; }
        public int ancRegistered { get; set; }
        public int isPregnant { get; set; }
        public int isWomanPregnant { get; set; }
        public DateOnly? lmp_date { get; set; }
        public int flowType { get; set; }
        public int status { get; set; }
        public int isActive { get; set; }
        public int createdBy { get; set; }
        public DateTime createdAt { get; set; }
    }

    public class CmpPatientVisit1
    {
        [JsonPropertyName("visit_no")]
        public int VisitNo { get; set; }

        [JsonPropertyName("mobileId")]
        public int MobileId { get; set; }

        [JsonPropertyName("visit_date")]
        public DateTime VisitDate { get; set; }

        [JsonPropertyName("createdAt")]
        public long CreatedAt { get; set; }
        //public DateTime CreatedAt { get; set; }

        [JsonPropertyName("create_by")]
        public int CreatedBy { get; set; }

        [JsonPropertyName("age_in_years")]
        public int AgeInYears { get; set; }

        [JsonPropertyName("age_in_months")]
        public int AgeInMonths { get; set; }

        [JsonPropertyName("age_in_weeks")]
        public int AgeInWeeks { get; set; }

        [JsonPropertyName("age_in_days")]
        public int AgeInDays { get; set; }

        [JsonPropertyName("referred")]
        public int Referred { get; set; }

        [JsonPropertyName("referred_location")]
        public string? ReferredLocation { get; set; }

        [JsonPropertyName("followUpDate")]
        public DateTime FollowUpDate { get; set; }

        [JsonPropertyName("dangerSign")]
        public string? DangerSign { get; set; }

        [JsonPropertyName("symptoms")]
        public string? Symptoms { get; set; }
        public int CurrentStatus { get; set; }
        //public DateTime TimeStamp { get; set; }
        public long TimeStamp { get; set; }
        public string PatientGUID { get; set; }
        public string? SummaryKey { get; set; }
    }

    public class CmpResultDto
    {
        public string data { get; set; }   // JSON array string
        public int mobileId { get; set; }
        public int visitNo { get; set; }
        public DateTime visitDate { get; set; }
        public string PatientGUID { get; set; }
    }

    public class CmpQuestionAnswer_Dto
    {
        [JsonPropertyName("q_id")]
        public string Q_Id { get; set; }

        [JsonPropertyName("answer")]
        public string Answer { get; set; }
    }
}
