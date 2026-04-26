using System;

class Program
{
    static void Main(string[] args)
    {
        var calculator = new PriceCalculator();

        int price = 100;
        int quantity = 3;

        int total = calculator.CalculateTotal(price, quantity);

        Console.WriteLine($"合計金額: {total}");
        Console.ReadLine();
    }
}