using Ciot.Core.Entities;
using Ciot.Core.Repositories;

namespace Ciot.Web.Endpoints.Devices;

internal sealed class GetDeviceById(IDeviceRepository deviceRepository)
{
    private async Task<IResult> HandleAsync(Guid deviceId)
    {
        var device = await deviceRepository.GetByIdAsync(deviceId);
        return device is null ? Results.NotFound() : Results.Ok(device);
    }

    internal static void Map(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/v1/devices/{deviceId:guid}", async (Guid deviceId, GetDeviceById getDeviceById) => await getDeviceById.HandleAsync(deviceId))
            .WithName("GetDeviceById")
            .Produces<Device>()
            .Produces(StatusCodes.Status404NotFound);
    }
}