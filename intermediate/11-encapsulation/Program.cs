using encapsulation.Models;

var wtank1 = new WaterTank(100, 40);
Console.WriteLine($"Fill(30): {wtank1.Fill(30)}, suv {wtank1.Water}");
Console.WriteLine($"Use(20): {wtank1.Use(20)}, suv {wtank1.Water}");
Console.WriteLine($"Fill(60): {wtank1.Fill(60)}, suv {wtank1.Water}");
Console.WriteLine($"Use(0): {wtank1.Use(0)}, suv {wtank1.Water}");
Console.WriteLine($"Bo'sh sig'im: {wtank1.GetFreeCapacity()}");

var wtank2 = new WaterTank(50, 10);
Console.WriteLine($"2-idishdagi suv: {wtank2.Water}");


