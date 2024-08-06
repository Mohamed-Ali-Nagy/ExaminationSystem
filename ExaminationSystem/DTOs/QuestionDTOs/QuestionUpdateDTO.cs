using ExaminationSystem.Data.Enums;

namespace ExaminationSystem.DTOs.QuestionDTOs
{
    public class QuestionUpdateDTO
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public int Grade { get; set; }
        public QuestionLevel Level { get; set; }
        public int InstructorID { get; set; }
    }
}
