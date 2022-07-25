using System;

namespace UserCreationRefactored
{
    public class Messages
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to user creation app!");
        }

        public static void CloseApplication()
        {
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }

        public static void ShowValidationErrorFor(string fieldName)
        {
            Console.WriteLine($"{fieldName} is not valid!");
        }
    }
}
