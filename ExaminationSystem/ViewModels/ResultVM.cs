using ExaminationSystem.Data.Enums;

namespace ExaminationSystem.ViewModels
{
    public class ResultVM<T>
    {
        public bool Succeded { get; set; }
        public ErrorCode ErrorCode { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public static ResultVM<T> Success(T data, string message = "")
        {
            return new ResultVM<T> { Succeded = true, Data = data, Message = message, ErrorCode = ErrorCode.NoError };
        }

        public static ResultVM<T> Failure(ErrorCode error,string message)
        {
            return new ResultVM<T> { ErrorCode = error, Message = message ,Succeded=false,Data=default};
        }
    }
}
