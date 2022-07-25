using System;

namespace UserCreationRefactored
{
    public class InputCapture
    {
        public static Person Capture()
        {
            var result = new Person();

            Console.WriteLine("Enter your first name:");
            result.FirstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            result.LastName = Console.ReadLine();

            return result;
        }
    }
}
