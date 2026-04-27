using System;
using System.Threading.Channels;

class Program
{
    static void Main()
    {
        var calc = new TaxCalculator();

        int price = 1000;

        int result = calc.AddTax(price);

        Console.WriteLine("REMOTE CHANGE visual studioで更新③");
    }
}