using System.Data.SqlTypes;
using System.Diagnostics.Metrics;
using abstraction.Model;

Console.WriteLine("\nTask 1");
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
    Console.WriteLine("----------------------");
}


Console.WriteLine("\nTask 2");
Appliance[] appliances =
{
    new WashingMachine(),
    new AirHeater(),
    new ElectricKettle()
};

foreach(Appliance appliance in appliances)
{
    appliance.ShowName();
    Console.WriteLine($"Soatlar buyicha hisoblash: {appliance.CalculatePowerConsumption(3)}");
    Console.WriteLine($"Kunlar buyicha hisoblash: {appliance.CalculateWeeklyConsumption(10, 3)}");
    Console.WriteLine("----------------------");
}


Console.WriteLine("\nTask 3");
IStorage[] storages =
{
    new CloudStorage(),
    new UsbStorage(),
    new MemoryCardStorage()
};

foreach (IStorage storage in storages)
{
    storage.Upload("course.zip");
    storage.Download("course.zip");

    IStorageInfo storageInfo = (IStorageInfo)storage;
    long space = storageInfo.GetAvailableSpace();
    Console.WriteLine($"Bo'sh joy: {space} GB");
    Console.WriteLine("----------------------");
}


Console.WriteLine("\nTask 4");
IPrinter[] printers =
{
    new LaserPrinter(),
    new InkjetPrinter(),
    new ThermalPrinter()
};

foreach (IPrinter printer in printers)
{
    printer.PrintPreview("Dars-jadvali");
    printer.Clean();
    printer.Print("Dars-jadvali");
    Console.WriteLine("----------------------");
}


Console.WriteLine("\nTask 5");
Animal[] animals =
{
    new Lion("Sulton"),
    new Parrot("Kesha"),
    new Elephant("Barno")
};

foreach (Animal animal in animals)
{
    animal.DisplayName();
    animal.MakeSound();
    animal.Move();
    Console.WriteLine("------------------");
}
