namespace inherintance.Models;

class SmsNotification : Notification
{
    public string PhoneNumber {get;}

    public SmsNotification (string title, string phoneNumber) : base(title)
    {
        PhoneNumber = phoneNumber;
    }
}