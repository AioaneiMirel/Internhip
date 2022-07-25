namespace Play.Strategies
{
    public interface IStrategy
    {
        string Name { get; }

        List<int> GetNumbers();

        void Add(int number);

        bool IsValid(int number);
    }
}
