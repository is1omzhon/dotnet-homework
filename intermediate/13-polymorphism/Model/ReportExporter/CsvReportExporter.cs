namespace polymorphism.Model;

class CsvReportExport : ReportExporter
{
    public CsvReportExport(string format) : base(format) {}

    public override void Export(string data)
    {
        Console.WriteLine($"Hisobot {this.Format} formatida eksport qilinganini bildiradi: {data}");
    }
}