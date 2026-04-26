public class PriceCalculator
{
    public int CalculateTotal(int price, int quantity)
    {
        int total = 0;

        for (int i = 0; i < quantity; i++)
        {
            total += price;
        }

        return total;
    }
}