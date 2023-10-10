using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fremawork_Design_Guidelines
{
    internal class Person
    {
        private string _firstName;
        private string _lastName;

        // Public fields are rarely used, but if used, they should be named using PascalCase
        public int Age;

        // Constructors can initialize fields
        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        // Methods can access private fields
        public void PrintFullName()
        {
            Console.WriteLine($"Full Name: {_firstName} {_lastName}");
        }

        // Properties provide controlled access to private fields
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
    }
}
    
