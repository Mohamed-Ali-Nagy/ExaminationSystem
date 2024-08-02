using System.ComponentModel.DataAnnotations;

namespace ExaminationSystem.ViewModels
{
    public class CourseUpdateVM
    {
        [Required]
        public int ID { get; set; }
        public int CreditHours { get; set; }
        public string Name { get; set; }
        public int InstructorID { get; set; }
    }
}
