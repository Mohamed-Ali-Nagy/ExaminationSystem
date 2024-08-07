using ExaminationSystem.DTOs.ExamDTOs;

namespace ExaminationSystem.Services.Exams
{
    public interface IExamService
    {
        public int Add(ExamRequestDTO examRequestDTO);
    }
}
