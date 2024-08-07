using ExaminationSystem.Data.Enums;

namespace ExaminationSystem.DTOs.ExamDTOs
{
    public class ExamUpdateDTO
    {
        public int ID { get; set; }
        public ExamType ExamType { get; set; }
        public int TotalGrade { get; set; }
        public int InstructorID { get; set; }
        public int CourseID { get; set; }
    }
}
