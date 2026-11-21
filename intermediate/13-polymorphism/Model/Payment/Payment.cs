namespace polymorphism.Model;

class Payment
{
    public string PayType{get;}

    public Payment(string payType)
    {
        PayType = payType;
    }

    public virtual decimal Pay(decimal amount)
    {
        return amount;
    }
}