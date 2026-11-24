namespace abstraction.Model;

public abstract class MediaAsset
{
    public string Title{get;}

    public MediaAsset(string title)
    {
        Title = title;
    }

    public abstract void Play();

    public abstract string GetFormat();

    public void ShowTitle()
    {
        Console.WriteLine($"Media: {Title}");
    }
}