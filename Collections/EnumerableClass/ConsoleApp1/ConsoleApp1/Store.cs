using System.Collections;

namespace ConsoleApp1
{
    public class Store : IEnumerable, IEnumerator
    {
        public Car[] Cars { get; set; }
        int position = -1;

        public Store()
        {
            Cars = new[] { new Car() { Id = 1, Name = "a" }, new Car() { Id = 2, Name = "b" }, new Car() { Id = 3, Name = "c" }, };
        }
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this; 
        }

        public bool MoveNext()
        {
            position++;
            return (position < Cars.Length);
        }

        public void Reset()
        {
            position = 0;
        }

        public object Current
        {
            get
            {
                return Cars[position];
            }
        }
    }
}
