namespace abstraction.Model;

public class  ElectricKettle: Appliance
{
    private const double perHourKettlePower = 1.5;
    public override string Name => "Choynak";

    public override double CalculatePowerConsumption(int hours)
    {
        return perHourKettlePower * hours; 
    }

}