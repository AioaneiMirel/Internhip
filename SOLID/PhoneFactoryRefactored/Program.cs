using System;
using PhoneFactoryRefactored.Phones;

namespace PhoneFactoryRefactored
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var p30 = new HuaweiP30();
            p30.Id = 123;
            p30.Name = "HuaweiP30";
            p30.PowerOn();
            p30.AccessInternet();
            p30.ConnectToDeviceViaNFC("TV");
            p30.MakeCall(0272727272);
            p30.PlayMP3("song.mp3");
            p30.ShareFileOverBluetooth("file.txt");
            Console.WriteLine(p30.GetInformation());
            p30.PowerOff();

            var samsung = new Samsung();
            samsung.Id = 456;
            samsung.Name = "Nokia 3310";
            samsung.PowerOn();
            samsung.AccessInternet();
            //samsung.ConnectToDeviceViaNFC("TV");
            samsung.MakeCall(0272727272);
            samsung.PlayMP3("song.mp3");
            //samsung.ShareFileOverBluetooth("file.txt");
            Console.WriteLine(samsung.GetInformation());
            samsung.PowerOff();

            var nokia3310 = new Nokia3310();
            nokia3310.Id = 456;
            nokia3310.Name = "Nokia 3310";
            nokia3310.PowerOn();
            //nokia3310.AccessInternet();
            //nokia3310.ConnectToDeviceViaNFC("TV");
            nokia3310.MakeCall(0272727272);
            //nokia3310.PlayMP3("song.mp3");
            //nokia3310.ShareFileOverBluetooth("file.txt");
            Console.WriteLine(nokia3310.GetInformation());
            nokia3310.PowerOff();
        }
    }
}