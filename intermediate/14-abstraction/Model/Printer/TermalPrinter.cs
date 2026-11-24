namespace abstraction.Model;

public class ThermalPrinter : IPrinter
{
    public void Print(string documentName)
    {
        Console.WriteLine($"Termoprinter chek chop etdi: {documentName}");
    }

    public void PrintPreview(string documentName)
    {
        Console.WriteLine($"Termoprinter oldindan ko'rdi: {documentName}");
    }

    public void Clean()
    {
        Console.WriteLine("Termoprinter tozalandi");
    }
}