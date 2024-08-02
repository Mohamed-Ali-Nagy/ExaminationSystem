using ExaminationSystem.DTOs;
using ExaminationSystem.Models;

namespace ExaminationSystem.Services.Courses
{
    public interface ICourseService
    {
        public CourseDTO GetByID(int id);
        public CourseDTO Add(CourseDTO courseDTO);
        public void Delete(int ID);
        public CourseDTO Update(CourseDTO courseDTO);
    }
}
