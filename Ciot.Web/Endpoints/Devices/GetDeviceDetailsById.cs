using Ciot.Core.Entities;
using Ciot.Core.Repositories;

namespace Ciot.Web.Endpoints.Devices;

internal sealed class GetDeviceDetailsById(IDeviceRepository deviceRepository)
{
    private async Task<IResult> HandleAsync(Guid deviceId)
    {
        var device = await deviceRepository.GetByIdAsync(deviceId);
        return device is null ? Results.NotFound() : Results.Ok(device);
    }

    internal static void Map(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/v1/devices/{deviceId:guid}/details",
                async (Guid deviceId, GetDeviceDetailsById getDevaDetailsById) =>
                    await getDevaDetailsById.HandleAsync(deviceId))
            .WithName("GetDeviceDetailsById")
            .Produces<Device>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);
    }
}