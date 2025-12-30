using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;


namespace CHO_Saathi.Middlewares
{
    public class ExceptionHandlerMiddleware(RequestDelegate next)
    {
        public async Task Invoke(HttpContext context)
        {
            var originalPath = context.Request.Path;

            var decodedPath = Uri.UnescapeDataString(originalPath);

            context.Request.Path = decodedPath;

            await next(context);

            var requestCode = context.Response.StatusCode;

            if (requestCode is 400 or 403 or 404 or 405 or 408 or 408 or 500 or 502)
            {
                await ErrorHandling(context, requestCode);
            }
        }

        private static async Task ErrorHandling(HttpContext context, int httpErrorCode)
        {
            switch (httpErrorCode)
            {
                case 400:
                    context.Response.Redirect("/Handler/BadRequestView");
                    break;
                case 403:
                    context.Response.Redirect("/Handler/Forbidden");
                    break;
                case 404:
                    context.Response.Redirect("/Handler/NotFoundView");
                    break;
                case 405:
                    context.Items["Error"] = "A request method is not supported for the requested resource";
                    break;
                case 408:
                    context.Items["Error"] = "The client did not produce a request within the time that the server was prepared to wait.";
                    break;
                case 500:
                    context.Items["Error"] = "An internal error has occurred in the server side";
                    break;
                case 502:
                    context.Items["Error"] = "The server was acting as a gateway or proxy and received an invalid response from the upstream server";
                    break;
            }

            if (!context.Response.HasStarted)
            {
                await context.Response.WriteAsync(context.Items["Error"]?.ToString() ?? "Internal Server Error.");
            }
        }
    }
}