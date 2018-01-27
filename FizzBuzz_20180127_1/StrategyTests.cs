using FizzBuzzApp.Strategies;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz_20180127_1
{
    [TestFixture]
    public class StrategyTests
    {
        [Test, Category("Unit")]
        public void GivenTwo_WhenCallingDefaultStrategy_ThenItShouldReturnNumberAsString()
        {
            // arrange
            IFizzBuzzStrategy defaultStrategy = new Default(2);

            // act
            string two = defaultStrategy.ToString();

            // assert
            two.Should().Be("2");
        }

        [Test, Category("Unit")]
        public void GivenThree_WhenCallingFizzStrategy_ThenItShouldReturnFizz()
        {
            // arrange
            const int value = 3;
            IFizzBuzzStrategy fizzStrategy = new Fizz(value, new Default(value));

            // act
            string three = fizzStrategy.ToString();

            // assert
            three.Should().Be("fizz");
        }

        [Test, Category("Unit")]
        public void GivenTwo_WhenCallingFizzStrategy_ThenItShouldReturnNumberAsString()
        {
            // arrange
            const int value = 2;
            IFizzBuzzStrategy fizzStrategy = new Fizz(value, new Default(value));

            // act
            string two = fizzStrategy.ToString();

            // assert
            two.Should().Be("2");
        }

        [Test, Category("Unit")]
        public void GivenFive_WhenCallingFizzStrategy_ThenItShouldReturnBuzz()
        {
            // arrange
            const int value = 5;
            IFizzBuzzStrategy fizzStrategy = new Buzz(value, new Default(value));

            // act
            string five = fizzStrategy.ToString();

            // assert
            five.Should().Be("buzz");
        }

        [Test, Category("Unit")]
        public void GivenTwo_WhenCallingBuzzStrategy_ThenItShouldReturnNumberAsString()
        {
            // arrange
            const int value = 2;
            IFizzBuzzStrategy fizzStrategy = new Buzz(value, new Default(value));

            // act
            string two = fizzStrategy.ToString();

            // assert
            two.Should().Be("2");
        }

        [Test, Category("Unit")]
        public void GivenFifteen_WhenCallingFizzBuzzStrategy_ThenItShouldReturnFizzBuzz()
        {
            // arrange
            const int value = 15;
            IFizzBuzzStrategy fizzBuzzStrategy = new FizzBuzz(value, new Default(value));

            // act
            string fifteen = fizzBuzzStrategy.ToString();

            // assert
            fifteen.Should().Be("fizzbuzz");
        }

        [Test, Category("Unit")]
        public void GivenTwo_WhenCallingFizzBuzzStrategy_ThenItShouldReturnNumberAsString()
        {
            // arrange
            const int value = 2;
            IFizzBuzzStrategy fizzBuzzStrategy = new FizzBuzz(value, new Default(value));

            // act
            string two = fizzBuzzStrategy.ToString();

            // assert
            two.Should().Be("2");
        }
    }
}