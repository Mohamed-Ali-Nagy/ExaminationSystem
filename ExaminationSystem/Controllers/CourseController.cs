using ExaminationSystem.Data.Enums;
using ExaminationSystem.DTOs.CourseDTOs;
using ExaminationSystem.Helpers;
using ExaminationSystem.Services.Courses;
using ExaminationSystem.ViewModels;
using ExaminationSystem.ViewModels.Course;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [HttpGet("Get")]
        public IActionResult Get(int ID)
        {
          var course=_courseService.GetByID(ID).MapOne<CourseResponseVM>();
           if (course == null)
            {
                return NotFound("The Course with this id dose not exist");
            }
          return Ok(ResultVM<CourseResponseVM>.Success(course,""));
        }

        [HttpPost("Add")]
        public IActionResult Add(CourseAddVM courseAddVM)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var courseDTO = _courseService.Add(courseAddVM.MapOne<CourseDTO>());//.MapOne<CourseResponseVM>();
            return Ok(ResultVM<CourseResponseVM>.Success(courseDTO.MapOne<CourseResponseVM>(), ""));

        }

        [HttpDelete("Delete")]
        public IActionResult Delete(int ID)
        {
            _courseService.Delete(ID);
            return Ok(ResultVM<bool>.Success(true,"Course deleted successfully"));
        }

        [HttpPut("Update")]
        public IActionResult Update(CourseUpdateVM courseUpdateVM)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
          var course=  _courseService.Update(courseUpdateVM.MapOne<CourseDTO>());
            return Ok(ResultVM<CourseResponseVM>.Success(course.MapOne<CourseResponseVM>(), ""));  
        }
    }
}
