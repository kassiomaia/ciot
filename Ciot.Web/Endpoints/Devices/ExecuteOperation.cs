using Ciot.Core.Repositories;
using Ciot.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ciot.Web.Endpoints.Devices;

internal sealed class ExecuteOperation(IDeviceRepository deviceRepository, IDeviceService deviceService)
{
    
    public record ExecutionBody(Dictionary<string, string> Parameters);
    
    private async Task<IResult> HandleAsync(Guid deviceId, Guid operationId, ExecutionBody body)
    {
        var device = await deviceRepository.GetByIdAsync(deviceId);
        if (device is null)
        {
            return Results.NotFound("Device not found.");
        }

        var operation = device.Operations.FirstOrDefault(o => o.Id == operationId);
        if (operation is null)
        {
            return Results.NotFound("Operation not found.");
        }

        await deviceService.ExecuteAsync(new OperationRequest(operation, body.Parameters));

        return Results.Ok(new
        {
            Message = $"Operation {operationId} executed successfully on device {deviceId}.",
            DeviceId = deviceId,
            OperationId = operationId
        });
    }

    internal static void Map(IEndpointRouteBuilder app)
    {
        app.MapPost("/api/v1/devices/{deviceId:guid}/operations/{operationId:guid}/execute",
                async (Guid deviceId, Guid operationId, [FromBody] ExecutionBody body, ExecuteOperation executeOperation) =>
                    await executeOperation.HandleAsync(deviceId, operationId, body))
            .WithName("ExecuteOperation")
            .Produces<string>()
            .Produces(StatusCodes.Status404NotFound);
    }
}