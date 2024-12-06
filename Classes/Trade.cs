namespace CreditSuiss;

public class Trade : ITrade
{
    public  double Value { get; init; }
    public  string ClientSector { get; init; }
    public  DateTime NextPaymentDate { get; init; }


    public Trade(double value, string clientSector, DateTime nextPaymentDate)
    {
        Value = value;
        ClientSector = clientSector;
        NextPaymentDate = nextPaymentDate;

    }
}

