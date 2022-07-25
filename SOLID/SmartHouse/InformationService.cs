namespace SmartHouse
{
    public class InformationService
    {
        private readonly FileDatabase _fileDatabase;

        public InformationService(FileDatabase fileDatabase)
        {
            _fileDatabase = fileDatabase;
        }

        public string GetInformation()
        {
            return _fileDatabase.GetStatus();
        }
    }
}