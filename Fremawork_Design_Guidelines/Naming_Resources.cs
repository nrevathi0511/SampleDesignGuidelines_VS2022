using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fremawork_Design_Guidelines
{
    internal class Naming_Resources
    {
        // DO use PascalCasing in resource keys
        public static string ResourceKeyExample = "SampleResource";

        // DO provide descriptive rather than short identifiers
        public static string DescriptiveResourceKey = "DescriptiveResourceName";

        // DO use only alphanumeric characters and underscores in naming resources
        public static string Resource_With_Underscore = "ResourceWithUnderscore";

        // DO use the following naming convention for exception message resources
        // The resource identifier should be the exception type name plus a short identifier of the exception
        public static string ArgumentExceptionIllegalCharacters = "ArgumentExceptionIllegalCharacters";
        public static string ArgumentExceptionInvalidName = "ArgumentExceptionInvalidName";
        public static string ArgumentExceptionFileNameIsMalformed = "ArgumentExceptionFileNameIsMalformed";
    }
}
