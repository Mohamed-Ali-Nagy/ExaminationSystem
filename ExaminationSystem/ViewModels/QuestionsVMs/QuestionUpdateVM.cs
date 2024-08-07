﻿using ExaminationSystem.Data.Enums;
using ExaminationSystem.ViewModels.ChoicesVMs;
using System.ComponentModel.DataAnnotations;

namespace ExaminationSystem.ViewModels.QuestionsVMs
{
    public class QuestionUpdateVM
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public int Grade { get; set; }
        [Required]
        public QuestionLevel Level { get; set; }
        [Required]
        public int InstructorID { get; set; }
        [Required]
        public List<ChoiceUpdateVM> ChoicesVM { get; set; }
    }
}
