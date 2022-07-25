namespace PhoneFactoryRefactored.Interfaces
{
    public interface Conectivity
    {
        void ShareFileOverBluetooth(string fileName);
        void ConnectToDeviceViaNFC(string deviceName);
    }
}