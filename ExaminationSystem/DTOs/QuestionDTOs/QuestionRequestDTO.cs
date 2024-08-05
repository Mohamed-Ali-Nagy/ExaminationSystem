using ExaminationSystem.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace ExaminationSystem.DTOs.QuestionDTOs
{
    public class QuestionRequestDTO
    {
        
        public string Text { get; set; }
        public int Grade { get; set; }
        public QuestionLevel Level { get; set; }
        public int InstructorID { get; set; }

    }
}
