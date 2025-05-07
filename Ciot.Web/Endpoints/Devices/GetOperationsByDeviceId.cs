using Ciot.Core.Entities;
using Ciot.Core.Repositories;

namespace Ciot.Web.Endpoints.Devices;

internal sealed class GetOperationsByDeviceId(IDeviceRepository deviceRepository)
{
    private async Task<IResult> HandleAsync(Guid deviceId)
    {
        var device = await deviceRepository.GetByIdAsync(deviceId);
        if (device is null)
            return Results.NotFound();
        
        var operations = device.Operations;
        return Results.Ok(operations);
    }

    internal static void Map(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/v1/devices/{deviceId:guid}/operations", async (Guid deviceId, GetOperationsByDeviceId getOperationsByDeviceId) => await getOperationsByDeviceId.HandleAsync(deviceId))
            .WithName("GetOperationsByDeviceId")
            .Produces<IEnumerable<Operation>>()
            .Produces(StatusCodes.Status404NotFound);
    }
}