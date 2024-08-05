using ExaminationSystem.DTOs.ChoiceDTOs;
using ExaminationSystem.DTOs.QuestionDTOs;

namespace ExaminationSystem.Services.Choices
{
    public interface IChoiceService
    {
        public bool AddRang(List<ChoiceRequestDTO> entities);
        public bool DeleteByQuestionID(int questionID);
    }
}
