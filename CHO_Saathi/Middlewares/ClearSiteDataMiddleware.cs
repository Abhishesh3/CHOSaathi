using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace CHO_Saathi.Middlewares
{
    public class ClearSiteDataMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ClearSiteDataMiddleware> _logger;


        public ClearSiteDataMiddleware(RequestDelegate next, ILogger<ClearSiteDataMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            _logger.LogInformation("Executing ClearSiteDataMiddleware for request: " + context.Request.Path);

            context.Response.OnStarting(() =>
            {
                _logger.LogInformation("Adding Clear-Site-Data header");
                context.Response.Headers.Add("Clear-Site-Data", "\"cache\", \"cookies\", \"storage\", \"executionContexts\"");
                return Task.CompletedTask;
            });

            await _next(context);
        }

    }
}
