using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fremawork_Design_Guidelines
{
   public enum DayOfWeek
    {
        Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
    }

    // Singular type name for an enumeration with non-bit field values
    public enum Gender
    {
        Male,
        Female,
        Other
    }

    // Plural type name for an enumeration with bit field values (flags enum)
    [Flags]
    public enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4
    }

}

