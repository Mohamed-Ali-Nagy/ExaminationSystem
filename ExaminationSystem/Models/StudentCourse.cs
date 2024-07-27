using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Models
{
    public class StudentCourse:BaseModel
    {
        [ForeignKey("Course")]
        public int CourseID { get; set; }
        public Course Course { get; set; }

        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public Student Student { get; set; }
    }
}
