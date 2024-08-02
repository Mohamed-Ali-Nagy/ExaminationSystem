using AutoMapper;
using ExaminationSystem.DTOs;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels;

namespace ExaminationSystem.Profiles
{
    public class CourseProfile:Profile
    {
        public CourseProfile()
        {
            CreateMap<Course, CourseDTO>().ForMember(dst => dst.InstructorName, opt => opt.MapFrom(srs => srs.Instructor.FirstName));
            CreateMap<CourseDTO,Course>();
            CreateMap<CourseUpdateVM,CourseDTO>();
            CreateMap<CourseDTO, CourseResponseVM>().ForMember(dst => dst.InstructorName, opt => opt.MapFrom(srs => srs.InstructorName));
            CreateMap<CourseAddVM, CourseDTO>();
        }
    }
}
