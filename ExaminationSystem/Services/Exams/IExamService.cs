using ExaminationSystem.DTOs.ExamDTOs;

namespace ExaminationSystem.Services.Exams
{
    public interface IExamService
    {
        public int Add(ExamRequestDTO examRequestDTO);
        public ExamResponseDTO Update(ExamUpdateDTO examUpdateDTO);
        public void Delete(int id);
    }
}
