using ExaminationSystem.Data;

namespace ExaminationSystem.Middlewares
{
    public class TransactionMiddleware
    {
        private RequestDelegate _next;
        private readonly Context _context;
        public TransactionMiddleware(RequestDelegate next,Context context)
        {
            _next = next;
            _context = context;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {

            //var requestMethod=httpContext.Request.Method.ToUpper();
            //if (requestMethod == "GET")
            //{
            //    await _next(httpContext);
            //}

            //var transaction = _context.Database.BeginTransaction();
            //try
            //{
            //    await _next(httpContext);
            //    transaction.Commit();
            //}
            //catch (Exception ex)
            //{
            //    transaction?.Rollback();
            //    throw;
            //}
            var method = httpContext.Request.Method.ToUpper();
            if (method == "POST" || method == "PUT" || method == "DELETE")
            {
                var transaction = _context.Database.BeginTransaction();

                try
                {
                    await _next(httpContext);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction?.Rollback();
                    throw;
                }
            }
            else
            {
                await _next(httpContext);
            }
        }
    }
}
