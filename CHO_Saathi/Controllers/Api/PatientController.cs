using CHO_Saathi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CHO_Saathi.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public PatientController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpPost("Patient")]
        public async Task<IActionResult> CreatePatient([FromBody] CreatePatientRequest request)
        {
            try
            {
                // Validate the request
                if (!ModelState.IsValid)
                {
                    var errors = ModelState
                        .SelectMany(x => x.Value.Errors)
                        .Select(x => x.ErrorMessage)
                        .ToList();

                    return BadRequest(new ApiResponse
                    {
                        status = 400,
                        message = "Invalid data provided",
                        response = new PatientResponse
                        {
                            status = 0,
                            message = string.Join(", ", errors),
                            patient_id = 0
                        }
                    });
                }

                // Check for duplicate mobile number
                var existingPatient = await _context.Patients
                    .FirstOrDefaultAsync(p => p.Mobile == request.Mobile && p.IsActive==1);

                if (existingPatient != null)
                {
                    return BadRequest(new ApiResponse
                    {
                        status = 400,
                        message = "Patient already exists",
                        response = new PatientResponse
                        {
                            status = 0,
                            message = "Patient with this mobile number already exists",
                            patient_id = 0
                        }
                    });
                }

                // Create new patient
                var patient = new Patient
                {
                    FullName = request.FullName,
                    Mobile = request.Mobile,
                    Dob = request.Dob,
                    Gender = request.Gender,
                    HeightCm = request.HeightCm ?? 0,
                    WeightKg = request.WeightKg ?? 0,
                    IsPregnant = request.IsPregnant ?? 0,
                    MonthOfAge = request.MonthOfAge ?? 0,
                    WeeksOfAge = request.WeeksOfAge ?? 0,
                    YearOfAge = request.YearOfAge ?? 0,
                    AgeType = request.AgeType ?? 0,
                    FlowType = request.FlowType ?? 0,
                    SpouseName = request.SpouseName,
                    VillageName = request.VillageName,
                    VillageId = request.VillageId,
                    CenterId = request.CenterId,
                    HealthWorkerId = request.HealthWorkerId,
                    Status = request.Status ?? 0, // Active by default
                    IsActive = request.IsActive ?? 0,
                    CreatedAt = DateTime.Now,
                    CreatedBy = request.CreatedBy ?? 1, // Default user if not specified
                    Mode = request.Mode ?? 1,
                    IsWomanPregnant=request.IsWomanPregnant ?? 1,
                    MobileId = request.MobileId ?? 0,
                    TotalWeeks = request.TotalWeeks ?? 0,
                    TotalMonths = request.TotalMonths ?? 0,
                    RchId = request.RchId,
                    FollowUpDate = request.FollowUpDate,
                    LmpDate = request.LmpDate,
                    EddDate = request.EddDate,
                    AncRegistered = request.AncRegistered ?? 0,
                    AbhaId=request.AbhaId,
                    PatientType=request.PatientType,
                    UpdatedBy = 0 // Set to 0 initially
                };

                // Add patient to database
                _context.Patients.Add(patient);
                await _context.SaveChangesAsync();

                // Return success response
                return Ok(new ApiResponse
                {
                    status = 200,
                    message = "Patient created successfully",
                    response = new PatientResponse
                    {
                        status = 1,
                        message = "Patient registered successfully",
                        patient_id = (int)patient.PatientId
                    }
                });
            }
            catch (Exception ex)
            {
                // Log the exception (you can add logging here)
                
                // Return error response
                return StatusCode(500, new ApiResponse
                {
                    status = 500,
                    message = "Internal server error",
                    response = new PatientResponse
                    {
                        status = 0,
                        message = $"Error creating patient: {ex.Message}",
                        patient_id = 0
                    }
                });
            }
        }
    }

    // Request model for creating a patient
    public class CreatePatientRequest
    {
        [Required(ErrorMessage = "Full name is required")]
        [StringLength(100, ErrorMessage = "Full name cannot exceed 100 characters")]
        [JsonPropertyName("fullName")]
        public string FullName { get; set; } = null!;

        [Required(ErrorMessage = "Mobile number is required")]
        [StringLength(15, MinimumLength = 10, ErrorMessage = "Mobile number must be between 10-15 characters")]
        [RegularExpression(@"^[0-9]{10,15}$", ErrorMessage = "Mobile number must contain only digits and be 10-15 characters long")]
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; } = null!;

        [JsonPropertyName("abhaId")]
        public string AbhaId { get; set; } = null!;

        [JsonPropertyName("patientType")]
        public int? PatientType { get; set; }


        [Required(ErrorMessage = "Date of birth is required")]
        [JsonPropertyName("dob")]
        public DateOnly Dob { get; set; }

        [StringLength(10, ErrorMessage = "Gender cannot exceed 10 characters")]
        [JsonPropertyName("gender")]
        public string? Gender { get; set; }

        [Range(0, 300, ErrorMessage = "Height must be between 0 and 300 cm")]
        [JsonPropertyName("heightCm")]
        public double? HeightCm { get; set; }

        [Range(0, 500, ErrorMessage = "Weight must be between 0 and 500 kg")]
        [JsonPropertyName("weightKg")]
        public double? WeightKg { get; set; }

        [JsonPropertyName("isPregnant")]
        public int? IsPregnant { get; set; }

        [Range(0, 2000, ErrorMessage = "Month of age must be between 0 and 2000")]
        [JsonPropertyName("monthOfAge")]
        public int? MonthOfAge { get; set; }

        [Range(0, 10000, ErrorMessage = "Weeks of age must be between 0 and 10000")]
        [JsonPropertyName("weeksOfAge")]
        public int? WeeksOfAge { get; set; }

        [Range(0, 150, ErrorMessage = "Year of age must be between 0 and 150")]
        [JsonPropertyName("yearOfAge")]
        public int? YearOfAge { get; set; }

        [JsonPropertyName("ageType")]
        public int? AgeType { get; set; }

        [JsonPropertyName("flowType")]
        public int? FlowType { get; set; }

        [StringLength(100, ErrorMessage = "Spouse name cannot exceed 100 characters")]
        [JsonPropertyName("spouseName")]
        public string? SpouseName { get; set; }

        [StringLength(100, ErrorMessage = "Village name cannot exceed 100 characters")]
        [JsonPropertyName("villageName")]
        public string? VillageName { get; set; }

        [JsonPropertyName("villageId")]
        public string? VillageId { get; set; }

        [JsonPropertyName("centerId")]
        public string? CenterId { get; set; }

        [JsonPropertyName("healthWorkerId")]
        public string? HealthWorkerId { get; set; }

        [JsonPropertyName("createdBy")]
        public int? CreatedBy { get; set; }

        [JsonPropertyName("mode")]
        public int? Mode { get; set; }

        [JsonPropertyName("isWomanPregnant")]
        public int? IsWomanPregnant { get; set; }

        [JsonPropertyName("mobileId")]
        public int? MobileId { get; set; }

        [Range(0, 10000, ErrorMessage = "Total weeks must be between 0 and 10000")]
        [JsonPropertyName("totalWeeks")]
        public int? TotalWeeks { get; set; }

        [Range(0, 2000, ErrorMessage = "Total months must be between 0 and 2000")]
        [JsonPropertyName("totalMonths")]
        public int? TotalMonths { get; set; }

        [JsonPropertyName("rchId")]
        public string? RchId { get; set; }

        [JsonPropertyName("followUpDate")]
        public DateOnly? FollowUpDate { get; set; }

        [JsonPropertyName("lmpDate")]
        public DateOnly? LmpDate { get; set; }

        [JsonPropertyName("eddDate")]
        public DateOnly? EddDate { get; set; }

        [JsonPropertyName("ancRegistered")]
        public int? AncRegistered { get; set; }

        [JsonPropertyName("isActive")]
        public int? IsActive { get; set; }

        [JsonPropertyName("status")]
        public int? Status { get; set; }
    }

    // Response models
    public class ApiResponse
    {
        [JsonPropertyName("status")]
        public int status { get; set; }
        
        [JsonPropertyName("message")]
        public string message { get; set; } = null!;
        
        [JsonPropertyName("response")]
        public PatientResponse response { get; set; } = null!;
    }

    public class PatientResponse
    {
        [JsonPropertyName("status")]
        public int status { get; set; }
        
        [JsonPropertyName("message")]
        public string message { get; set; } = null!;
        
        [JsonPropertyName("patient_id")]
        public int patient_id { get; set; }
    }
}