namespace abstraction.Model;

class PodcastAsset : MediaAsset
{
    public PodcastAsset(string title) : base(title) {}

    public override string GetFormat()
    {
        return "MP3";
    }

    public override void Play()
    {
        Console.WriteLine( $"Podcast tinglandi: {Title}");
    }
}