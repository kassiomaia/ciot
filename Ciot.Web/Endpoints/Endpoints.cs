using Ciot.Web.Endpoints.Auth;
using Ciot.Web.Endpoints.Devices;

namespace Ciot.Web.Endpoints;

public static class Endpoints
{
    public static IEndpointRouteBuilder MapEndpoints(this IEndpointRouteBuilder app)
    {
        /*
         * Mapping devices endpoints
         */
        GetDeviceById.Map(app);
        GetDeviceDetailsById.Map(app);
        GetAllDevices.Map(app);
        GetOperationsByDeviceId.Map(app);
        ExecuteOperation.Map(app);

        /*
         * Mapping auth endpoints
         */
        Login.Map(app);
        SignOut.Map(app);

        return app;
    }
}