using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CHO_Saathi.Models;
using System;
using System.Threading.Tasks;

namespace CHO_Saathi.Middlewares
{
    public class ActiveUserMiddleware
    {
        private readonly RequestDelegate _next;

        public ActiveUserMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var path = context.Request.Path.Value;

            //path.Equals("/Account/Login", StringComparison.OrdinalIgnoreCase) ||
            //path.Equals("/Account/Register", StringComparison.OrdinalIgnoreCase) ||
            //path.Equals("/Account/ForgotPassword", StringComparison.OrdinalIgnoreCase))

            // Bypass middleware for specific paths to prevent redirect loop
            if (path.Equals("/Home/Index", StringComparison.OrdinalIgnoreCase))
            {
                await _next(context);
                return;
            }

            int userID;
            bool isUserIDParsed = int.TryParse(context.Session.GetString("UserId"), out userID);

            if (isUserIDParsed && userID != 0)
            {
                using (var scope = context.RequestServices.CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDBContext>();

                    bool isActive = await IsUserActiveAsync(userID, dbContext);

                    if (!isActive)
                    {
                        context.Response.Redirect("/Home/Index");
                        return;
                    }
                }
            }

            await _next(context);
        }

        private async Task<bool> IsUserActiveAsync(int userID, ApplicationDBContext dbContext)
        {
            var user = await dbContext.Users
                .FirstOrDefaultAsync(m => m.UserId == userID && m.IsDeleted == 0 && m.IsActive == true);
            return user != null;
        }
    }
}