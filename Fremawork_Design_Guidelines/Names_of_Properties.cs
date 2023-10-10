using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fremawork_Design_Guidelines
{
    internal class Names_of_Properties
    {
        // Auto-implemented property with a straightforward name
        public string FirstName { get; set; }

        // Property with a private backing field and a more descriptive name
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        // Read-only property with a computed value
        public int Age
        {
            get
            {
                // Calculate age based on birthdate; this is just a sample calculation.
                DateTime birthdate = new DateTime(1990, 1, 1);
                TimeSpan ageSpan = DateTime.Now - birthdate;
                int years = ageSpan.Days / 365;
                return years;
            }
        }

        // Property with a boolean value and a name indicating a question
        public bool IsStudent { get; set; }

        // Property with a custom data type
        public Address HomeAddress { get; set; }
    }

    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
    }

}

