using Fremawork_Design_Guidelines;
using System;
using System.Drawing;
using System.Xml;
//using UI;
//using Reporting;
//using ClassLibrary;

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
        //UIClass.ShowUI();
        //Reporting.GenerateReport();
        //ClassLibrary.ProcessData();

// Names of Namespace
        Names_of_Namespaces names_of_namespaces = new Names_of_Namespaces();
        int result = names_of_namespaces.Add(5, 7);

        Console.WriteLine("Result: " + result);


// Names of Classes, Structs, and Interfaces
        Structs myStructs = new Structs(10, 20);

        // Access and display the values
        Console.WriteLine("Coordinates of myPoint:");
        myStructs.Display();

        // Modify the values
        myStructs.X = 30;
        myStructs.Y = 40;

        // Display the modified values
        Console.WriteLine("Modified coordinates of myPoint:");
        myStructs.Display();

        // Structs are value types, so a copy is created when assigned to another variable
        Structs anotherPoint = myStructs;
        anotherPoint.X = 50;

        Console.WriteLine("myPoint coordinates after copying and modifying anotherPoint:");
        myStructs.Display(); // This will still display (30, 40)

        Console.WriteLine("anotherPoint coordinates:");
        anotherPoint.Display(); // This will display (50, 40)


//Generic Type Parameters
        var stringList = new GenericList<string>();
        stringList.Add("Hello");
        stringList.Add("World");
        Console.WriteLine(stringList.GetItem(0)); // Output: Hello

        // Using the NumericCalculator class with type constraints
        var intCalculator = new NumericCalculator<int>();
        int res = intCalculator.Add(5, 3);
        Console.WriteLine("5 + 3 = " + result); // Output: 5 + 3 = 8

        var doubleCalculator = new NumericCalculator<double>();
        double doubleResult = doubleCalculator.Add(2.5, 3.7);
        Console.WriteLine("2.5 + 3.7 = " + doubleResult); // Output: 2.5 + 3.7 = 6.2


// Using the enumerations
        Fremawork_Design_Guidelines.DayOfWeek today = Fremawork_Design_Guidelines.DayOfWeek.Wednesday;
        Gender userGender = Gender.Female;
        Permissions userPermissions = Permissions.Read | Permissions.Write;

        Console.WriteLine($"Today is {today}");
        Console.WriteLine($"User's gender is {userGender}");
        Console.WriteLine($"User has the following permissions: {userPermissions}");


        //Names of Methods
        Names_of_Methods cal= new Names_of_Methods();
        int data = cal.Add(5, 3);
        Console.WriteLine("5 + 3 = " + data);

        double average = cal.CalculateAverage(new int[] { 1, 2, 3, 4, 5 });
        Console.WriteLine("Average: " + average);

        bool isEven = cal.IsEven(6);
        Console.WriteLine("Is 6 even? " + isEven);

        int[] numbers = { 10, 20, 30 };
        Console.WriteLine("Doubled numbers:");
        cal.ProcessNumbers(numbers, num => Console.WriteLine(num * 2));


//Names of Properties
        Names_of_Properties person = new Names_of_Properties();
        person.FirstName = "Sri";
        person.LastName = "Majji";
        person.IsStudent = true;
        person.HomeAddress = new Address
        {
            Street = "123 Main St",
            City = "Sampleville",
            ZipCode = "12345"
        };

        Console.WriteLine($"Name: {person.FirstName} {person.LastName}");
        Console.WriteLine($"Age: {person.Age}");
        Console.WriteLine($"Is Student: {person.IsStudent}");
        Console.WriteLine($"Home Address: {person.HomeAddress.Street}, {person.HomeAddress.City}, {person.HomeAddress.ZipCode}");


//Names of Events
        Names_of_Events sensor = new Names_of_Events();

        // Subscribe to the TemperatureChanged event
        sensor.TemperatureChanged += (sender, e) =>
        {
            Console.WriteLine($"Temperature changed: {e.NewTemperature}°C");
        };

        // Simulate temperature changes
        sensor.CurrentTemperature = 25.5f;
        sensor.CurrentTemperature = 26.0f;


//Names of fields
        Person Creature = new Person("Satya", "Majji");

        // Access fields using properties
        Creature.FirstName = "Satya";

        // Access private fields from methods
        Creature.PrintFullName();

        // Access public field (not recommended)
        Creature.Age = 27;

        Console.WriteLine($"Age: {Creature.Age}");


        //Naming Parameters
        Naming_Parameters calculator = new Naming_Parameters();

        int reslt = calculator.Add(5, 3);
        Console.WriteLine("5 + 3 = " + result);

        int difference = calculator.Subtract(10, 3);
        Console.WriteLine("10 - 3 = " + difference);

        double avg = calculator.CalculateAverage(new int[] { 1, 2, 3, 4, 5 });
        Console.WriteLine("Average: " + average);

        bool iseven = calculator.IsEven(6);
        Console.WriteLine("Is 6 even? " + isEven);


        //Naming Resources
        // Accessing the named resources
        Console.WriteLine(Naming_Resources.ResourceKeyExample);
        Console.WriteLine(Naming_Resources.DescriptiveResourceKey);
        Console.WriteLine(Naming_Resources.Resource_With_Underscore);

        // Accessing exception message resources
        Console.WriteLine(Naming_Resources.ArgumentExceptionIllegalCharacters);
        Console.WriteLine(Naming_Resources.ArgumentExceptionInvalidName);
        Console.WriteLine(Naming_Resources.ArgumentExceptionFileNameIsMalformed);


        //Names of Common Types
        var customer = new Customer
        {
            Name = "Sai Majji",
            Email = "sai@example.com"
        };

        // Using the OrderStatus enum
        OrderStatus status = OrderStatus.Processing;

        // Using the CustomAppException class
        try
        {
            throw new CustomAppException("Custom exception message.");
        }
        catch (CustomAppException ex)
        {
            Console.WriteLine("Caught exception: " + ex.Message);
        }

        // Using the IResizable interface
        Console.WriteLine("Resizing...");
        var resizableObject = new ResizableObject();
        resizableObject.Resize(800, 600);
    }


// Implementation of the IResizable interface
public class ResizableObject : IResizable
{
    public void Resize(int width, int height)
    {
        Console.WriteLine($"Resized to {width}x{height}.");
    }

}
    private static void EventHandlerMethod(object sender, EventArgs e)
    {
        Console.WriteLine("MyEvent triggered!");
    }
}
