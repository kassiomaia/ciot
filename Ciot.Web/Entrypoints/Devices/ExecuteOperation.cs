using Ciot.Core.Repositories;

namespace Ciot.Web.Entrypoints;

internal class ExecuteOperation(IDeviceRepository deviceRepository)
{
    private async Task<IResult> HandleAsync(Guid deviceId, Guid operationId)
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

        Task.Delay(2500).Wait(); // Simulate some delay for the operation to execute

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
                async (Guid deviceId, Guid operationId, ExecuteOperation executeOperation) =>
                    await executeOperation.HandleAsync(deviceId, operationId))
            .WithName("ExecuteOperation")
            .Produces<string>()
            .Produces(StatusCodes.Status404NotFound);
    }
}