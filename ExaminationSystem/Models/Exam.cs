using ExaminationSystem.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Models
{
    public class Exam : BaseModel
    {
        public ExamType  ExamType { get; set; }
        public int TotalGrade { get; set; }
        [ForeignKey("Instructor")]
        public int InstructorID { get; set; }
        public Instructor Instructor { get; set; }
        [ForeignKey("Course")]
        public int CourseID { get; set; }
        public Course Course { get; set; }
        public HashSet<ExamQuestion> ExamQuestions { get; set; } = new HashSet<ExamQuestion>();
        public HashSet<StudentExam> StudentExams { get; set; }
        



    }
}
