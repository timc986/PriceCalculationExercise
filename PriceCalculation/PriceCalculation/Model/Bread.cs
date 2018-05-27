using System;

namespace PriceCalculation.Model
{
    public class Bread: Product
    {
        public readonly double Cost;

        //set up the cost once in the constructor
        public Bread(double cost)
        {
            Cost = cost;
        }

        //Rich data model
        //Logic to calculate price inside the model class
        //Can be easily reused in other class for future development
        public double GetPrice(double ButterAmount)
        {
            return (Cost * Amount) - Math.Floor((ButterAmount / 2)) * Cost * 0.5;
        }
    }
}
