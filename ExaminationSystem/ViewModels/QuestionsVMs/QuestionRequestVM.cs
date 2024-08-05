using ExaminationSystem.Data.Enums;
using ExaminationSystem.ViewModels.ChoicesVMs;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace ExaminationSystem.ViewModels.QuestionsVMs
{
    public class QuestionRequestVM
    {
        [Required]
        public string Text { get; set; }
        [Required]
        public int Grade { get; set; }
        [Required]
        public QuestionLevel Level { get; set; }
        [Required]
        public int InstructorID { get; set; }
        [Required]
        public List<ChoiceRequestVM> ChoicesVM { get; set; }
    }
}
