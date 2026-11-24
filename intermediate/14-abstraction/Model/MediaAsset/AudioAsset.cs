namespace abstraction.Model;

class AudioAsset : MediaAsset
{
    public AudioAsset(string title) : base(title) {}

    public override string GetFormat()
    {
        return "Audio";
    }

    public override void Play()
    {
        Console.WriteLine("Audio ijro etildi");
    }
}