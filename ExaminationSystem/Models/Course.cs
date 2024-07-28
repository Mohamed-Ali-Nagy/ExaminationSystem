using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Models
{
    public class Course:BaseModel
    {
        public int CreditHours { get; set; }
        public string Name { get; set; }

        [ForeignKey("Instructor")]
        public int InstructorID { get; set; }
        public Instructor Instructor { get; set; }

        public HashSet<StudentCourse> StudentCourses { get; set; }

    }
}
