namespace abstraction.Model;

public class UsbStorage : IStorage, IStorageInfo
{
    private long usbSpace = 8;
    public void Download(string fileName)
    {
        Console.WriteLine($"USBdan {fileName} olindi");
    }

    public void Upload(string fileName)
    {
        Console.WriteLine($"USBga {fileName} yuklandi");
    }

    public long GetAvailableSpace()
    {
        return usbSpace;
    }
}