using NUnit.Framework;
using PriceCalculation.Model;

namespace PriceCalculationTest.Model
{
    [TestFixture]
    public class ButterTest
    {
        private Butter butter;
        private double cost = 0.8;

        [SetUp]
        public void Setup()
        {
            //Arrange
            butter = new Butter(cost);
        }

        [Test]
        public void GIVEN_1_butter_WHEN_GetPrice_THEN_should_return_0_8()
        {
            //Arrange
            butter.Amount = 1;

            //Act
            var result = butter.GetPrice();

            //Assert
            Assert.AreEqual(cost * butter.Amount, result);
        }

        [Test]
        public void GIVEN_0_butter_WHEN_GetPrice_THEN_should_return_0()
        {
            //Arrange
            butter.Amount = 0;

            //Act
            var result = butter.GetPrice();

            //Assert
            Assert.AreEqual(cost * butter.Amount, result);
        }

        [Test]
        public void GIVEN_null_butter_Amount_WHEN_GetPrice_THEN_should_return_0()
        {
            //Act
            var result = butter.GetPrice();

            //Assert
            Assert.AreEqual(cost * butter.Amount, result);
        }
    }
}
