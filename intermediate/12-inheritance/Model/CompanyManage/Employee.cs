using System.IO.Compression;

namespace inherintance.Models;

class Employee
{
    public string Name {get;}
    public string Department {get;}

    public Employee (string name, string department)
    {
        Name = name;
        Department = department;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"{Name}, {Department}");
    }
}