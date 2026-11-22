using polymorphism.Model;

<<<<<<< HEAD
// Notification [] notifications =
// {
//     new EmailNotification("Aziza", "Bu xabar siz uchun yuborildi!"),
//     new SmsNotification ("+7 996 503 26 54", "Kirish kodi: 4845")
// };

// foreach (Notification notification in notifications)
// {
//     notification.Send();
// }

// Payment [] payments =
// {
//     new CardPayment("Card"),
//     new BankTransferPayment("Bank"),
//     new WalletPayment("Wallet")
// };

// foreach (Payment payment in payments)
// {
//     Console.WriteLine($"{payment.PayType} orqali tulandi: {payment.Pay(50000)}");
// }

// ReportPrinter printer = new ReportPrinter();

// printer.Print("Oylik hisobot");
// printer.Print("Oylik hisobot", 125000);


ReportExporter [] reports =
=======
Console.Writiline("Task 1");
Notification [] notifications =
>>>>>>> faa3e24ec7c91283f8a4be1f800dab25536fd53d
{
    new PdfReportExport("Pdf"),
    new CsvReportExport("Csv")
};

foreach (ReportExporter report in reports)
{
<<<<<<< HEAD
    report.Export("Restoranning bir oylik savdo hisoboti");
}
=======
    notification.Send();
}

Console.Writiline("Task 2");
Payment [] payments =
{
    new CardPayment("Card"),
    new BankTransferPayment("Bank"),
    new WalletPayment("Wallet")
};

foreach (Payment payment in payments)
{
    Console.WriteLine($"{payment.PayType} orqali tulandi: {payment.Pay(50000)}");
}

Console.Writiline("Task 3");
ReportPrinter printer = new ReportPrinter();
printer.Print("Oylik hisobot");
printer.Print("Oylik hisobot", 125000);
>>>>>>> faa3e24ec7c91283f8a4be1f800dab25536fd53d
