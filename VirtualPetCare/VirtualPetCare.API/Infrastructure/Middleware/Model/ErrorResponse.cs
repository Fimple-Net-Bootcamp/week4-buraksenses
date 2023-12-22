namespace VirtualPetCare.API.Infrastructure.Middleware.Model;

public class ErrorResponse
{
    public string Error { get; set; }
    public string? StackTrace { get; set; }
}