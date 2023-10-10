using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fremawork_Design_Guidelines
{
    internal class Naming_Parameters
    {
        public int Add(int operand1, int operand2)
        {
            return operand1 + operand2;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public double CalculateAverage(int[] valuesToAverage)
        {
            if (valuesToAverage.Length == 0)
                throw new ArgumentException("Array cannot be empty.", nameof(valuesToAverage));

            int sum = 0;
            foreach (var value in valuesToAverage)
            {
                sum += value;
            }

            return (double)sum / valuesToAverage.Length;
        }

        public bool IsEven(int numberToCheck)
        {
            return numberToCheck % 2 == 0;
        }
    }
}
