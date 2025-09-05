using Microsoft.AspNetCore.Http;
using System.Net;
using System.Text.Json;

namespace InvoiceApi
{
    public class ExceptionMiddleWare
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleWare> _logger;

        public ExceptionMiddleWare(RequestDelegate next, ILogger<ExceptionMiddleWare> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context); // ادامه‌ی pipeline
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "خطایی رخ داده"); // ذخیره در لاگ
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = exception switch
            {
                ArgumentException => StatusCodes.Status400BadRequest,
                KeyNotFoundException => StatusCodes.Status404NotFound,
            };
            var result = JsonSerializer.Serialize(new
            {
                StatusCode = context.Response.StatusCode,
                Message = exception switch
                {
                    ArgumentException => "Intenal Error",
                    KeyNotFoundException => "Argument not found!",

                }
            });


            return context.Response.WriteAsync(result);
        }
    }
}
