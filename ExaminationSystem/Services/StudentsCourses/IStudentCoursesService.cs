using ExaminationSystem.Models;

namespace ExaminationSystem.Services.StudentsCourses
{
    public interface IStudentCoursesService
    {
        public IEnumerable<StudentCourse> GetStudentCoursesByCourseID(int courseID);
        public IEnumerable<StudentCourse> GetStudentCoursesByStudentID(int studentID);
        public void DeleteRangeByCourseID(int courseID);
    }
}
