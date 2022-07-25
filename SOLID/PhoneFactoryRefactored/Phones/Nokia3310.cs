using System;
using PhoneFactoryRefactored.Interfaces;

namespace PhoneFactoryRefactored.Phones
{
    public class Nokia3310 : IPhone
    {
        public decimal Id { get; set; }
        public string Name { get; set; }

        public void MakeCall(decimal number)
        {
            Console.WriteLine($"Calling {number}");
        }

        public void PowerOn()
        {
            Console.WriteLine("Power is on!");
        }

        public void PowerOff()
        {
            Console.WriteLine("Device is shooting down!" + Environment.NewLine);
        }

        public string GetInformation()
        {
            return Environment.NewLine +
                   $"Id :{Id}" + Environment.NewLine +
                   $"Name :{Name}" + Environment.NewLine +
                   "Internet browsing: No" + Environment.NewLine +
                   "Bluetooth: No" + Environment.NewLine +
                   "MP3: No" + Environment.NewLine +
                   "NFC: No" + Environment.NewLine;
        }
    }
}