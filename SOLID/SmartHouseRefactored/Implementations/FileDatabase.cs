using System.Collections.Generic;
using System.IO;
using SmartHouseRefactored.Interfaces;

namespace SmartHouseRefactored.Implementations
{
    public class FileDatabase : IDatabase
    {
        private readonly string _filePath = "D:\\History.txt";

        public decimal GetAccessCode()
        {
            return 1234;
        }

        public string GetStatus()
        {
            return File.ReadAllText(_filePath);
        }

        public void Save(string performedAction)
        {
            File.AppendAllLines(_filePath, new List<string> {performedAction});
        }
    }
}