using AutoMapper;
using ExaminationSystem.DTOs.ExamDTOs;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.ExamsVMs;

namespace ExaminationSystem.Profiles
{
    public class ExamProfile:Profile
    {
        public ExamProfile()
        {
            CreateMap<ExamRequestDTO,Exam>().ReverseMap();
            CreateMap<ExamRequestVM,ExamRequestDTO>().ReverseMap();
            CreateMap<Exam,ExamResponseDTO>();
            CreateMap<ExamUpdateDTO, Exam>();
            CreateMap<Exam, ExamResponseDTO>();
            CreateMap<ExamUpdateVM,ExamUpdateDTO>();
        }
    }
}
