using ExaminationSystem.DTOs.QuestionDTOs;

namespace ExaminationSystem.Services.Questions
{
    public interface IQuestionService
    {
        public QuestionResponseDTO Add(QuestionRequestDTO questionRequestDTO);
        public QuestionResponseDTO Delete(int id);
        public QuestionResponseDTO Update(QuestionUpdateDTO questionUpdateDTO);
        public QuestionResponseDTO Get(int id);
    }
}
