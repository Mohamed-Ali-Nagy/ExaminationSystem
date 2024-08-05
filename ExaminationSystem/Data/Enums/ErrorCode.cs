namespace ExaminationSystem.Data.Enums
{
    public enum ErrorCode
    {
        NoError = 0,
        UnKnown=1,
        //course 1000:2000
        CourseIDNotFound=1000,

        //Exam 2000:3000
        ExamIDNotFound=2000,

        //question 3000:4000
        NumberOfChoicesNotCorrect=3000,
        OneOfChoicesMustBeCorrect=3001,
        InvalidQuestionID=3002,


    }
}
