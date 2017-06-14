using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polite
{
    public class FileProcessor
    {

        public Dictionary<string,int> SortNames(List<Contact> contacts)
        {
            List<string> fullNames = new List<string>();
            var firstName = contacts.Select(c => c.FirstName).ToList<string>();
            var lastName = contacts.Select(c => c.LastName).ToList<string>();

            fullNames = firstName;
            fullNames.AddRange(lastName);

            var sortedNames = fullNames.GroupBy(a => a).ToDictionary(a=>a.Key,a=>a.Count());
            
            return sortedNames.OrderByDescending(x => x.Value).ThenBy(x=>x.Key).ToDictionary(x => x.Key, x => x.Value);
        }

        public Dictionary<int, string> SortAddress(List<Contact> contacts)
        {
            var SortedList = contacts.ToDictionary(a=>a.StreetNumber,a=>a.StreetName);
                                
            return SortedList.OrderBy(a => a.Value).ToDictionary(x => x.Key, x => x.Value);
        }

        public void WriteSortedNamesToFile(Dictionary<string,int> sortedNames,string fileName)
        {
            using (StreamWriter file = new StreamWriter(fileName))
                foreach (var entry in sortedNames)
                    
                    file.WriteLine("{0}, {1}", entry.Key,entry.Value);
        }

        public void WriteSortedAddressToFile(Dictionary<int,string> sortedAddresses, string fileName)
        {
            using (StreamWriter file = new StreamWriter(fileName))
                foreach (var entry in sortedAddresses)

                    file.WriteLine("{0} {1}", entry.Key, entry.Value);
        }
    }
}
