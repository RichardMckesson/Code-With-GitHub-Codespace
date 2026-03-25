using System;

namespace Skills;

public class Members
{
    public string Name { get; set; }
    public int Var1 { get; set; }
    public int Var2 { get; set; }

    public Members(string name)
    {
        Name = name;
    }

    public void CalculateNumbers()
    {
        int sum = Var1 + Var2;
        int difference = Var1 - Var2;
        int product = Var1 * Var2;
        double quotient = (double)Var1 / Var2;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Quotient: {quotient}");
    }

}
