using System;

namespace MethodsAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Methods and Objects Assignment");
            Console.WriteLine();
            Employee employee1 = new Employee() // create a new Employee object called employee1. This object has all the properties and methods that are described in the employee class 
            {
                FirstName = "Sample",
                LastName = "Student"

            };
            employee1.SayName(); // since emplyee class inherance its properties from person class the "sayname" method is attached to the employee1 object
            
            Person employee2 = new Employee()
            {
                FirstName = "James",
                LastName = "Kirk",
                Id = 2

            };
            employee2.SayName();

            IQuitTable employee3 = new Employee() // instantiated a new employee object by instantiating a new IQuitTable interface
            {
                FirstName = "Bob", // The IQuitTable interface inherits the person and employee properties.
                LastName = "Smith",
                Id = 3
            };
            // employee3.SayName(); **BUG** employee3 does not have the SayName() method attached to it - I don't know why - Employee inherits it's properties from Person. If I create an employee or person object they both have the SayName() method attached
            // but if I instantiate a new employee using the IQuitTable interface the Employee object gets the FirstName and LastName properties but doesn't inherit the SayName() function from Person(??) Don't Know - 
            employee3.Quit(); // Call the Quit() function by invoking through the emplyee object
            employee1.Quit(); // The object created from the employee class also has access to the IQuitTable interface
        }   // BUT, objects created by first using the NEW INTERFACE option do not inherit the SayName() method defined in Person class - ¯\_(ツ)_/¯
    }
}
