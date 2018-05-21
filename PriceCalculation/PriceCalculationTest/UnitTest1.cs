using System;
using NUnit.Framework;
using PriceCalculation.Interface;
using PriceCalculation;

namespace PriceCalculationTest
{
    [TestFixture]
    public class UnitTest1
    {
        private IPriceCalculator priceCalculator;


        [SetUp]
        public void Setup()
        {
            //Arrange
            priceCalculator = new PriceCalculator();
        }

        [Test]
        public void GIVEN_the_basket_has_1_bread_1_butter_1_milk_WHEN_I_total_the_basket_THEN_the_total_should_be_2_95()
        {
            //Arrange
            var request = new BasketRequest()
            {
                
            };

            //Act
            var response = priceCalculator.Calculate(request);

            //Assert
            Assert.AreEqual(2.95, response.Total);
        }

        [Test]
        public void GIVEN_the_basket_has_2_butter_and_2_bread_WHEN_I_total_the_basket_THEN_the_total_should_be_3_10()
        {
            //Arrange
            var request = new BasketRequest()
            {

            };

            //Act
            var response = priceCalculator.Calculate(request);

            //Assert
            Assert.AreEqual(3.1, response.Total);
        }

        [Test]
        public void GIVEN_the_basket_has_4_milk_WHEN_I_total_the_basket_THEN_total_should_be_3_45()
        {
            //Arrange
            var request = new BasketRequest()
            {

            };

            //Act
            var response = priceCalculator.Calculate(request);

            //Assert
            Assert.AreEqual(3.45, response.Total);
        }

        [Test]
        public void GIVEN_the_basket_has_2_butter_1_bread_8_milk_WHEN_I_total_the_basket_THEN_the_total_should_be_9()
        {
            //Arrange
            var request = new BasketRequest()
            {

            };

            //Act
            var response = priceCalculator.Calculate(request);

            //Assert
            Assert.AreEqual(9, response.Total);
        }
    }
}
