using System;

record Transaction(int Month, decimal Amount);

class Program
{
    static void Main()
    {
        Transaction[] transactions = new Transaction[]
        {
            new Transaction(1, 1500m),
            new Transaction(3, 2000m),
            new Transaction(1, 500m),
            new Transaction(12, 3500m),
            new Transaction(3, 800m)
        };

        decimal[] monthlyTotals = new decimal[12];

        foreach (var t in transactions)
        {
            monthlyTotals[t.Month - 1] += t.Amount;
        }

        Console.WriteLine("=== Підсумки продажів за місяцями ===");
        for (int m = 0; m < monthlyTotals.Length; m++)
        {
            Console.WriteLine($"Місяць {m + 1}: {monthlyTotals[m]} грн");
        }
    }
}
