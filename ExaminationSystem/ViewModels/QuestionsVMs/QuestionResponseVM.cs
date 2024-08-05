using ExaminationSystem.Data.Enums;

namespace ExaminationSystem.ViewModels.QuestionsVMs
{
    public class QuestionResponseVM
    {
        public string Text { get; set; }
        public int Grade { get; set; }
        public QuestionLevel Level { get; set; }
        public int InstructorID { get; set; }
    }
}
