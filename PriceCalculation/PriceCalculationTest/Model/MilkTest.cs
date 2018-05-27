using NUnit.Framework;
using PriceCalculation.Model;

namespace PriceCalculationTest.Model
{
    [TestFixture]
    public class MilkTest
    {
        private Milk milk;
        private double cost = 1.15;

        [SetUp]
        public void Setup()
        {
            //Arrange
            milk = new Milk(cost);
        }

        [Test]
        public void GIVEN_1_milk_WHEN_GetPrice_THEN_should_return_1_15()
        {
            //Arrange
            milk.Amount = 1;

            //Act
            var result = milk.GetPrice();

            //Assert
            Assert.AreEqual(cost * milk.Amount, result);
        }

        [Test]
        public void GIVEN_0_milk_WHEN_GetPrice_THEN_should_return_0()
        {
            //Arrange
            milk.Amount = 0;

            //Act
            var result = milk.GetPrice();

            //Assert
            Assert.AreEqual(cost * milk.Amount, result);
        }

        [Test]
        public void GIVEN_null_milk_Amount_WHEN_GetPrice_THEN_should_return_0()
        {
            //Act
            var result = milk.GetPrice();

            //Assert
            Assert.AreEqual(cost * milk.Amount, result);
        }
    }
}
