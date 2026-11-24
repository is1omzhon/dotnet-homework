using System.Diagnostics.Metrics;
using abstraction.Model;

MediaAsset[] assets =
{
    new AudioAsset("Audio"),
    new VedioAsset("Vediodars"),
    new PodcastAsset("C# yangiliklari")
};

foreach(MediaAsset asset in assets)
{
    asset.ShowTitle();
    asset.Play();
    Console.WriteLine(asset.GetFormat());
}