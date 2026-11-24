namespace abstraction.Model;

public class MemoryCardStorage : IStorage, IStorageInfo
{
    private long memoryStorageSpace = 256;

    public void Download(string fileName)
    {
        Console.WriteLine($"Xotira kartasidan {fileName} olindi");
    }

    public void Upload(string fileName)
    {
        Console.WriteLine($"Xotira kartasiga {fileName} yuklandi");
    }

    public long GetAvailableSpace()
    {
        return memoryStorageSpace;
    }
}