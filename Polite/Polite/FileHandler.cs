using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Configuration;

namespace Polite
{
    public class FileHandler
    {
        
  

        public List<Contact> getFileContents()
        {
            List<Contact> fileContentList = new List<Contact>();
            try
            {
               

                fileContentList = File.ReadAllLines(getCSVDirectory())
                                                .Skip(1)
                                                .Select(v => new
                                                 Contact(v))
                                                .ToList();
            }
            catch (Exception ex)
            {
                throw (ex);

            }

            return fileContentList;
        }

 

        public string getCSVDirectory()
        {
            string sSDirFilePath = string.Empty;

            if (ConfigurationManager.AppSettings.AllKeys.Contains("CSVDirectory"))
            {
                sSDirFilePath = ConfigurationManager.AppSettings["CSVDirectory"];
            }
         

            return sSDirFilePath;
        }

        public string getMyNameDirectory()
        {
            string sSDirFilePath = string.Empty;

            if (ConfigurationManager.AppSettings.AllKeys.Contains("myNamesDirectory"))
            {
                sSDirFilePath = ConfigurationManager.AppSettings["myNamesDirectory"];
            }


            return sSDirFilePath;
        }

        public string getMyAddresssDirectory()
        {
            string sSDirFilePath = string.Empty;

            if (ConfigurationManager.AppSettings.AllKeys.Contains("myAddresssDirectory"))
            {
                sSDirFilePath = ConfigurationManager.AppSettings["myAddresssDirectory"];
            }


            return sSDirFilePath;
        }
        public string getLogFileDirectory()
        {
            string sSDirFilePath = string.Empty;

            if (!ConfigurationManager.AppSettings.AllKeys.Contains("LogFileDirectory"))
            {

            }
            else
            {
                sSDirFilePath = ConfigurationManager.AppSettings["LogFileDirectory"];

            }

            return sSDirFilePath;
        }

    }
}
