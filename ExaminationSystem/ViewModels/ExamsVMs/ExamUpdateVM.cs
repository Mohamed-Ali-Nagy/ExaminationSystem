using ExaminationSystem.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace ExaminationSystem.ViewModels.ExamsVMs
{
    public class ExamUpdateVM
    {
        public int ID { get; set; }
        [Required]
        public ExamType ExamType { get; set; }
        [Required]

        public int TotalGrade { get; set; }
        [Required]

        public int InstructorID { get; set; }
        [Required]

        public int CourseID { get; set; }
        //[Required]
        //public List<int> Questions { get; set; }
        
    }
}
