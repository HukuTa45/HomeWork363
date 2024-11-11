namespace ConsoleApp1;

public class PP
{
    public decimal PP(object platezhka)
    {
        if (platezhka is CreditCard)
        {
            return ProcessCreditCardPayment((CreditCard)platezhka);
        }
        else if (platezhka is PayPal)
        {
            return ProcessMirPayment((PayPal)platezhka);
        }
        else
        {
            throw new InvalidOperationException("Unsupported payment type");
        }
    }

    private decimal ProcessCreditCardPayment(CreditCard kreditka)
    {
        // Какая-то логика обработки платежа через кредитную карту
        return 100.00m;
    }

    private decimal ProcessMirPayment(Mir payPal)
    {
        // Какая-то логика обработки платежа через Mir
        return 150.00m;
    }
}