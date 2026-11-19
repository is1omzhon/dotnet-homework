using inherintance.Models;

// Console.WriteLine("Task 1");
// var st1 = new Student("C#", "Ali");
// st1.Introduce();
// Console.WriteLine($"Kurs nomi: {st1.Course}");

// Console.WriteLine("\n------------------------");
// Console.WriteLine("Task 2");

// var developer = new Developer("Malika", "IT", "C#");
// developer.ShowInfo();
// Console.WriteLine($"Developerning maxsus ma’lumoti: {developer.ProgrammingLanguage}");

// var designer = new Designer("Jasur", "Design", "Figma");
// designer.ShowInfo();
// Console.WriteLine($"Designerning maxsus ma’lumoti: {designer.DesignTool}");

// Console.WriteLine("\n------------------------");
// Console.WriteLine("Task 3");

// var phone = new Phone("Pixel");
// Console.Write("Meros olingan public ShowModel: ");
// phone.ShowModel();

// Console.Write("Derived class ichidagi protected Model: ");
// phone.ShowModelPhone();

// Console.WriteLine("\n------------------------");
// Console.WriteLine("Task 4 ");

// Notification email = new EmailNotification("Xush kelibsiz", "ali@gmail.com");
// Notification sms = new SmsNotification("Tasdiqlash kodi", "+7 996 503 26 54");

// if(email is EmailNotification emailNotification)
// {
//     Console.WriteLine($"true; {emailNotification.EmailAddress} chiqadi");
// }

// SmsNotification smsNotif = email as SmsNotification;
// if(smsNotif != null)
// {
//     Console.WriteLine(smsNotif.PhoneNumber);
// }
// else
// {
//     Console.WriteLine("null; SMS propertyga murojaat qilmang!");
// }

// SmsNotification smsNotif2 = sms as SmsNotification;
// if(smsNotif2 != null)
// {
//     Console.WriteLine($"Muvaffaqiyatli; {smsNotif2.PhoneNumber} chiqadi");
// }
// else
// {
//    Console.WriteLine("Natija null. Bu SMS emas!");
// }

Console.WriteLine("\n------------------------");
Console.WriteLine("Task 5 ");

LearningPlatform platform1 = new LearningPlatform("Online"); 
OnlineCourse course = new OnlineCourse("C#", platform1);

Console.WriteLine($"Kurs nomi: {course.Name}");
Console.WriteLine($"Platforma nomi: {course.Platform.Name}");
Console.WriteLine("Base class: " + typeof(OnlineCourse).BaseType.Name);