using ExaminationSystem.Data.Enums;
using ExaminationSystem.Exceptions;
using ExaminationSystem.Models;
using ExaminationSystem.Repository;

namespace ExaminationSystem.Services.Exams
{
    public class ExamService:IExamService
    {
        IRepository<Exam> _repository;
        public ExamService(IRepository<Exam> repository)
        {
            _repository = repository;
        }
        public Exam Get(int id)
        {
           return _repository.GetById(id);
        }
        public IEnumerable<Exam> GetAll()
        {
            return _repository.GetAll();
        }
        public Exam Add(Exam exam)
        {
            return _repository.Add(exam);
        }

        public void Delete(int id)
        {
            Exam exam= _repository.GetById(id);
            if (exam == null)
            {
                throw new BusinessException("Can not find exam with that ID", ErrorCode.ExamIDNotFound);
            }
            _repository.Delete(exam);
            _repository.SaveChanges();
        }
    }
}
