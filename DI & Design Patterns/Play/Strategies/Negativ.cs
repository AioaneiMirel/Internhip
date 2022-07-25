namespace Play.Strategies
{
    public class Negativ : BaseClass, IStrategy
    {
        public string Name => "Negativ";

        public bool IsValid(int number)
        {
            return number < 0;
        }
    }
}
