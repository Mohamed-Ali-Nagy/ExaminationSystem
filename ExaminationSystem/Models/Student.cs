namespace ExaminationSystem.Models
{
    public class Student : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public HashSet<StudentCourse> StudentCourses { get; set; }
        public HashSet<StudentExam> StudentExams { get; set; }
    }
}
