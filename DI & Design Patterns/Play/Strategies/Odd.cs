namespace Play.Strategies
{
    public class Odd : BaseClass, IStrategy
    {
        public string Name => "Odd";

        public bool IsValid(int number)
        {
            return number % 2 != 0;
        }
    }
}
