namespace RandomNumbers
{
    class PseudoRandom
    {
        private int _value;

        public PseudoRandom(int value)
        {
            _value = value;
        }

        public int Next()
        {
            int val = _value * _value;

            string text = $"{val:d8}";

            text = text.Substring(2, 4);

            _value = int.Parse(text);

            return _value;
        }
    }
}
