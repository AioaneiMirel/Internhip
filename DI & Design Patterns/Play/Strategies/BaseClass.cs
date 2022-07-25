namespace Play.Strategies
{
    public abstract class BaseClass
    {
        readonly List<int> numbers;

        protected BaseClass()
        {
            numbers = new List<int>();
        }

        public void Add(int number)
        {
            numbers.Add(number);
        }

        public List<int> GetNumbers()
        {
            return numbers;
        }
    }
}
