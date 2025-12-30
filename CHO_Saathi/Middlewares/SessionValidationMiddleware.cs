using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CHO_Saathi.Middlewares
{
    public class SessionValidationMiddleware
    {
        private readonly RequestDelegate _next;
        public SessionValidationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.User.Identity.IsAuthenticated)
            {
                var sessionUserId = context.Session.GetString("UserId");

                if (string.IsNullOrEmpty(sessionUserId))
                {
                    await context.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                    context.Response.Redirect("/Home/Index");
                    return;
                }
            }

            await _next(context);
        }
    }
}
