using inherintance.Models;

// var st1 = new Student("C#", "Ali");
// st1.Introduce();
// Console.WriteLine($"Kurs nomi: {st1.Course}");

// Console.WriteLine("\n------------------------");
// Console.WriteLine("Task 2 \n");

// var developer = new Developer("Malika", "IT", "C#");
// developer.ShowInfo();
// Console.WriteLine($"Developerning maxsus ma’lumoti: {developer.ProgrammingLanguage}");

// var designer = new Designer("Jasur", "Design", "Figma");
// designer.ShowInfo();
// Console.WriteLine($"Designerning maxsus ma’lumoti: {designer.DesignTool}");

Console.WriteLine("\n------------------------");
Console.WriteLine("Task 3 \n");

var phone = new Phone("Pixel");
Console.Write("Meros olingan public ShowModel: ");
phone.ShowModel();

Console.Write("Derived class ichidagi protected Model: ");
phone.ShowModelPhone();

