namespace polymorphism.Model;

class BankTransferPayment : Payment
{
    public BankTransferPayment(string payType) : 
        base(payType){}

    public override decimal Pay(decimal amount)
    {
        return amount;
    }
}