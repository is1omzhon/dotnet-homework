namespace polymorphism.Model;

class EmailNotification: Notification
{
    public EmailNotification(string recipient, string message) : 
        base(recipient, message){}

    public override void Send()
    {
        Console.WriteLine($"Email: {Recipient} , {Message}");
    }
}