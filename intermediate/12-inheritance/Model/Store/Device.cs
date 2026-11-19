namespace inherintance.Models;

class Device
{
    private string _model;
    protected string Model => _model;

    public Device(string model)
    {
        _model = model;
    }

    public void ShowModel()
    {
        Console.WriteLine(Model);   
    }
}