using ExaminationSystem.DTOs.ExamsQuestions;

namespace ExaminationSystem.Services.ExamsQuestions
{
    public interface IExamsQuestionsService
    {
        public IEnumerable<ExamsQuestionsDTO> GetExamsQuestionsByQuestionID(int questionID);
        public IEnumerable<ExamsQuestionsDTO> GetExamsQuestionsByExamID(int ExamID);
        public void Add(ExamsQuestionsDTO examsQuestionsDTO);
        public void AddRange(List<ExamsQuestionsDTO> examsQuestions);
        public void DeleteQuestionID(int questionID);
        public void DeleteExamID(int ExamID);
    }
}
