using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fremawork_Design_Guidelines
{
    internal class Structs
    {
        // Define a struct called Structs
        public int X;
            public int Y;

        // Constructor for the Structs struct
        public Structs(int x, int y)
            {
                X = x;
                Y = y;
        }

            // Method to display the coordinates of the point
            public void Display()
            {
                Console.WriteLine($"X: {X}, Y: {Y}");
            }
    }
}


