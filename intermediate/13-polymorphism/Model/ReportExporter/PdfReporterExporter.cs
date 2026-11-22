namespace polymorphism.Model;

class PdfReportExport : ReportExporter
{
    public PdfReportExport(string format) : base(format) {}

    public override void Export(string data)
    {
        Console.WriteLine($"Hisobot {this.Format} formatida eksport qilinganini bildiradi: {data}");
    }
}