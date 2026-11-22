namespace polymorphism.Model;

class ReportExporter
{

    public string Format{get;}

    public ReportExporter(string format)
    {
        Format = format;
    }

    public virtual void Export(string data)
    {
        Console.WriteLine("Export qilindi");
    }
}