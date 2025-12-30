namespace CHO_Saathi.DTO
{
    public class HealthDataDto
    {

        public PatientDto Patient { get; set; }
        public ResultWrapperDto CmpAskForResult { get; set; }
        public ResultWrapperDto CmpExaminationResult { get; set; }

        public ResultWrapperDto CmpPastHistoryResult { get; set; }
        
        public ResultWrapperDto PwAskForResult { get; set; }
        public ResultWrapperDto PwExaminationResult { get; set; }
        public ResultWrapperDto PwPastHistoryResult { get; set; }

    }

    public class PatientDto
    {
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateOnly Dob { get; set; }
        public string Mobile { get; set; }
        public string VillageName { get; set; }
        public decimal WeightKg { get; set; }
        public decimal HeightCm { get; set; }
        public int YearOfAge { get; set; }
    }

    public class ResultWrapperDto
    {
        public List<QuestionAnswerDto> Data { get; set; }
        public int MobileId { get; set; }
        public DateOnly VisitDate { get; set; }
        public int VisitNo { get; set; }
    }

    public class QuestionAnswerDto
    {
        public string Answer { get; set; }
        public string Q_Id { get; set; }
    }
}

