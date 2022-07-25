namespace Play.Strategies
{
    public class Positiv : BaseClass, IStrategy
    {
        public string Name => "Positiv";

        public bool IsValid(int number)
        {
            return number >= 0;
        }
    }
}
