namespace abstraction.Model;

public abstract class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public abstract void MakeSound();
    public abstract void Move();
    
    public void DisplayName()
    {
        Console.WriteLine($"Hayvonning nomi: {Name}");
    }
}