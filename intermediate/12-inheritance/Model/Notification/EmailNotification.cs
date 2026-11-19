namespace inherintance.Models;

class EmailNotification : Notification
{
    public string EmailAddress{get;}

    public EmailNotification(string title, string emailAddress) : base(title)
    {
        EmailAddress = emailAddress;
    }
}