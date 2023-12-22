using System.Net;
using VirtualPetCare.API.Infrastructure.Middleware.Model;

namespace VirtualPetCare.API.Infrastructure.Middleware;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IWebHostEnvironment _environment;
    private readonly ILogger<ExceptionMiddleware> _logger;

    public ExceptionMiddleware(RequestDelegate next,IWebHostEnvironment environment,ILogger<ExceptionMiddleware> logger)
    {
        _next = next;
        _environment = environment;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An unhandled exception has occurred.");
            
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var response = new ErrorResponse
            {
                Error = _environment.IsDevelopment() ? ex.Message : "An error occurred. Please try again later.",
                StackTrace = _environment.IsDevelopment() ? ex.StackTrace : null
            };

            var jsonResponse = System.Text.Json.JsonSerializer.Serialize(response);
            await httpContext.Response.WriteAsync(jsonResponse);
        }
    }
}