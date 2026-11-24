namespace abstraction.Model;

public class Lion : Animal
{
    public Lion(string name) : base(name) {}

    public override void MakeSound()
    {
        Console.WriteLine("Arslon: Rov!!!");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} yurgizib");
    }
}