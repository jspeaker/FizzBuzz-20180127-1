using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz_20180127_1
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test, Category("Unit")]
        public void GivenTwo_WhenAskingToString_ThenItShouldReturnTwoAsString()
        {
            // arrange
            FizzBuzz fizzBuzz = new FizzBuzz(2);

            // act
            string one = fizzBuzz.ToString();

            // assert
            one.Should().Be("2");
        }

        [Test, Category("Unit")]
        public void GivenSix_WhenAskingToString_ThenItShouldReturnFizz()
        {
            // arrange
            FizzBuzz fizzBuzz = new FizzBuzz(6);

            // act
            string fizz = fizzBuzz.ToString();

            // assert
            fizz.Should().Be("fizz");
        }

        [Test, Category("Unit")]
        public void GivenTen_WhenAskingToString_ThenItShouldReturnBuzz()
        {
            // arrange
            FizzBuzz fizzBuzz = new FizzBuzz(10);

            // act
            string buzz = fizzBuzz.ToString();

            // assert
            buzz.Should().Be("buzz");
        }

        [Test, Category("Unit")]
        public void GivenThirty_WhenAskingToString_ThenItShouldReturnFizzBuzz()
        {
            // arrange
            FizzBuzz fizzBuzz = new FizzBuzz(30);

            // act
            string buzz = fizzBuzz.ToString();

            // assert
            buzz.Should().Be("fizzbuzz");
        }
    }

    public class FizzBuzz
    {
        private readonly int _value;

        public FizzBuzz(int value)
        {
            _value = value;
        }

        public override string ToString()
        {
            if (_value % 15 == 0) return "fizzbuzz";

            if (_value % 5 == 0) return "buzz";

            if (_value % 3 == 0) return "fizz";

            return _value.ToString();
        }
    }
}