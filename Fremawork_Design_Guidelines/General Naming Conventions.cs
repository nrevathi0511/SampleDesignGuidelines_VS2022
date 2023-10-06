using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fremawork_Design_Guidelines
{
    internal class General_Naming_Conventions
    {
        // Private fields should start with an underscore and use camelCase
        private int _customerId;
        private string _customerName;

        // Properties should use PascalCase
        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        // Methods should use PascalCase
        public void SetCustomerName(string customerName)
        {
            // Local variables should use camelCase
            _customerName = customerName;
        }

        public string GetCustomerName()
        {
            return _customerName;
        }

        // Constants should be in uppercase with underscores
        public const int MaxAllowedOrders = 10;

        // Enums should use PascalCase
        public enum OrderStatus
        {
            Pending,
            Processing,
            Completed
        }
    }

}

