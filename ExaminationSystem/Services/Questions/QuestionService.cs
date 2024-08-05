using ExaminationSystem.Data.Enums;
using ExaminationSystem.DTOs.QuestionDTOs;
using ExaminationSystem.Exceptions;
using ExaminationSystem.Helpers;
using ExaminationSystem.Models;
using ExaminationSystem.Repository;

namespace ExaminationSystem.Services.Questions
{
    public class QuestionService : IQuestionService
    {
        private readonly IRepository<Question> _repository;
        public QuestionService(IRepository<Question> repository)
        {
            _repository = repository;
        }
        public QuestionResponseDTO Add(QuestionRequestDTO questionRequestDTO)
        {
           var question= _repository.Add(questionRequestDTO.MapOne<Question>());
            _repository.SaveChanges();
            return question.MapOne<QuestionResponseDTO>();  
        }

        public QuestionResponseDTO Delete(int id)
        {
           Question question= _repository.GetById(id);
            if(question == null)
            {
                throw new BusinessException("Invalid question id", ErrorCode.InvalidQuestionID);
            }
            _repository.Delete(question);
            _repository.SaveChanges();
            return question.MapOne<QuestionResponseDTO>();
        }
    }
}
