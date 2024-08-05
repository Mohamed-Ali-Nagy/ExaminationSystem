using ExaminationSystem.Data.Enums;
using ExaminationSystem.DTOs.CourseDTOs;
using ExaminationSystem.Exceptions;
using ExaminationSystem.Helpers;
using ExaminationSystem.Models;
using ExaminationSystem.Repository;
using ExaminationSystem.Services.StudentsCourses;

namespace ExaminationSystem.Services.Courses
{
    public class CourseService : ICourseService
    {
        private readonly IRepository<Course> _courseRepository;
        private readonly IStudentCoursesService _studentCoursesService;
        public CourseService(IRepository<Course> courseRepository,IStudentCoursesService studentCoursesService)
        {
            _courseRepository = courseRepository;
            _studentCoursesService = studentCoursesService;
        }

        public CourseDTO Add(CourseDTO courseDTO)
        {
            Course course = courseDTO.MapOne<Course>();
            Course cours = _courseRepository.Add(course);
            _courseRepository.SaveChanges();
            return cours.MapOne<CourseDTO>();
        }

        public CourseDTO GetByID(int id)
        {
          return _courseRepository.GetById(id,"Instructor").MapOne<CourseDTO>();
        }
        public void Delete(int ID)
        {
            var course = _courseRepository.GetById(ID);
            if(course == null)
            {
                throw new BusinessException("Can not find course with that ID",ErrorCode.CourseIDNotFound);
            }
            _courseRepository.Delete(course);
            _studentCoursesService.DeleteRangeByCourseID(course.ID);
            _courseRepository.SaveChanges();
        }

        public CourseDTO Update(CourseDTO courseDTO)
        {
           
            Course course=_courseRepository.Update(courseDTO.MapOne<Course>());
            _courseRepository.SaveChanges();
            return course.MapOne<CourseDTO>();
        }
    }
}
