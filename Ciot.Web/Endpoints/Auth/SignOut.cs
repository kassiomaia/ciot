using Microsoft.AspNetCore.Authentication;

namespace Ciot.Web.Endpoints.Auth;

internal sealed class SignOut
{
    private async Task<IResult> HandleAsync(HttpContext context)
    {
        await context.SignOutAsync();
        return Results.Ok(new
        {
            message = "Sign out successful",
        });
    }

    internal static void Map(IEndpointRouteBuilder app)
    {
        app.MapPost("/api/v1/auth/signout",
                async (SignOut signOut, HttpContext context) => await signOut.HandleAsync(context))
            .WithName("SignOut")
            .Produces(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status400BadRequest);
    }
}