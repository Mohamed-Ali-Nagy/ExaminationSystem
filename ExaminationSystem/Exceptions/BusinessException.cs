using ExaminationSystem.Data.Enums;

namespace ExaminationSystem.Exceptions
{
    public class BusinessException:Exception
    {
        public ErrorCode ErrorCode;
        public BusinessException(string message,ErrorCode errorCode):base(message)
        {
            ErrorCode = errorCode;
        }
    }
}
