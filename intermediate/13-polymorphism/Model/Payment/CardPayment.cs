namespace polymorphism.Model;

class CardPayment : Payment
{
    public CardPayment(string payType) : 
        base(payType){}

    public override decimal Pay(decimal amount)
    {
        return amount;
    }
}