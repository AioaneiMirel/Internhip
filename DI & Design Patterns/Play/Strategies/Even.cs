namespace Play.Strategies
{
    public class Even : BaseClass, IStrategy
    {

        public string Name => "Even";

        public bool IsValid(int number)
        {
            return number % 2 == 0;
        }
    }
}
