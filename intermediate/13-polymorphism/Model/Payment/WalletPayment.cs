namespace polymorphism.Model;

class WalletPayment : Payment
{
    public WalletPayment(string payType) : 
        base(payType){}

    public override decimal Pay(decimal amount)
    {
        return amount;
    }
}