using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Models
{
    public class Exam : BaseModel
    {
        public DateTime StartDate { get; set; }
        public int TotalGrade { get; set; }
        [ForeignKey("Instructor")]
        public int InstructorID { get; set; }
        public Instructor Instructor { get; set; }
        public HashSet<ExamQuestion> ExamQuestions { get; set; } = new HashSet<ExamQuestion>();
        public HashSet<StudentExam> StudentExams { get; set; }



    }
}
