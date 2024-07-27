using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Models
{
    public class StudentExam:BaseModel
    {
        [ForeignKey("Exam")]
        public int ExamID { get; set; }
        public Exam Exam { get; set; }

        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public Student Student { get; set; }
    }
}
