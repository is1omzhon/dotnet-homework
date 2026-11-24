namespace abstraction.Model;

public abstract class Appliance
{
    public abstract string Name{get;}
    public abstract double CalculatePowerConsumption(int hours);

    public void ShowName()
    {
        Console.WriteLine(Name);
    }

    public double CalculateWeeklyConsumption(int hoursPerDay, int days)
    {
        return CalculatePowerConsumption(hoursPerDay) * days;
    }
}