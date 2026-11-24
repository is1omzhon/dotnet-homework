using System.Net.Http.Headers;

namespace abstraction.Model;

public class AirHeater : Appliance
{
    private const int perHourAirheaterPower = 2;
    public override string Name => "Isitgich";

    public override double CalculatePowerConsumption(int hours)
    {
        return perHourAirheaterPower * hours; 
    }

}