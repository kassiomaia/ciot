using Ciot.Core.Entities;
using Ciot.Core.Services;

namespace Ciot.Web.Endpoints.Auth;

internal sealed class Login(IAuthService authService)
{
    private record LoginRequest(string Email, string Password);

    private async Task<IResult> HandleAsync(LoginRequest request)
    {
        var result = await authService.AuthenticateAsync(request.Email, request.Password);
        if (result.IsFailure)
        {
            var json = new
            {
                message = result.Error,
            };
            return Results.Json(json, statusCode: StatusCodes.Status401Unauthorized);
        }

        var user = result.Success;
        return Results.Ok(new
        {
            user
        });
    }

    internal static void Map(IEndpointRouteBuilder app)
    {
        app.MapPost("/api/v1/auth/login",
                async (Login login, LoginRequest request) => await login.HandleAsync(request))
            .WithName("Login")
            .Produces<User?>()
            .Produces(StatusCodes.Status401Unauthorized);
    }
}