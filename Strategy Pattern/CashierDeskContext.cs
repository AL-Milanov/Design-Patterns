using Strategy_Pattern.Strategies;

internal class CashierDeskContext
{
    private IPaymentStrategy _paymentStrategy;

	public CashierDeskContext()
	{
	}

	public CashierDeskContext(IPaymentStrategy paymentStrategy)
	{
		_paymentStrategy = paymentStrategy;
	}

	public void SetStrategy(IPaymentStrategy paymentStrategy)
	{
		_paymentStrategy = paymentStrategy;
	}

	public string Pay()
	{
		return _paymentStrategy.Pay();
	}
}
