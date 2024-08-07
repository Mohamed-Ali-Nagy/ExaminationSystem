using AutoMapper;
using ExaminationSystem.DTOs.ExamsQuestions;
using ExaminationSystem.Models;

namespace ExaminationSystem.Profiles
{
    public class ExamQuestionProfile:Profile
    {
        public ExamQuestionProfile()
        {
            CreateMap<ExamQuestion,ExamsQuestionsDTO>().ReverseMap();
        }
    }
}
