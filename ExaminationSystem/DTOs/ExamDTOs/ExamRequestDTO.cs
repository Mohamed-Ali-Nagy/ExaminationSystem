using ExaminationSystem.Data.Enums;
using ExaminationSystem.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.DTOs.ExamDTOs
{
    public class ExamRequestDTO
    {
        public ExamType ExamType { get; set; }
        public int TotalGrade { get; set; }
        public int InstructorID { get; set; }
        public int CourseID { get; set; }
    }
}
