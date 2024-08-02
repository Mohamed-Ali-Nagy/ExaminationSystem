using ExaminationSystem.Data.Enums;
using ExaminationSystem.DTOs;
using ExaminationSystem.Exceptions;
using ExaminationSystem.Helpers;
using ExaminationSystem.Models;
using ExaminationSystem.Repository;

namespace ExaminationSystem.Services.Courses
{
    public class CourseService : ICourseService
    {
        private readonly IRepository<Course> _courseRepository;
        public CourseService(IRepository<Course> courseRepository)
        {
            _courseRepository = courseRepository;
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
