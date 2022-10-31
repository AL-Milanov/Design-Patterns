// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var context = new CashierDeskContext();

while (true)
{
    Console.WriteLine("How will you pay?");
    var answare = Console.ReadLine();

    var isNotSupported = false;

    switch (answare)
    {
        case "card": context.SetStrategy(new CardPaymentStrategy());
            break;
        case "money":
            context.SetStrategy(new MoneyPaymentStrategy());
            break;
        case "credit":
            context.SetStrategy(new CreditPaymentStrategy());
            break;
        default: 
            Console.WriteLine("Not supported payment.");
            isNotSupported = true;
            break;
    }

    if (!isNotSupported)
    {
        Console.WriteLine(context.Pay());
    }

    Console.WriteLine("Enter any key to continue or ESC to exit the application.");
    var key = Console.ReadKey().Key;

    if (key == ConsoleKey.Escape)
    {
        break;
    }

}