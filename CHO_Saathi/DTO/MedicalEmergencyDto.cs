namespace CHO_Saathi.DTO
{
    public class MedicalEmergencyRequest
    {
        public List<MedicalEmergencyDto> medical_emergency { get; set; }
    }

    public class MedicalEmergencyDto
    {
        public string guid { get; set; }
        public int step1CallAmbulance { get; set; }
        public int patientRespond { get; set; }
        public int isPulse { get; set; }
        public int isBreathing { get; set; }
        public int assessAirway { get; set; }
        public int assessBreathing { get; set; }
        public int assessCirculation { get; set; }
        public string rr { get; set; }
        public string pulse { get; set; }
        public string systolic { get; set; }
        public string diastolic { get; set; }
        public string spo2 { get; set; }
        public int crt { get; set; }
        public string bloodGlucose { get; set; }
        public string rbs { get; set; }
        public string capillaryRefillDate { get; set; }
        public string capillaryRefillTime { get; set; }
        public string? obstructionSign { get; set; }
        public int isForeignObject { get; set; }
        public int isChoking { get; set; }
        public int isCough { get; set; }
        public string breathingType { get; set; }
        public int isCold { get; set; }
        public int isBleeding { get; set; }
        public int unconsciousNonTrauma { get; set; }
        public int chestPain { get; set; }
        public int strokeSymptoms { get; set; }
        public int trauma { get; set; }
        public int burns { get; set; }
        public int poisoning { get; set; }
        public int snakeBite { get; set; }
        public int respiratoryDistress { get; set; }
        public int seizure { get; set; }
        public int isEdited { get; set; }
        public string anaphylaxis { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string mobile { get; set; }
        public string gender { get; set; }
        public string emergencySymptom { get; set; }
        
    }
}
