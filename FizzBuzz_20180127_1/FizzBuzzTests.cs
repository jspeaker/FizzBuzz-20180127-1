using FizzBuzzApp;
using FizzBuzzApp.Strategies;
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
            FizzBuzzApplication fizzBuzzApplication = new FizzBuzzApplication(new FakeStrategy());

            // act
            string one = fizzBuzzApplication.ToString();

            // assert
            one.Should().Be("foobar");
        }
    }

    public class FakeStrategy : IFizzBuzzStrategy
    {
        public override string ToString()
        {
            return "foobar";
        }
    }
}