using ExaminationSystem.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Models
{
    public class Question : BaseModel
    {
        public string Text { get; set; }
        public int Grade { get; set; }
        public QuestionLevel Level { get; set; }
        [ForeignKey("Instructor")]
        public int InstructorID { get; set; }
        public Instructor Instructor { get; set; }
        public HashSet<ExamQuestion> ExamQuestions { get; set; } = new HashSet<ExamQuestion>();
        public HashSet<Choice> Choices { get; set; }

    }
}
