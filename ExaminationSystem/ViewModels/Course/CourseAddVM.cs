using System.ComponentModel.DataAnnotations;

namespace ExaminationSystem.ViewModels.Course
{
    public class CourseAddVM
    {
        [Required]
        public int CreditHours { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int InstructorID { get; set; }
    }
}
