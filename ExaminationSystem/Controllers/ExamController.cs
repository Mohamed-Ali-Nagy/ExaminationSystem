using ExaminationSystem.DTOs.ExamDTOs;
using ExaminationSystem.DTOs.ExamsQuestions;
using ExaminationSystem.Helpers;
using ExaminationSystem.Services.Exams;
using ExaminationSystem.Services.ExamsQuestions;
using ExaminationSystem.ViewModels;
using ExaminationSystem.ViewModels.ExamsVMs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly IExamService _examService;
        private readonly IExamsQuestionsService _examsQuestionsService;
        public ExamController(IExamService examService,IExamsQuestionsService examsQuestionsService)
        {
            _examService = examService;
            _examsQuestionsService = examsQuestionsService;
        }
        [HttpPost("Add")]
        public IActionResult Add(ExamRequestVM examRequestVM)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
           var examID= _examService.Add(examRequestVM.MapOne<ExamRequestDTO>());
           var questionExamsList = examRequestVM.Questions.Select
                                   (q => new ExamsQuestionsDTO { ExamID = examID, QuestionID = q }).ToList();
            _examsQuestionsService.AddRange(questionExamsList);
            return Ok(ResultVM<int>.Success(examID, ""));
        }

    }
}
