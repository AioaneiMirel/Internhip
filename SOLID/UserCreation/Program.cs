using System;

namespace UserCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user creation app!");

            var user = new Person();

            Console.WriteLine("Enter your first name:");
            user.FirstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            user.LastName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                Console.WriteLine("First name is not valid!");
                Console.ReadLine();
                return;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                Console.WriteLine("Last name is not valid!");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"Your new username is {user.FirstName.Substring(0, 1)}{user.LastName}");

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
