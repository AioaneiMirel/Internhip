using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new Store();

            foreach (var car in store)
            {
                Console.WriteLine(car.ToString());
            }

            Console.ReadLine();
        }
    }
}
