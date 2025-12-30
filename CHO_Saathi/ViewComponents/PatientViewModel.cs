namespace CHO_Saathi.ViewComponents
{
    public class PatientViewModel
    {
        public int Sno { get; set; }
        public int patient_id { get; set; }
        public int mobile_id { get; set; }

        public string? centerId { get; set; }

        public DateTime? CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? Dob { get; set; }

        public int flowType { get; set; }
        public string? fullName { get; set; }
        public string? gender { get; set; }

        public string? healthWorkerId { get; set; }

        public double heightCm { get; set; }

        public int? isPregnant { get; set; }

        public string? mobile { get; set; }
        public int? monthOfAge { get; set; }
        public string? spouseName { get; set; }

        public int status { get; set; }

        public DateTime? UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }

        public string? villageName { get; set; }
        public string? village_id { get; set; }

        public int ageType { get; set; }
        public int weeksOfAge { get; set; }
        public double weightKg { get; set; }

        public int yearOfAge { get; set; }

        public DateTime? followUpDate { get; set; }

        public int totalWeeks { get; set; }
        public int totalMonths { get; set; }

        public string? rchId { get; set; }

        public int IsActive { get; set; }

        public DateTime? deathDate { get; set; }
        public DateTime? caseCloseDate { get; set; }
        public DateTime? lmpDate { get; set; }
        public DateTime? eddDate { get; set; }

        public int? ancRegistered { get; set; }

        public int mode { get; set; }

        public int? IsWomanPregnant { get; set; }
    }
}
