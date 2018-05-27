using PriceCalculation.Model;

namespace PriceCalculation.Interface
{
    public interface IPriceCalculator
    {
        double Calculate(Basket basket);
    }
}
