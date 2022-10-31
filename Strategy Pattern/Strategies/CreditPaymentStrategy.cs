using Strategy_Pattern.Strategies;

internal class CreditPaymentStrategy : IPaymentStrategy
{
    public string Pay()
    {
        return "Customer paid on credit.";
    }
}