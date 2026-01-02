using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using System.Text.Json.Serialization;

namespace CHO_Saathi.ViewComponents
{
    public class PatientInformationViewModel
    {
        public List<PatientDetails> patientDetails { get; set; }
        public List<PatientGraphData> patientGraphData { get; set; }
    }
    public class PatientDetails
    {
        public int Sno { get; set; }

        public string? PatientGuid { get; set; }

        public long patient_id { get; set; }

        public int mobile_id { get; set; }

        public string? centerId { get; set; }

        //public DateTime? createdAt { get; set; }
        public string? createdAt { get; set; }

        public int createdBy { get; set; }

        //public DateOnly Dob { get; set; }
        public string DOB { get; set; }

        public int flowType { get; set; }

        public string fullName { get; set; } = null!;

        public string? gender { get; set; }

        public string? healthWorkerId { get; set; }

        public double heightCm { get; set; }

        public int? isPregnant { get; set; }

        public string mobile { get; set; } = null!;

        public string? AbhaId { get; set; }

        public int? PatientType { get; set; }

        public int monthOfAge { get; set; }

        public string? spouseName { get; set; }

        public int status { get; set; }

        //public DateTime? UpdatedAt { get; set; }
        public string? UpdatedAt { get; set; }

        public int UpdatedBy { get; set; }

        public string? villageName { get; set; }

        public string? village_id { get; set; }

        public int ageType { get; set; }

        public int weeksOfAge { get; set; }

        public double weightKg { get; set; }

        public int yearOfAge { get; set; }

        //public DateOnly? followUpDate { get; set; }
        public string? followUpDate { get; set; }

        public int totalWeeks { get; set; }

        public int totalMonths { get; set; }

        public string? rchId { get; set; }

        public int isActive { get; set; }

        public string? death_date { get; set; }

        public string? case_close_date { get; set; }

        public string? lmp_date { get; set; }

        public string? edd_date { get; set; }

        public int? ancRegistered { get; set; }

        public int mode { get; set; }

        public int? IsWomanPregnant { get; set; }

        public string? StateName { get; set; }
        public string? District { get; set; }
        public string? BlockName { get; set; }
        public string FacilityName { get; set; }
        public string SubFacility { get; set; }
        public string registeredDate { get; set; }
        public string visit_date { get; set; }
        
    }

    public class PatientGraphData
    {
        public int TotalPatient { get; set; }
        public int TotalReferral { get; set; }
        public int LiveCases { get; set; }
        public int ClosedCases { get; set; }
        public int EmergencyServices { get; set; }
    }
}
