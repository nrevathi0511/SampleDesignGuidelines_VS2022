using Fremawork_Design_Guidelines;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
 // Capitalization Conventions:
        // Create an instance of the Capitalization_Conventions class
        Capitalization_Conventions conventions = new Capitalization_Conventions();

        // Access properties, methods, and events
        conventions.MyProperty = "Hello, World!";
        conventions.MyMethod();
        conventions.MyEvent += EventHandlerMethod;

        // Access enum
        Capitalization_Conventions.DaysOfWeek day = Capitalization_Conventions.DaysOfWeek.Monday;
        Console.WriteLine("Today is " + day);

        // Rest of your program logic here...

        // Don't forget to dispose of resources if necessary

// General Naming Conventions
        General_Naming_Conventions general_naming_conventions = new General_Naming_Conventions();        //Object creation
        general_naming_conventions.CustomerId = 1;
        general_naming_conventions.SetCustomerName("John Doe");

        Console.WriteLine($"Customer ID: {general_naming_conventions.CustomerId}");
        Console.WriteLine($"Customer Name: {general_naming_conventions.GetCustomerName()}");

        // Using constants and enums
        Console.WriteLine($"Max Allowed Orders: {General_Naming_Conventions.MaxAllowedOrders}");
        Console.WriteLine($"Order Status: {General_Naming_Conventions.OrderStatus.Pending}");

//Names of Assemblies and DLLs
        // Example usage of the named assemblies
        var dataProcessor = new ClassLibrary.DataProcessor();
        dataProcessor.ProcessData();

        var reportGenerator = new Reporting.ReportGenerator();
        reportGenerator.GenerateReport();

        var userInterface = new UI.UserInterface();
        userInterface.ShowUI();
    }
    private static void EventHandlerMethod(object sender, EventArgs e)
    {
        Console.WriteLine("MyEvent triggered!");
    }
}
