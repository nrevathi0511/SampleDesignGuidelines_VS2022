using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fremawork_Design_Guidelines
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public enum OrderStatus
    {
        // DO use PascalCase for enum values
        Pending,
        Processing,
        Shipped,
        Delivered
    }

    // DO use descriptive names for exceptions
    public class CustomAppException : Exception
    {
        public CustomAppException(string message) : base(message)
        {
        }
    }

    // DO use meaningful names for interfaces
    public interface IResizable
    {
        void Resize(int width, int height);
    }

}

