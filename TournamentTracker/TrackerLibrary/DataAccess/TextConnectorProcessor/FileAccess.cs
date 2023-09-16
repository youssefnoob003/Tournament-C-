using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.DataAccess.TextConnectorProcessor
{
    public static class FileAccess
    {
        public static string FullFilePath(this string name)
        {
            return $"{GlobalConfig.AppKeyLookup("FilePath")}\\{name}";
        }
        public static List<string> LoadFile(this string path)
        {
            if (File.Exists(path) == false)
            {
                return new List<string>();
            }

            return File.ReadAllLines(path).ToList();
        }
    }
}
