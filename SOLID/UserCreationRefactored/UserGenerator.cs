using System;

namespace UserCreationRefactored
{
    public class UserGenerator
    {
        public static void Create(Person person)
        {
            Console.WriteLine($"Your new username is {person.FirstName.Substring(0, 1)}{person.LastName}");
        }
    }
}
