namespace CHO_Saathi.DTO
{
    public class PatientFullRequestDto
    {
        public PatientsDto patients { get; set; }
        public PatientVisitDto patient_visit { get; set; }
        public PwResultDto pw_ask_for_result { get; set; }
        public PwResultDto pw_examination_result { get; set; }
        public PwResultDto pw_past_history_result { get; set; }
    }

    public class PatientsDto
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

    public class PatientVisitDto
    {
        public string PatientGUID { get; set; }
        public int visit_no { get; set; }
        public DateTime visit_date { get; set; }
        public DateTime followUpDate { get; set; }
        public int ga_weeks { get; set; }
        public int age_in_years { get; set; }
        public int age_in_months { get; set; }
        public int age_in_weeks { get; set; }
        public int age_in_days { get; set; }
        public string symptoms { get; set; }
        public string dangerSign { get; set; }
        public int referred { get; set; }
        public string referred_location { get; set; }
        public int currentStatus { get; set; }
        public long timeStamp { get; set; }
        //public DateTime createdAt { get; set; } 
        public long createdAt { get; set; }
        public int create_by { get; set; }
        public int mobileId { get; set; }
    }

    public class PwResultDto
    {
        public string data { get; set; }   // JSON array string
        public int mobileId { get; set; }
        public int visitNo { get; set; }
        public DateTime visitDate { get; set; }
        public string PatientGUID { get; set; }
    }

    public class QuestionAnswer_Dto
    {
        public int q_id { get; set; }
        public string answer { get; set; }
    }


}
