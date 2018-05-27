using System;

namespace PriceCalculation.Model
{
    public class Milk: Product
    {
        public readonly double Cost;

        //set up the cost once in the constructor
        public Milk(double cost)
        {
            Cost = cost;
        }

        //Rich data model
        //Logic to calculate price inside the model class
        //Can be easily reused in other class for future development
        public double GetPrice()
        {
            return (Cost * Amount) - Math.Floor(Amount / 3) * Cost;
        }
    }
}
