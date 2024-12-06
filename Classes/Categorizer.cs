namespace CreditSuiss;

public static class Categorizer
{
    public static string Categorize(ITrade trade, DateTime referenceDate) => trade switch
    {
        { NextPaymentDate: var date } when date < referenceDate.AddDays(-30) => "EXPIRED",
        { Value: > 1000000, ClientSector: "Private" } => "HIGHRISK",
        { Value: > 1000000, ClientSector: "Public" } => "MEDIUMRISK",
        _ => "UNCATEGORIZED"
    };
}
