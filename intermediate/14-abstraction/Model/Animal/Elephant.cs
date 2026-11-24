namespace abstraction.Model;

public class Elephant : Animal
{
    public Elephant(string name) : base(name) {}
    
    public override void MakeSound()
    {
        Console.WriteLine("Fil: Tup-tup!");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} astoydil yurib");
    }
}