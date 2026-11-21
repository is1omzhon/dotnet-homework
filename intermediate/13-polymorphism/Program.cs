using polymorphism.Model;

Notification [] notifications =
{
    new EmailNotification("Aziza", "Bu xabar siz uchun yuborildi!"),
    new SmsNotification ("+7 996 503 26 54", "Kirish kodi: 4845")
};

foreach (Notification notification in notifications)
{
    notification.Send();
}