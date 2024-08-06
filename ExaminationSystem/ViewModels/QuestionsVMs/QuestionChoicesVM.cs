using ExaminationSystem.Data.Enums;
using ExaminationSystem.DTOs.ChoiceDTOs;
using ExaminationSystem.DTOs.QuestionDTOs;
using ExaminationSystem.ViewModels.ChoicesVMs;

namespace ExaminationSystem.ViewModels.QuestionsVMs
{
    public class QuestionChoicesVM
    {
        //public int ID { get; set; }
        //public string Text { get; set; }
        //public int Grade { get; set; }
        //public QuestionLevel Level { get; set; }
        //public int InstructorID { get; set; }
        public QuestionResponseDTO Question { get; set; }
        public IEnumerable<ChoiceResponseDTO> Choices { get; set; }
    }
}
