namespace abstraction.Model;

public class InkjetPrinter : IPrinter
{
    public void Print(string documentName)
    {
        Console.WriteLine($"Inkjet printer sifatli chop etdi: {documentName}");
    }

    public void PrintPreview(string documentName)
    {
        Console.WriteLine($"Inkjet printer oldindan ko'rdi: {documentName}");
    }

    public void Clean()
    {
        Console.WriteLine("Inkjet printer tozalandi");
    }
}