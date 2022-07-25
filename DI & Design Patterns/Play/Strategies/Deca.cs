namespace Play.Strategies
{
    public class Deca : BaseClass, IStrategy
    {
        public string Name => "Deca";

        public bool IsValid(int number)
        {
            return number % 10 == 0;
        }
    }
}
