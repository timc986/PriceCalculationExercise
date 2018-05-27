using NUnit.Framework;
using PriceCalculation.Model;

namespace PriceCalculationTest.Model
{
    [TestFixture]
    public class BreadTest
    {
        private Bread bread;
        private double cost = 1;
        private int butterAmount = 1;

        [SetUp]
        public void Setup()
        {
            //Arrange
            bread = new Bread(cost);
        }

        [Test]
        public void GIVEN_1_bread_WHEN_GetPrice_THEN_should_return_1()
        {
            //Arrange
            bread.Amount = 1;

            //Act
            var result = bread.GetPrice(butterAmount);

            //Assert
            Assert.AreEqual(cost * bread.Amount, result);
        }

        [Test]
        public void GIVEN_1_bread_0_butter_WHEN_GetPrice_THEN_should_return_1()
        {
            //Arrange
            bread.Amount = 1;

            //Act
            var result = bread.GetPrice(0);

            //Assert
            Assert.AreEqual(cost * bread.Amount, result);
        }

        [Test]
        public void GIVEN_0_bread_WHEN_GetPrice_THEN_should_return_0()
        {
            //Arrange
            bread.Amount = 0;

            //Act
            var result = bread.GetPrice(butterAmount);

            //Assert
            Assert.AreEqual(cost * bread.Amount, result);
        }

        [Test]
        public void GIVEN_null_bread_Amount_WHEN_GetPrice_THEN_should_return_0()
        {
            //Act
            var result = bread.GetPrice(butterAmount);

            //Assert
            Assert.AreEqual(cost * bread.Amount, result);
        }
    }
}
