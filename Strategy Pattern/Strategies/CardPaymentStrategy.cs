using Strategy_Pattern.Strategies;

internal class CardPaymentStrategy : IPaymentStrategy
{
    public string Pay()
    {
        return "Customer paid with card.";
    }
}
