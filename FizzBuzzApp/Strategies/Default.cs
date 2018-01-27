namespace FizzBuzzApp.Strategies
{
    public class Default : IFizzBuzzStrategy
    {
        private readonly int _value;

        public Default(int value)
        {
            _value = value;
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}