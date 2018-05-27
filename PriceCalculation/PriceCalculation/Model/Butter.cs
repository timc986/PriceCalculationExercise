namespace PriceCalculation.Model
{
    public class Butter: Product
    {
        public readonly double Cost;

        //set up the cost once in the constructor
        public Butter(double cost)
        {
            Cost = cost;
        }

        //Rich data model
        //Logic to calculate price inside the model class
        //Can be easily reused in other class for future development
        public double GetPrice()
        {
            return Cost * Amount;
        }
    }
}
