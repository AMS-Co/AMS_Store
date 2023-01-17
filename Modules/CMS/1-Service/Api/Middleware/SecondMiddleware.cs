namespace Api.Middleware
{
    public class SecondMiddleware
    {
        private readonly RequestDelegate _next;

        public SecondMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            await context.Response.WriteAsync("Seccond Middleware Executing. \n");
            await _next(context);
            await context.Response.WriteAsync("Seccond Middleware Executed. \n");
        }
    }
}
