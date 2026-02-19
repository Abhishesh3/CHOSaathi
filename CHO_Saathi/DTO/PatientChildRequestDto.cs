namespace CHO_Saathi.DTO
{
    public class PatientChildRequestDto
    {
        public PatientsDto1? patients { get; set; }
        public PatientVisitDto1 patient_visit { get; set; }
        public Immunization1? immunization { get; set; }
        public CoughTest1? cough_test { get; set; }
        public DiarrheaTest1? diarrhea_test { get; set; }
        public FeverTest1? fever_test { get; set; }
        public PhysicalTest1? physical_test { get; set; }

    }

    public class PatientsDto1
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

    public class PatientVisitDto1
    {
        public string PatientGUID { get; set; }
        public int visit_no { get; set; }
        public DateTime visit_date { get; set; }
        public DateTime? followUpDate { get; set; }
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
        //public DateTime? timeStamp { get; set; }
        //public DateTime createdAt { get; set; }
        public long createdAt { get; set; }
        public int create_by { get; set; }
        public int mobileId { get; set; }
        public string? SummaryKey { get; set; }
    }

    public class PatientType
    {
        public string patientType { get; set; }
    }

    public class Immunization1
    {
        public int Sno { get; set; }

        public long? PatientId { get; set; }

        public int MobileId { get; set; }

        //public DateTime? TimeStamp { get; set; }
        public long? TimeStamp { get; set; }

        public int IsVerified { get; set; }

        public int IsCompleted { get; set; }

        public int VisitNo { get; set; }

        public string SelectedVaccines { get; set; }
    }

    public class SelectedVaccine
    {
        public string? AgeInMonth { get; set; }
        public string? AgeInWeek { get; set; }
        public int Id { get; set; }
        public bool IsApplicable { get; set; }
        public bool IsSelected { get; set; }
        public string? Title { get; set; }
        public int Type { get; set; }
    }

    public class CoughTest1
    {
        public int Sno { get; set; }

        public long? PatientId { get; set; }

        public int MobileId { get; set; }

        //public DateTime? TimeStamp { get; set; }
        public long? TimeStamp { get; set; }

        public int VisitNo { get; set; }

        public int BreathAMin { get; set; }

        public int CoughDuration { get; set; }

        public string? OxygenSatuaration { get; set; }

        public int ChestIndrawing { get; set; }
    }

    public class DiarrheaTest1
    {
        public int Sno { get; set; }

        public long? PatientId { get; set; }

        public int MobileId { get; set; }

        //public DateTime? TimeStamp { get; set; }
        public long? TimeStamp { get; set; }

        public int VisitNo { get; set; }

        public int BloodInStool { get; set; }

        public int DurationDiarrhea { get; set; }

        public int Unconsious { get; set; }

        public int SunkenEyes { get; set; }

        public int UnableToDrink { get; set; }

        public int SkinPinchVerySlow { get; set; }

        public int Restless { get; set; }

        public int DrinkEagerly { get; set; }

        public int SkinPinchSlow { get; set; }
    }

    public class FeverTest1
    {
        public int Sno { get; set; }

        public long? PatientId { get; set; }

        public int MobileId { get; set; }

        //public DateTime? TimeStamp { get; set; }
        public long? TimeStamp { get; set; }
        public int VisitNo { get; set; }

        public float Temperature { get; set; }

        public int MalariaTestDone { get; set; }

        public int MalariaRdt { get; set; }

        public int StiffNeck { get; set; }
    }
    public class PhysicalTest1
    {
        public int Sno { get; set; }

        public long? PatientId { get; set; }

        public int MobileId { get; set; }

        //public DateTime? TimeStamp { get; set; }
        public long? TimeStamp { get; set; }

        public int VisitNo { get; set; }

        public int OdemaFeet { get; set; }

        public string? Height { get; set; }

        public string? MuacReading { get; set; }

        public int PalmerPallor { get; set; }

        public string? Haemoglobin { get; set; }
    }

}
