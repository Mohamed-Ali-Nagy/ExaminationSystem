namespace ExaminationSystem.DTOs.ChoiceDTOs
{
    public class ChoiceResponseDTO
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public bool IsRightAnswer { get; set; }
        public int QuestionID { get; set; }
    }
}
