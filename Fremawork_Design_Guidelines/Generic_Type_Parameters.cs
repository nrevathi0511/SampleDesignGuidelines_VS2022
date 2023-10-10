using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fremawork_Design_Guidelines
{
    internal class GenericList<T>
    {
        private List<T> _list = new List<T>();

        public void Add(T item)
        {
            _list.Add(item);
        }

        public T GetItem(int index)
        {
            if (index >= 0 && index < _list.Count)
            {
                return _list[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }

    public class NumericCalculator<T>
    {
        public T Add(T a, T b)
        {
            // This constraint ensures that T supports the '+' operator
            if (typeof(T) == typeof(int) || typeof(T) == typeof(double) || typeof(T) == typeof(decimal))
            {
                dynamic dynamicA = a;
                dynamic dynamicB = b;
                return dynamicA + dynamicB;
            }
            else
            {
                throw new InvalidOperationException("Type T does not support addition.");
            }
        }
    }
}
