namespace abstraction.Model;

class VedioAsset : MediaAsset
{
    public VedioAsset(string title) : base(title) {}

    public override string GetFormat()
    {
        return "Vedio";
    }

    public override void Play()
    {
        Console.WriteLine("Vedio ijro etildi");
    }
}