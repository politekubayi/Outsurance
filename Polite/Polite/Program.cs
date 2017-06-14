using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polite
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHandler h = new FileHandler();
            FileProcessor f = new FileProcessor();
            string logFilePath = string.Empty;
            try
            {
                f.WriteSortedNamesToFile(f.SortNames(h.getFileContents()), h.getMyNameDirectory());
                f.WriteSortedAddressToFile(f.SortAddress(h.getFileContents()), h.getMyAddresssDirectory());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                h = new FileHandler();
                logFilePath = h.getLogFileDirectory();

                if (!File.Exists(logFilePath))
                {
                    File.WriteAllText(logFilePath, DateTime.Now + " " + ex.Message + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(logFilePath, DateTime.Now + " " + ex.Message + Environment.NewLine);
                }

                Console.Read();
            }
        }
    }
}
