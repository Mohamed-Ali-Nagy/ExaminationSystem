using AutoMapper;
using ExaminationSystem.DTOs.QuestionDTOs;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.QuestionsVMs;

namespace ExaminationSystem.Profiles
{
    public class QuestionProfile:Profile
    {
        public QuestionProfile()
        {
            CreateMap<QuestionRequestVM, QuestionRequestDTO>();
            CreateMap<QuestionRequestDTO, Question>();
            CreateMap<Question,QuestionResponseDTO>();
            CreateMap<QuestionResponseDTO, Question>().ReverseMap();
            CreateMap<QuestionResponseDTO, QuestionResponseVM>();


        }
    }
}
