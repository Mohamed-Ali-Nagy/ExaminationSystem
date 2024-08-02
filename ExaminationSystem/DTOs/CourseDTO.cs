using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.DTOs
{
    public class CourseDTO
    {
        public int ID { get; set; }
        public int CreditHours { get; set; }
        public string Name { get; set; }
        public string InstructorName { get; set; }
        public int InstructorID { get; set; }
    }
}
