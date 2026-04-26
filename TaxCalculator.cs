public class TaxCalculator
{
    public int AddTax(int price)
    {
        // 本来10%税込みにするはず
        return price + price * 10;
    }
}