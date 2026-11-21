using polymorphism.Model;

Console.Writiline("Task 1");
Notification [] notifications =
{
    new EmailNotification("Aziza", "Bu xabar siz uchun yuborildi!"),
    new SmsNotification ("+7 996 503 26 54", "Kirish kodi: 4845")
};

foreach (Notification notification in notifications)
{
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
