using Ciot.Application;
using Ciot.Data;
using Ciot.Web.Endpoints;
using Ciot.Web.Endpoints.Auth;
using Ciot.Web.Endpoints.Devices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.UseInMemoryDatabase();
builder.Services.UseApplicationServices();

builder.Services.AddScoped<GetDeviceById>();
builder.Services.AddScoped<GetDeviceDetailsById>();
builder.Services.AddScoped<GetAllDevices>();
builder.Services.AddScoped<GetOperationsByDeviceId>();
builder.Services.AddScoped<ExecuteOperation>();
builder.Services.AddScoped<Login>();
builder.Services.AddScoped<SignOut>();

builder.Services.AddAuthentication("SessionToken")
    .AddCookie("SessionToken", options =>
    {
        options.LoginPath = "/#/login";
        options.AccessDeniedPath = "/#/denied";
    });

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseDefaultFiles();
app.UseStaticFiles();
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapEndpoints();
app.Run();