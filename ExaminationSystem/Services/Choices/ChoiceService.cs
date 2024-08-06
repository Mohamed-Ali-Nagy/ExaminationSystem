using ExaminationSystem.Data.Enums;
using ExaminationSystem.DTOs.ChoiceDTOs;
using ExaminationSystem.Exceptions;
using ExaminationSystem.Helpers;
using ExaminationSystem.Models;
using ExaminationSystem.Repository;

namespace ExaminationSystem.Services.Choices
{
    public class ChoiceService:IChoiceService
    {
        private readonly IRepository<Choice> _repository;
        public ChoiceService(IRepository<Choice> repository)
        {
            _repository = repository;
        }
        public IEnumerable<ChoiceResponseDTO> GetChoicesByQuestionID(int questionID)
        {
           return _repository.GetAll(ch=>ch.QuestionID == questionID).Map<ChoiceResponseDTO>();
        }
        public bool AddRang(List<ChoiceRequestDTO> entities)
        {
            if(entities.Count > 4||entities.Count<2)
            {
                throw new BusinessException("Choices must be between 2 and 4", ErrorCode.NumberOfChoicesNotCorrect);
            }
            bool haveCorrect=false;
            foreach(ChoiceRequestDTO choice in entities)
            {
                if(choice.IsRightAnswer)
                {
                    haveCorrect=true;
                }
                _repository.Add(choice.MapOne<Choice>());
            }
            if(haveCorrect)
            {
                _repository.SaveChanges();
                return true;
            }
            else
            {
                throw new BusinessException("Question must have a correct choice",ErrorCode.OneOfChoicesMustBeCorrect);
            }
        }

        public bool DeleteByQuestionID(int questionID)
        {
            var choices = _repository.GetAll(ch => ch.QuestionID == questionID);
            if (choices == null)
                throw new BusinessException("Invalid Question Id", ErrorCode.InvalidQuestionID);

            _repository.DeleteRange(choices);
            _repository.SaveChanges(); 
            return true;
        }

        public bool UpdateChoicesByQuestion(List<ChoiceResponseDTO> choicesUpdateDTO)
        {
           foreach(ChoiceResponseDTO choiceUpdate in choicesUpdateDTO)
           {
                var c=choiceUpdate.MapOne<Choice>();
               _repository.Update(choiceUpdate.MapOne<Choice>());

           }

           _repository.SaveChanges() ;  
            return true;
        }


    }
}
