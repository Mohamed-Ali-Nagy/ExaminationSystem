using ExaminationSystem.Data.Enums;
using ExaminationSystem.DTOs.ExamDTOs;
using ExaminationSystem.Exceptions;
using ExaminationSystem.Helpers;
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
        //public Exam Get(int id)
        //{
        //   return _repository.GetById(id);
        //}
        //public IEnumerable<Exam> GetAll()
        //{
        //    return _repository.GetAll();
        //}
        public int Add(ExamRequestDTO examRequestDTO)
        {
            var exam = _repository.Add(examRequestDTO.MapOne<Exam>());
            //var exam2=exam.MapOne<ExamResponseDTO>();
            _repository.SaveChanges();
            return exam.ID;
        }
        public ExamResponseDTO Update(ExamUpdateDTO examUpdateDTO)
        {
            var exam=_repository.Update(examUpdateDTO.MapOne<Exam>());
            _repository.SaveChanges();
            return exam.MapOne<ExamResponseDTO>();
        }
        public void Delete(int id)
        {
            Exam exam = _repository.GetById(id);
            if (exam == null)
            {
                throw new BusinessException("Can not find exam with that ID", ErrorCode.ExamIDNotFound);
            }
            _repository.Delete(exam);
            _repository.SaveChanges();
        }
    }
}
