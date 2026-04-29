using System;
using System.Threading.Channels;

class Program
{
    static void Main()
    {

        try
        {
            int x = int.Parse("abc");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"エラー発生: {ex.Message}");
            Console.WriteLine($"スタックトレース: {ex.StackTrace}");
        }
        var calc = new TaxCalculator();

        int price = 1000;

        int result = calc.AddTax(price);

        Console.WriteLine("REMOTE CHANGE visual studioで更新feature1/2_");
    }
}