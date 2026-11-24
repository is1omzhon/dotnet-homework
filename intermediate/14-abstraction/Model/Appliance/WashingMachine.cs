using System.Net.Http.Headers;

namespace abstraction.Model;

public class WashingMachine : Appliance
{
    private const int perHourWashPower = 1;
    public override string Name => "Kir yuvish mashinasi";

    public override double CalculatePowerConsumption(int hours)
    {
        return perHourWashPower * hours; 
    }

}