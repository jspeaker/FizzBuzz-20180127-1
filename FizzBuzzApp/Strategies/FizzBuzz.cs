namespace FizzBuzzApp.Strategies
{
    public class FizzBuzz : IFizzBuzzStrategy
    {
        private readonly int _value;
        private readonly IFizzBuzzStrategy _nextStrategy;

        public FizzBuzz(int value) : this(value, new Buzz(value)) { }

        public FizzBuzz(int value, IFizzBuzzStrategy nextStrategy)
        {
            _value = value;
            _nextStrategy = nextStrategy;
        }

        public override string ToString()
        {
            if (_value % 15 != 0) return _nextStrategy.ToString();

            return nameof(FizzBuzz).ToLower();
        }
    }
}