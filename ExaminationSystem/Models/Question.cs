using ExaminationSystem.Data.Enums;

namespace ExaminationSystem.Models
{
    public class Question:BaseModel
    {
        public string Text { get; set; }
        public int Grade { get; set; }
        public QuestionLevel Level { get; set; }
        public HashSet<ExamQuestion> ExamQuestions { get; set; } = new HashSet<ExamQuestion>();
        public HashSet<Choice> Choices { get; set; } 

    }
}
