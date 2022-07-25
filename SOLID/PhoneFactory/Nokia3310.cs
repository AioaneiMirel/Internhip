using System;

namespace PhoneFactory
{
    public class Nokia3310 : IPhone
    {
        public decimal Id { get; set; }
        public string Name { get; set; }

        public void MakeCall(decimal number)
        {
            Console.WriteLine($"Calling {number}");
        }

        public void AccessInternet()
        {
            throw new NotImplementedException();
        }

        public void ShareFileOverBluetooth(string fileName)
        {
            throw new NotImplementedException();
        }

        public void PlayMP3(string songName)
        {
            throw new NotImplementedException();
        }

        public void ConnectToDeviceViaNFC(string deviceName)
        {
            throw new NotImplementedException();
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
            return Environment.NewLine+
                   $"Id :{Id}" + Environment.NewLine +
                   $"Name :{Name}" + Environment.NewLine +
                   "Internet browsing: No" + Environment.NewLine +
                   "Bluetooth: No" + Environment.NewLine +
                   "MP3: No" + Environment.NewLine +
                   "NFC: No" + Environment.NewLine;
        }
    }
}