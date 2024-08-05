namespace ExaminationSystem.DTOs.ChoiceDTOs
{
    public class ChoiceRequestDTO
    {
        public string Text { get; set; }
        public bool IsRightAnswer { get; set; }
        public int QuestionID { get; set; }
    }
}
