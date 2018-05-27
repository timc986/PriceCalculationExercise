using System;
using NUnit.Framework;
using PriceCalculation.Interface;
using PriceCalculation;
using PriceCalculation.Model;

namespace PriceCalculationTest
{
    [TestFixture]
    public class PriceCalculatorTest
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
            var request = new Basket()
            {
                Bread = new Bread() { Amount = 1},
                Butter = new Butter() { Amount = 1},
                Milk = new Milk() { Amount = 1}
            };

            //Act
            var result = priceCalculator.Calculate(request);

            //Assert
            Assert.AreEqual(2.95, result);
        }

        [Test]
        public void GIVEN_the_basket_has_2_butter_and_2_bread_WHEN_I_total_the_basket_THEN_the_total_should_be_3_10()
        {
            //Arrange
            var request = new Basket()
            {
                Bread = new Bread() { Amount = 2 },
                Butter = new Butter() { Amount = 2 }
            };

            //Act
            var result = priceCalculator.Calculate(request);

            //Assert
            Assert.AreEqual(3.1, result);
        }

        [Test]
        public void GIVEN_the_basket_has_4_milk_WHEN_I_total_the_basket_THEN_total_should_be_3_45()
        {
            //Arrange
            var request = new Basket()
            {
                Milk = new Milk() { Amount = 4 }
            };

            //Act
            var result = priceCalculator.Calculate(request);

            //Assert
            Assert.AreEqual(3.45, result);
        }

        [Test]
        public void GIVEN_the_basket_has_2_butter_1_bread_8_milk_WHEN_I_total_the_basket_THEN_the_total_should_be_9()
        {
            //Arrange
            var request = new Basket()
            {
                Bread = new Bread() { Amount = 1 },
                Butter = new Butter() { Amount = 2 },
                Milk = new Milk() { Amount = 8 }
            };

            //Act
            var result = priceCalculator.Calculate(request);

            //Assert
            Assert.AreEqual(9, result);
        }

        [Test]
        public void GIVEN_the_basket_has_0_butter_0_bread_0_milk_WHEN_I_total_the_basket_THEN_the_total_should_be_0()
        {
            //Arrange
            var request = new Basket()
            {
                Bread = new Bread() { Amount = 0 },
                Butter = new Butter() { Amount = 0 },
                Milk = new Milk() { Amount = 0 }
            };

            //Act
            var result = priceCalculator.Calculate(request);

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void GIVEN_the_basket_has_no_item_WHEN_I_total_the_basket_THEN_the_total_should_be_0()
        {
            //Arrange
            var request = new Basket(){};

            //Act
            var result = priceCalculator.Calculate(request);

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void GIVEN_null_WHEN_I_total_the_basket_THEN_the_total_should_be_0()
        {
            //Act
            var result = priceCalculator.Calculate(null);

            //Assert
            Assert.AreEqual(0, result);
        }
    }
}
