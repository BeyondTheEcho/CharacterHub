using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterHub
{
    public class FileSystemManager
    {
        private const string c_RootFolderPath = "\\CharacterHub";

        public FileSystemManager()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + c_RootFolderPath;
            Directory.CreateDirectory(path);

            //Logging
            Console.WriteLine($"Check/Creating path to: {path}");
        }

        public string GetPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + c_RootFolderPath;
        }
    }
}
