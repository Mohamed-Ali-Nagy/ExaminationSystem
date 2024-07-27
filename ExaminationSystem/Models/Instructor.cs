namespace ExaminationSystem.Models
{
    public class Instructor:BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public HashSet<Exam> Exams { get; set; }
        public HashSet<Course> Courses { get; set; }


    }
}
