namespace PhoneFactory
{
    public interface IPhone
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        void MakeCall(decimal number);
        void AccessInternet();
        void ShareFileOverBluetooth(string fileName);
        void PlayMP3(string songName);
        void ConnectToDeviceViaNFC(string deviceName);
        void PowerOn();
        void PowerOff();
        string GetInformation();
    }
}