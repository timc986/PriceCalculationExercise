using PriceCalculation.Interface;
using PriceCalculation.Model;
using System;

namespace PriceCalculation
{
    public class PriceCalculator: IPriceCalculator
    {
        public double Calculate(Basket basket)
        {
            double total = 0;

            if (basket == null)
            {
                //Can also throw an custom exception and log it if required
                return total;
            }

            if(basket.Butter != null)
            {
                total += basket.Butter.GetPrice();
            }            

            if(basket.Bread != null)
            {
                total += basket.Bread.GetPrice(basket.Butter!= null ? basket.Butter.Amount : 0);
            }           

            if(basket.Milk != null)
            {
                total += basket.Milk.GetPrice();
            }           
            
            //Round up to 2 decimal digits as the price on the document only has 2 decimal deigits
            return Math.Round(total, 2);
        }
    }
}
