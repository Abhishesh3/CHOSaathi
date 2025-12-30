using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System.Threading.Tasks;

namespace CHO_Saathi.Middlewares
{

    public class SecurityHeadersMiddleware
    {
        private readonly RequestDelegate _next;

        public SecurityHeadersMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Method == HttpMethods.Options)
            {
                //context.Response.Headers.Add("Allow", "GET,POST");
                context.Response.StatusCode = StatusCodes.Status405MethodNotAllowed;
                return;
            }
            context.Response.OnStarting(() =>
            {
                context.Response.Headers.Add("Clear-Site-Data", "*");
                return Task.CompletedTask;
            });
            context.Response.Headers.Append("referrer-policy", new StringValues("strict-origin-when-cross-origin"));
            context.Response.Headers.Append("x-content-type-options", new StringValues("nosniff"));
            context.Response.Headers.Append("x-frame-options", new StringValues("DENY"));
            context.Response.Headers.Append("X-Permitted-Cross-Domain-Policies", new StringValues("none"));
            context.Response.Headers.Append("x-xss-protection", new StringValues("1; mode=block"));
            context.Response.Headers.Append("Expect-CT", new StringValues("max-age=0, enforce, report-uri=\"https://example.report-uri.com/r/d/ct/enforce\""));
            context.Response.Headers.Append("Feature-Policy", new StringValues(
                "accelerometer 'none';" +
                "ambient-light-sensor 'none';" +
                "autoplay 'none';" +
                "battery 'none';" +
                "camera 'none';" +
                "display-capture 'none';" +
                "document-domain 'none';" +
                "encrypted-media 'none';" +
                "execution-while-not-rendered 'none';" +
                "execution-while-out-of-viewport 'none';" +
                "gyroscope 'none';" +
                "magnetometer 'none';" +
                "microphone 'none';" +
                "midi 'none';" +
                "navigation-override 'none';" +
                "payment 'none';" +
                "picture-in-picture 'none';" +
                "publickey-credentials-get 'none';" +
                "sync-xhr 'none';" +
                "usb 'none';" +
                "wake-lock 'none';" +
                "xr-spatial-tracking 'none';"
            ));
            await _next(context);
        }
    }
}