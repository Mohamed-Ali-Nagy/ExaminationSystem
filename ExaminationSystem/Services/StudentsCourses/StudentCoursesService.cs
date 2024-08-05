using ExaminationSystem.Models;
using ExaminationSystem.Repository;

namespace ExaminationSystem.Services.StudentsCourses
{
    public class StudentCoursesService : IStudentCoursesService
    {
        private readonly IRepository<StudentCourse> _studentCoursesRepository;
        public StudentCoursesService(IRepository<StudentCourse> repository)
        {
            _studentCoursesRepository = repository;
        }
        public IEnumerable<StudentCourse> GetStudentCoursesByCourseID(int courseID)
        {
           return _studentCoursesRepository.GetAll(sc=>sc.CourseID==courseID);
        }

        public IEnumerable<StudentCourse> GetStudentCoursesByStudentID(int studentID)
        {
            return _studentCoursesRepository.GetAll(sc => sc.CourseID == studentID);
        }
        public void DeleteRangeByCourseID(int courseID)
        {
            var entities= _studentCoursesRepository.GetAll(sc=>sc.ID==courseID);
            _studentCoursesRepository.DeleteRange(entities);
        }
    }
}
