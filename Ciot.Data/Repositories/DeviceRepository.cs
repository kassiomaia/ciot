using Ciot.Core.Entities;
using Ciot.Core.Repositories;

namespace Ciot.Web.Repositories;

public class DeviceRepository : IDeviceRepository
{
    private readonly List<Device> _devices = new();

    public DeviceRepository()
    {
        _devices.Add(new Device(
            Guid.NewGuid(),
            "Air Conditioner",
            "Cooling device",
            "HVAC",
            "CoolTech",
            "CT-2023",
            "SN123456",
            new List<Operation>
            {
                new(Guid.NewGuid(), "Cooling", "Cooling operation"),
                new(Guid.NewGuid(), "Heating", "Heating operation")
            }
        ));

        _devices.Add(new Device(
            Guid.NewGuid(),
            "Refrigerator",
            "Cooling device",
            "Appliance",
            "CoolTech",
            "CT-2024",
            "SN654321",
            new List<Operation>
            {
                new(Guid.NewGuid(), "Cooling", "Cooling operation")
            }
        ));

        _devices.Add(new Device(
            Guid.NewGuid(),
            "Washing Machine",
            "Cleaning device",
            "Appliance",
            "CleanTech",
            "CT-2025",
            "SN789012",
            new List<Operation>
            {
                new(Guid.NewGuid(), "Washing", "Washing operation")
            }
        ));

        _devices.Add(new Device(
            Guid.NewGuid(),
            "Dishwasher",
            "Cleaning device",
            "Appliance",
            "CleanTech",
            "CT-2026",
            "SN345678",
            new List<Operation>
            {
                new(Guid.NewGuid(), "Washing", "Washing operation")
            }
        ));

        _devices.Add(new Device(
            Guid.NewGuid(),
            "Microwave Oven",
            "Cooking device",
            "Appliance",
            "CookTech",
            "CT-2027",
            "SN901234",
            new List<Operation>
            {
                new(Guid.NewGuid(), "Heating", "Heating operation")
            }
        ));

        _devices.Add(new Device(
            Guid.NewGuid(),
            "Electric Kettle",
            "Boiling device",
            "Appliance",
            "CookTech",
            "CT-2028",
            "SN567890",
            new List<Operation>
            {
                new(Guid.NewGuid(), "Boiling", "Boiling operation")
            }
        ));

        _devices.Add(new Device(
            Guid.NewGuid(),
            "Coffee Maker",
            "Brewing device",
            "Appliance",
            "BrewTech",
            "CT-2029",
            "SN123789",
            new List<Operation>
            {
                new(Guid.NewGuid(), "Brewing", "Brewing operation")
            }
        ));

        _devices.Add(new Device(
            Guid.NewGuid(),
            "Toaster",
            "Toasting device",
            "Appliance",
            "BrewTech",
            "CT-2030",
            "SN456123",
            new List<Operation>
            {
                new(Guid.NewGuid(), "Toasting", "Toasting operation")
            }
        ));

        _devices.Add(new Device(
            Guid.NewGuid(),
            "Blender",
            "Mixing device",
            "Appliance",
            "MixTech",
            "CT-2031",
            "SN789456",
            new List<Operation>
            {
                new(Guid.NewGuid(), "Mixing", "Mixing operation")
            }
        ));

        _devices.Add(new Device(
            Guid.NewGuid(),
            "Food Processor",
            "Chopping device",
            "Appliance",
            "ChopTech",
            "CT-2032",
            "SN123456",
            new List<Operation>
            {
                new(Guid.NewGuid(), "Chopping", "Chopping operation")
            }
        ));

        _devices.Add(new Device(
            Guid.NewGuid(),
            "Slow Cooker",
            "Cooking device",
            "Appliance",
            "CookTech",
            "CT-2033",
            "SN654321",
            new List<Operation>
            {
                new(Guid.NewGuid(), "Slow Cooking", "Slow cooking operation")
            }
        ));

        _devices.Add(new Device(
            Guid.NewGuid(),
            "Pressure Cooker",
            "Cooking device",
            "Appliance",
            "CookTech",
            "CT-2034",
            "SN789012",
            new List<Operation>
            {
                new(Guid.NewGuid(), "Pressure Cooking", "Pressure cooking operation")
            }
        ));

        _devices.Add(new Device(
            Guid.NewGuid(),
            "Rice Cooker",
            "Cooking device",
            "Appliance",
            "CookTech",
            "CT-2035",
            "SN345678",
            new List<Operation>
            {
                new(Guid.NewGuid(), "Rice Cooking", "Rice cooking operation")
            }
        ));

        _devices.Add(new Device(
            Guid.NewGuid(),
            "Electric Grill",
            "Grilling device",
            "Appliance",
            "GrillTech",
            "CT-2036",
            "SN901234",
            new List<Operation>
            {
                new(Guid.NewGuid(), "Grilling", "Grilling operation")
            }
        ));

        _devices.Add(new Device(
            Guid.NewGuid(),
            "Air Fryer",
            "Frying device",
            "Appliance",
            "FryTech",
            "CT-2037",
            "SN567890",
            new List<Operation>
            {
                new(Guid.NewGuid(), "Air Frying", "Air frying operation")
            }
        ));

        _devices.Add(new Device(
            Guid.NewGuid(),
            "Electric Skillet",
            "Cooking device",
            "Appliance",
            "CookTech",
            "CT-2038",
            "SN123789",
            new List<Operation>
            {
                new(Guid.NewGuid(), "Skillet Cooking", "Skillet cooking operation")
            }
        ));

        _devices.Add(new Device(
            Guid.NewGuid(),
            "Sous Vide Cooker",
            "Cooking device",
            "Appliance",
            "CookTech",
            "CT-2039",
            "SN456123",
            new List<Operation>
            {
                new(Guid.NewGuid(), "Sous Vide Cooking", "Sous vide cooking operation")
            }
        ));

        _devices.Add(new Device(
            Guid.NewGuid(),
            "Induction Cooktop",
            "Cooking device",
            "Appliance",
            "CookTech",
            "CT-2040",
            "SN789456",
            new List<Operation>
            {
                new(Guid.NewGuid(), "Induction Cooking", "Induction cooking operation")
            }
        ));

        _devices.Add(new Device(
            Guid.NewGuid(),
            "Electric Pressure Cooker",
            "Cooking device",
            "Appliance",
            "CookTech",
            "CT-2041",
            "SN123456",
            new List<Operation>
            {
                new(Guid.NewGuid(), "Pressure Cooking", "Pressure cooking operation")
            }
        ));

        _devices.Add(new Device(
            Guid.NewGuid(),
            "Electric Food Steamer",
            "Steaming device",
            "Appliance",
            "SteamTech",
            "CT-2042",
            "SN654321",
            new List<Operation>
            {
                new(Guid.NewGuid(), "Steaming", "Steaming operation")
            }
        ));

        _devices.Add(new Device(
            Guid.NewGuid(),
            "Electric Griddle",
            "Cooking device",
            "Appliance",
            "CookTech",
            "CT-2043",
            "SN789012",
            new List<Operation>
            {
                new(Guid.NewGuid(), "Griddling", "Griddling operation")
            }
        ));
    }

    public Task<Device> GetByIdAsync(Guid id)
    {
        var device = _devices.FirstOrDefault(d => d.Id == id);
        if (device == null)
            throw new KeyNotFoundException($"Device with id {id} not found.");

        return Task.FromResult(device);
    }

    public Task<Device[]> GetAllAsync()
    {
        return Task.FromResult(_devices.ToArray());
    }
}