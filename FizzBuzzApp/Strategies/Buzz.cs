namespace FizzBuzzApp.Strategies
{
    public class Buzz : IFizzBuzzStrategy
    {
        private readonly int _value;
        private readonly IFizzBuzzStrategy _nextStrategy;

        public Buzz(int value) : this(value, new Fizz(value)) { }

        public Buzz(int value, IFizzBuzzStrategy nextStrategy)
        {
            _value = value;
            _nextStrategy = nextStrategy;
        }

        public override string ToString()
        {
            if (_value % 5 != 0) return _nextStrategy.ToString();

            return nameof(Buzz).ToLower();
        }
    }
}