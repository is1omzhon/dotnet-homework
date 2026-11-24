namespace abstraction.Model;

public class Parrot : Animal
{
    public Parrot(string name) : base(name) {}

    public override void MakeSound()
    {
        Console.WriteLine("To‘tiqush: Help!!!");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} uchib");
    }
}