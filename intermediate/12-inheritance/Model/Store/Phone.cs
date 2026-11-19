namespace inherintance.Models;

class Phone : Device
{
    public Phone(string model) : base(model)
    {
    }

    public void ShowModelPhone()
    {
        Console.WriteLine(Model);
    }
}