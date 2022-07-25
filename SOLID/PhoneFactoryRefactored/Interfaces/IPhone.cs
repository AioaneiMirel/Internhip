namespace PhoneFactoryRefactored.Interfaces
{
    public interface IPhone
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        void MakeCall(decimal number);
        void PowerOn();
        void PowerOff();
        string GetInformation();
    }
}