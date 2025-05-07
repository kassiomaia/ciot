using Ciot.Core.Entities;
using Ciot.Core.Repositories;

namespace Ciot.Web.Entrypoints;

internal class GetAllDevices(IDeviceRepository deviceRepository)
{
    private async Task<IResult> HandleAsync()
    {
        var devices = await deviceRepository.GetAllAsync();
        return Results.Ok(devices);
    }

    internal static void Map(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/v1/devices", async (GetAllDevices getAllDevices) => await getAllDevices.HandleAsync())
            .WithName("GetAllDevices")
            .Produces<IEnumerable<Device>>()
            .Produces(StatusCodes.Status404NotFound);
    }
}