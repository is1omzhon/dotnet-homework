namespace abstraction.Model;

public class CloudStorage : IStorage, IStorageInfo
{
    private long cloudSpace = 512;
    public void Download(string fileName)
    {
        Console.WriteLine($"Clouddan {fileName} olindi");
    }

    public void Upload(string fileName)
    {
        Console.WriteLine($"Cloudga {fileName} yuklandi");
    }

    public long GetAvailableSpace()
    {
        return cloudSpace;
    }
}