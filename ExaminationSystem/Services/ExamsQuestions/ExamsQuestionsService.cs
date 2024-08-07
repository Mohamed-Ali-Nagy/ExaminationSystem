using ExaminationSystem.DTOs.ExamsQuestions;
using ExaminationSystem.Helpers;
using ExaminationSystem.Models;
using ExaminationSystem.Repository;

namespace ExaminationSystem.Services.ExamsQuestions
{
    public class ExamsQuestionsService : IExamsQuestionsService
    {
        private readonly IRepository<ExamQuestion> _repository;
        public ExamsQuestionsService(IRepository<ExamQuestion> repository)
        {
            _repository = repository;
        }
        public void Add(ExamsQuestionsDTO examsQuestionsDTO)
        {
            _repository.Add(examsQuestionsDTO.MapOne<ExamQuestion>());  
            _repository.SaveChanges();
        }
        public void AddRange(List<ExamsQuestionsDTO> examsQuestions)
        {
            _repository.AddRange(examsQuestions.Select(e=>new ExamQuestion 
                                                      { ExamID=e.ExamID,QuestionID=e.QuestionID}).ToList());
            _repository.SaveChanges();
        }
        public IEnumerable<ExamsQuestionsDTO> GetExamsQuestionsByExamID(int examID)
        {
            return _repository.GetAll(e => e.ExamID == examID).Map<ExamsQuestionsDTO>();
        }

        public IEnumerable<ExamsQuestionsDTO> GetExamsQuestionsByQuestionID(int questionID)
        {
            return _repository.GetAll(q => q.QuestionID == questionID).Map<ExamsQuestionsDTO>();

        }

        public void DeleteQuestionID(int questionID)
        {
            var examsQuestions = _repository.GetAll(q=>q.QuestionID== questionID);
            _repository.DeleteRange(examsQuestions);
            _repository.SaveChanges();
        }
        public void DeleteExamID(int examID)
        {
            var examsQuestions=_repository.GetAll(e=>e.ExamID== examID);    
            _repository.DeleteRange(examsQuestions);
            _repository.SaveChanges();
        }

    }
}
