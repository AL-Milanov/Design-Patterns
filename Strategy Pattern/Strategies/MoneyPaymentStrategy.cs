using Strategy_Pattern.Strategies;

internal class MoneyPaymentStrategy : IPaymentStrategy
{
    public string Pay()
    {
        return "Customer paid with cash money.";
    }
}

