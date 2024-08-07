using ExaminationSystem.Data.Enums;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.QuestionsVMs;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.ViewModels.ExamsVMs
{
    public class ExamRequestVM
    {
        [Required]
        public ExamType ExamType { get; set; }
        [Required]

        public int TotalGrade { get; set; }
        [Required]

        public int InstructorID { get; set; }
        [Required]

        public int CourseID { get; set; }
        [Required]
        public List<int> Questions { get; set; }

    }
}
