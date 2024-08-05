namespace ExaminationSystem.ViewModels.Course
{
    public class CourseResponseVM
    {
        public int ID { get; set; }
        public int CreditHours { get; set; }
        public string Name { get; set; }

        public int InstructorID { get; set; }
        public string InstructorName { get; set; }
    }
}
