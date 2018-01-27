namespace FizzBuzz_20180127_1
{
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