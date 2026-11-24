namespace abstraction.Model;

public class LaserPrinter : IPrinter
{
    public void Print(string documentName)
    {
        Console.WriteLine($"Laser printer tez chop etdi: {documentName}");
    }

    public void PrintPreview(string documentName)
    {
        Console.WriteLine($"Laser printer oldindan ko'rdi: {documentName}");
    }

    public void Clean()
    {
        Console.WriteLine("Laser printer tozalandi");
    }
}