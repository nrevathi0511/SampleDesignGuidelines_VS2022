using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fremawork_Design_Guidelines
{
    internal class Class_Struct
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    // Define a class for representing a customer
    public class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Customer(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
}
