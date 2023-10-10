using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fremawork_Design_Guidelines
{
    internal class Names_of_Methods
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // Method with a meaningful name
        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        // Method with parameters and a return value
        public double CalculateAverage(int[] numbers)
        {
            if (numbers.Length == 0)
                throw new ArgumentException("Array cannot be empty.");

            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }

            return (double)sum / numbers.Length;
        }

        // Method with a boolean return type indicating a question
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // Method with a void return type and a callback action
        public void ProcessNumbers(int[] numbers, Action<int> processAction)
        {
            foreach (var num in numbers)
            {
                processAction(num);
            }
        }
    }

}

