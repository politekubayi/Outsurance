using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polite
{
    public class Contact
    {
       public Contact(String csvLine)
        {
           string[] values = csvLine.Split(',');
  

            this.FirstName = values[0];
            this.LastName = values[1];
            this.StreetNumber = int.Parse(values[2].Substring(0, values[2].IndexOf(" ")));

            this.StreetName = values[2].Substring(values[2].IndexOf(" ")+1);
            this.PhoneNumber = int.Parse(values[3]);
        }

        public string FirstName {get; set;}
        public string LastName { get; set; }
        public int StreetNumber{ get; set; }
        public string StreetName { get; set; }
        public int PhoneNumber { get; set; }

    }

   

}
