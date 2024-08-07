using ExaminationSystem.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.DTOs.ExamsQuestions
{
    public class ExamsQuestionsDTO
    {
        public int ExamID { get; set; }
        public int QuestionID { get; set; }
    }
}
