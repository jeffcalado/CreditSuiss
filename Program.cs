using System.Globalization;
using CreditSuiss;


DateTime referenceDate = DateTime.ParseExact(Console.ReadLine()!, "MM/dd/yyyy", CultureInfo.InvariantCulture);

int n = int.Parse(Console.ReadLine()!);

var trades = new List<ITrade>();

for (int i = 0; i < n; i++)
{

    var input = Console.ReadLine()!.Split(' ');
    trades.Add(new Trade(
        value: double.Parse(input[0]),
        clientSector: input[1],
        nextPaymentDate: DateTime.ParseExact(input[2], "MM/dd/yyyy", CultureInfo.InvariantCulture)
        
    ));
}

Console.WriteLine("\nTrade Categories:");
foreach (var trade in trades)
{
    Console.WriteLine(Categorizer.Categorize(trade, referenceDate));
}

