namespace CarsFilterRefactored.Interfaces
{
    public interface ICondition<T>
    {
        bool IsSatisfied(T item);
    }
}