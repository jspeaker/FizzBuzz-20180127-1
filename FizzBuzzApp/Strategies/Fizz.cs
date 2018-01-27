namespace FizzBuzzApp.Strategies
{
    public class Fizz : IFizzBuzzStrategy
    {
        private readonly int _value;
        private readonly IFizzBuzzStrategy _nextStrategy;

        public Fizz(int value) : this(value, new Default(value)) { }

        public Fizz(int value, IFizzBuzzStrategy nextStrategy)
        {
            _value = value;
            _nextStrategy = nextStrategy;
        }

        public override string ToString()
        {
            if (_value % 3 != 0) return _nextStrategy.ToString();

            return nameof(Fizz).ToLower();
        }
    }
}