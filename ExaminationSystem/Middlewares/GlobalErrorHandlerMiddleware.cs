using ExaminationSystem.Data;
using ExaminationSystem.Data.Enums;
using ExaminationSystem.ViewModels;

namespace ExaminationSystem.Middlewares
{
    public class GlobalErrorHandlerMiddleware
    {
        private RequestDelegate _next;
        public GlobalErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }catch (Exception ex)
            {
                var result= ResultVM<bool>.Failure(ErrorCode.UnKnown,ex.Message);
               await context.Response.WriteAsJsonAsync(result);
            }
        }
    }
}
