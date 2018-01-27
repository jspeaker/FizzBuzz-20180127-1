using FizzBuzzApp.Strategies;

namespace FizzBuzzApp
{
    public class FizzBuzzApplication
    {
        private readonly IFizzBuzzStrategy _fizzBuzzStrategy;

        public FizzBuzzApplication(int value) : this(new FizzBuzz(value)) { }

        public FizzBuzzApplication(IFizzBuzzStrategy fizzBuzzStrategy)
        {
            _fizzBuzzStrategy = fizzBuzzStrategy;
        }

        public override string ToString()
        {
            return _fizzBuzzStrategy.ToString();
        }
    }
}