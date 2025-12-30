using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CHO_Saathi.Middlewares
{
    public class ContentSecurityPolicyMiddleware
    {
        private readonly RequestDelegate _next;

        public ContentSecurityPolicyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        //public async Task Invoke(HttpContext context)
        //{
        //    context.Response.Headers.Append("Content-Security-Policy",
        //                                    "default-src 'self'; " +
        //                                    "style-src 'self' 'unsafe-inline' https://cdnjs.cloudflare.com/ajax/libs/jstree/3.2.1/themes/default/style.min.css https://cdnjs.cloudflare.com/ajax/libs/jstree/3.2.1/jstree.min.js; " +
        //                                    "script-src 'self' 'unsafe-inline' 'unsafe-eval'; " +
        //                                    "font-src 'self'; " +
        //                                    "frame-src 'self' https://www.youtube.com/; " +
        //                                    "img-src 'self' data:;");

        //    await _next(context);
        //}

        public async Task Invoke(HttpContext context)
        {
            // Updated CSP allowing the required resources
            context.Response.Headers.Append("Content-Security-Policy",
                                            "default-src 'self'; " +
                                            "style-src 'self' 'unsafe-inline' https://cdnjs.cloudflare.com/ajax/libs/jstree/3.2.1/themes/default/style.min.css; " +
                                            "script-src 'self' 'unsafe-inline' 'unsafe-eval' https://cdnjs.cloudflare.com/ajax/libs/jstree/3.2.1/jstree.min.js; " +
                                            "font-src 'self'; " +
                                            "frame-src 'self' https://www.youtube.com/; " +
                                            "img-src 'self' data: https://cdnjs.cloudflare.com;");

            await _next(context);
        }
    }

    public static class ContentSecurityPolicyMiddlewareExtensions
    {
        public static IApplicationBuilder UseContentSecurityPolicy(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ContentSecurityPolicyMiddleware>();
        }
    }
}

