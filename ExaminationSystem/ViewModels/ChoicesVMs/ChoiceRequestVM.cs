using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.ViewModels.ChoicesVMs
{
    public class ChoiceRequestVM
    {
        public string Text { get; set; }
        public bool IsRightAnswer { get; set; }
       // public int QuestionID { get; set; }
    }
}
