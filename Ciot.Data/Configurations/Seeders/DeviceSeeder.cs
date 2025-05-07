using Ciot.Core.Entities;

namespace Ciot.Data.Configurations.Seeders;

internal static class DeviceSeeder
{
    public static IReadOnlyCollection<Device> All()
    {
        var devices = new List<Device>
        {
            new(
                Guid.NewGuid(),
                "Air Conditioner",
                "Cooling device",
                "HVAC",
                "CoolTech",
                "CT-2023",
                "SN123456",
                new List<Operation>
                {
                    new(Guid.NewGuid(), "Cooling", "Cooling operation",
                        new List<Parameter>
                        {
                            new(Guid.NewGuid(), "Temperature", "Temperature setting", ParameterType.Number),
                            new(Guid.NewGuid(), "Fan Speed", "Fan speed setting", ParameterType.Number),
                            new(Guid.NewGuid(), "Mode", "Mode setting", ParameterType.String)
                        }),
                    new(Guid.NewGuid(), "Heating", "Heating operation",
                        new List<Parameter>()
                        {
                            new(Guid.NewGuid(), "Temperature", "Temperature setting", ParameterType.Number),
                            new(Guid.NewGuid(), "Fan Speed", "Fan speed setting", ParameterType.Number),
                            new(Guid.NewGuid(), "Mode", "Mode setting", ParameterType.String)
                        })
                }
            ),
            new(
                Guid.NewGuid(),
                "Refrigerator",
                "Cooling device",
                "Appliance",
                "CoolTech",
                "CT-2024",
                "SN654321",
                new List<Operation>
                {
                    new(Guid.NewGuid(), "Cooling", "Cooling operation",
                        new List<Parameter>
                        {
                            new(Guid.NewGuid(), "Temperature", "Temperature setting", ParameterType.Number),
                            new(Guid.NewGuid(), "Fan Speed", "Fan speed setting", ParameterType.Number),
                            new(Guid.NewGuid(), "Mode", "Mode setting", ParameterType.String)
                        })
                }
            ),
            new(
                Guid.NewGuid(),
                "Washing Machine",
                "Cleaning device",
                "Appliance",
                "CleanTech",
                "CT-2025",
                "SN789012",
                new List<Operation>
                {
                    new(Guid.NewGuid(), "Washing", "Washing operation",
                        new List<Parameter>
                        {
                            new(Guid.NewGuid(), "Cycle", "Washing cycle", ParameterType.String),
                            new(Guid.NewGuid(), "Temperature", "Washing temperature", ParameterType.Number),
                            new(Guid.NewGuid(), "Spin Speed", "Spin speed setting", ParameterType.Number)
                        })
                }
            ),
            new(
                Guid.NewGuid(),
                "Dishwasher",
                "Cleaning device",
                "Appliance",
                "CleanTech",
                "CT-2026",
                "SN345678",
                new List<Operation>
                {
                    new(Guid.NewGuid(), "Washing", "Washing operation",
                        new List<Parameter>
                        {
                            new(Guid.NewGuid(), "Cycle", "Washing cycle", ParameterType.String),
                            new(Guid.NewGuid(), "Temperature", "Washing temperature", ParameterType.Number),
                            new(Guid.NewGuid(), "Spin Speed", "Spin speed setting", ParameterType.Number)
                        })
                }
            ),
            new(
                Guid.NewGuid(),
                "Microwave Oven",
                "Cooking device",
                "Appliance",
                "CookTech",
                "CT-2027",
                "SN901234",
                new List<Operation>
                {
                    new(Guid.NewGuid(), "Heating", "Heating operation",
                        new List<Parameter>
                        {
                            new(Guid.NewGuid(), "Time", "Heating time", ParameterType.Number),
                            new(Guid.NewGuid(), "Power Level", "Power level setting", ParameterType.Number)
                        })
                }
            ),
            new(
                Guid.NewGuid(),
                "Electric Kettle",
                "Boiling device",
                "Appliance",
                "CookTech",
                "CT-2028",
                "SN567890",
                new List<Operation>
                {
                    new(Guid.NewGuid(), "Boiling", "Boiling operation",
                        new List<Parameter>
                        {
                            new(Guid.NewGuid(), "Temperature", "Boiling temperature", ParameterType.Number),
                            new(Guid.NewGuid(), "Time", "Boiling time", ParameterType.Number)
                        })
                }
            ),
            new(
                Guid.NewGuid(),
                "Coffee Maker",
                "Brewing device",
                "Appliance",
                "BrewTech",
                "CT-2029",
                "SN123789",
                new List<Operation>
                {
                    new(Guid.NewGuid(), "Brewing", "Brewing operation",
                        new List<Parameter>
                        {
                            new(Guid.NewGuid(), "Brew Time", "Brewing time", ParameterType.Number),
                            new(Guid.NewGuid(), "Water Temperature", "Water temperature", ParameterType.Number),
                            new(Guid.NewGuid(), "Coffee Strength", "Coffee strength", ParameterType.String),
                            new(Guid.NewGuid(), "Grind Size", "Grind size", ParameterType.String)
                        })
                }
            ),
            new(
                Guid.NewGuid(),
                "Toaster",
                "Toasting device",
                "Appliance",
                "BrewTech",
                "CT-2030",
                "SN456123",
                new List<Operation>
                {
                    new(Guid.NewGuid(), "Toasting", "Toasting operation",
                        new List<Parameter>
                        {
                            new(Guid.NewGuid(), "Toast Level", "Toast level setting", ParameterType.Number),
                            new(Guid.NewGuid(), "Time", "Toasting time", ParameterType.Number)
                        })
                }
            ),
            new(
                Guid.NewGuid(),
                "Blender",
                "Mixing device",
                "Appliance",
                "MixTech",
                "CT-2031",
                "SN789456",
                new List<Operation>
                {
                    new(Guid.NewGuid(), "Mixing", "Mixing operation",
                        new List<Parameter>
                        {
                            new(Guid.NewGuid(), "Speed", "Mixing speed", ParameterType.Number),
                            new(Guid.NewGuid(), "Time", "Mixing time", ParameterType.Number)
                        })
                }
            ),
            new(
                Guid.NewGuid(),
                "Food Processor",
                "Chopping device",
                "Appliance",
                "ChopTech",
                "CT-2032",
                "SN123456",
                new List<Operation>
                {
                    new(Guid.NewGuid(), "Chopping", "Chopping operation",
                        new List<Parameter>
                        {
                            new(Guid.NewGuid(), "Speed", "Chopping speed", ParameterType.Number),
                            new(Guid.NewGuid(), "Time", "Chopping time", ParameterType.Number)
                        })
                }
            ),
            new(
                Guid.NewGuid(),
                "Slow Cooker",
                "Cooking device",
                "Appliance",
                "CookTech",
                "CT-2033",
                "SN654321",
                new List<Operation>
                {
                    new(Guid.NewGuid(), "Slow Cooking", "Slow cooking operation",
                        new List<Parameter>
                        {
                            new(Guid.NewGuid(), "Temperature", "Cooking temperature", ParameterType.Number),
                            new(Guid.NewGuid(), "Time", "Cooking time", ParameterType.Number)
                        })
                }
            ),
            new(
                Guid.NewGuid(),
                "Pressure Cooker",
                "Cooking device",
                "Appliance",
                "CookTech",
                "CT-2034",
                "SN789012",
                new List<Operation>
                {
                    new(Guid.NewGuid(), "Pressure Cooking", "Pressure cooking operation",
                        new List<Parameter>
                        {
                            new(Guid.NewGuid(), "Pressure Level", "Pressure level setting", ParameterType.Number),
                            new(Guid.NewGuid(), "Time", "Cooking time", ParameterType.Number),
                            new(Guid.NewGuid(), "Temperature", "Cooking temperature", ParameterType.Number)
                        })
                }
            ),
            new(
                Guid.NewGuid(),
                "Rice Cooker",
                "Cooking device",
                "Appliance",
                "CookTech",
                "CT-2035",
                "SN345678",
                new List<Operation>
                {
                    new(Guid.NewGuid(), "Rice Cooking", "Rice cooking operation",
                        new List<Parameter>
                        {
                            new(Guid.NewGuid(), "Water Level", "Water level setting", ParameterType.Number),
                            new(Guid.NewGuid(), "Cooking Time", "Cooking time", ParameterType.Number),
                            new(Guid.NewGuid(), "Temperature", "Cooking temperature", ParameterType.Number)
                        })
                }
            ),
            new(
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
            ),
            new(
                Guid.NewGuid(),
                "Air Fryer",
                "Frying device",
                "Appliance",
                "FryTech",
                "CT-2037",
                "SN567890",
                new List<Operation>
                {
                    new(Guid.NewGuid(), "Air Frying", "Air frying operation",
                        new List<Parameter>
                        {
                            new(Guid.NewGuid(), "Temperature", "Frying temperature", ParameterType.Number),
                            new(Guid.NewGuid(), "Time", "Frying time", ParameterType.Number),
                            new(Guid.NewGuid(), "Food Type", "Type of food", ParameterType.String)
                        })
                }
            ),
            new(
                Guid.NewGuid(),
                "Electric Skillet",
                "Cooking device",
                "Appliance",
                "CookTech",
                "CT-2038",
                "SN123789",
                new List<Operation>
                {
                    new(Guid.NewGuid(), "Skillet Cooking", "Skillet cooking operation",
                        new List<Parameter>
                        {
                            new(Guid.NewGuid(), "Temperature", "Cooking temperature", ParameterType.Number),
                            new(Guid.NewGuid(), "Time", "Cooking time", ParameterType.Number),
                            new(Guid.NewGuid(), "Food Type", "Type of food", ParameterType.String)
                        })
                }
            ),
            new(
                Guid.NewGuid(),
                "Sous Vide Cooker",
                "Cooking device",
                "Appliance",
                "CookTech",
                "CT-2039",
                "SN456123",
                new List<Operation>
                {
                    new(Guid.NewGuid(), "Sous Vide Cooking", "Sous vide cooking operation",
                        new List<Parameter>
                        {
                            new(Guid.NewGuid(), "Temperature", "Cooking temperature", ParameterType.Number),
                            new(Guid.NewGuid(), "Time", "Cooking time", ParameterType.Number),
                            new(Guid.NewGuid(), "Food Type", "Type of food", ParameterType.String)
                        })
                }
            ),
            new(
                Guid.NewGuid(),
                "Induction Cooktop",
                "Cooking device",
                "Appliance",
                "CookTech",
                "CT-2040",
                "SN789456",
                new List<Operation>
                {
                    new(Guid.NewGuid(), "Induction Cooking", "Induction cooking operation",
                        new List<Parameter>
                        {
                            new(Guid.NewGuid(), "Temperature", "Cooking temperature", ParameterType.Number),
                            new(Guid.NewGuid(), "Time", "Cooking time", ParameterType.Number),
                            new(Guid.NewGuid(), "Food Type", "Type of food", ParameterType.String)
                        })
                }
            ),
            new(
                Guid.NewGuid(),
                "Electric Pressure Cooker",
                "Cooking device",
                "Appliance",
                "CookTech",
                "CT-2041",
                "SN123456",
                new List<Operation>
                {
                    new(Guid.NewGuid(), "Pressure Cooking", "Pressure cooking operation",
                        new List<Parameter>
                        {
                            new(Guid.NewGuid(), "Pressure Level", "Pressure level setting", ParameterType.Number),
                            new(Guid.NewGuid(), "Time", "Cooking time", ParameterType.Number),
                            new(Guid.NewGuid(), "Temperature", "Cooking temperature", ParameterType.Number)
                        })
                }
            ),
            new(
                Guid.NewGuid(),
                "Electric Food Steamer",
                "Steaming device",
                "Appliance",
                "SteamTech",
                "CT-2042",
                "SN654321",
                new List<Operation>
                {
                    new(Guid.NewGuid(), "Steaming", "Steaming operation",
                        new List<Parameter>
                        {
                            new(Guid.NewGuid(), "Temperature", "Steaming temperature", ParameterType.Number),
                            new(Guid.NewGuid(), "Time", "Steaming time", ParameterType.Number),
                            new(Guid.NewGuid(), "Food Type", "Type of food", ParameterType.String)
                        })
                }
            ),
            new(
                Guid.NewGuid(),
                "Electric Griddle",
                "Cooking device",
                "Appliance",
                "CookTech",
                "CT-2043",
                "SN789012",
                new List<Operation>
                {
                    new(Guid.NewGuid(), "Griddling", "Griddling operation",
                        new List<Parameter>
                        {
                            new(Guid.NewGuid(), "Temperature", "Griddling temperature", ParameterType.Number),
                            new(Guid.NewGuid(), "Time", "Griddling time", ParameterType.Number),
                            new(Guid.NewGuid(), "Food Type", "Type of food", ParameterType.String)
                        })
                }
            )
        };

        return devices;
    }
}