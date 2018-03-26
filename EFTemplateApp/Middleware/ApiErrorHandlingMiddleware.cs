using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTemplateApp.Middleware
{
    public class ApiErrorHandlingMiddleware
    {
        private RequestDelegate next;

        public ApiErrorHandlingMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context, ILogger<ApiErrorHandlingMiddleware> logger)
        {
            try
            {
                await next(context);
                if (context.Response.StatusCode >= 400)
                {
                    await HandleExceptionAsync(context);
                }
            }
            catch (Exception ex)
            {
                //logger.Log(LogLevel.Error, ex.ToString());
                await HandleExceptionAsync(context, true);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, bool isUnhandled = false)
        {
            if (context.Response.HasStarted)
            {
                //response already written earlier in the pipeline
                return Task.CompletedTask;
            }

            return context.Response.WriteAsync("whatever you need to return");
        }
    }
}
