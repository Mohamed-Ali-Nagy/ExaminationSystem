using ExaminationSystem.DTOs.ChoiceDTOs;
using ExaminationSystem.DTOs.QuestionDTOs;
using ExaminationSystem.Helpers;
using ExaminationSystem.Models;
using ExaminationSystem.Services.Choices;
using ExaminationSystem.Services.Questions;
using ExaminationSystem.ViewModels;
using ExaminationSystem.ViewModels.QuestionsVMs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;
        private readonly IChoiceService _choiceService;
        
        public QuestionController(IQuestionService questionService,IChoiceService choiceService )
        {
            _questionService = questionService;
            _choiceService = choiceService;
        }
        [HttpPost("Add")]
        public IActionResult Add(QuestionRequestVM questionRequestVM)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
           var question= _questionService.Add(questionRequestVM.MapOne<QuestionRequestDTO>());
           var choices = questionRequestVM.ChoicesVM.Select(vm =>  vm.MapOne<ChoiceRequestDTO>()).ToList();
            foreach(var choice in choices)
            {
                choice.QuestionID = question.ID;
            }
            _choiceService.AddRang(choices);
            return Ok(ResultVM<QuestionResponseVM>.Success(question.MapOne<QuestionResponseVM>(),""));
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            _choiceService.DeleteByQuestionID(id);
           QuestionResponseDTO questionDTO= _questionService.Delete(id);
            return Ok(ResultVM<QuestionResponseVM>.Success(questionDTO.MapOne<QuestionResponseVM>(), ""));


        }

        [HttpPut("Update")]
        public IActionResult Update(QuestionRequestVM questionRequestVM)
        {

        }
    }
}
