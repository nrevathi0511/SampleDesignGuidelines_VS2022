using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fremawork_Design_Guidelines
{
    public class Capitalization_Conventions
    {
        public string MyProperty { get; set; }

     public void MyMethod()                 // PascalCasing for method name
     {
            int myVariable = 42;            // camelCasing for parameter names
            Console.WriteLine(myVariable);
     }

    public event EventHandler MyEvent;       // PascalCasing for event name
    public enum DaysOfWeek                  // PascalCasing for enum type and enum values
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
