using System;

namespace MethodsAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Methods and Objects Assignment");
            Employee employee1 = new Employee() // create a new Employee object called employee1. This object has all the properties and methods that are described in the employee class 
            {
                FirstName = "Sample",
                LastName = "Student"

            };
            employee1.SayName(); // since emplyee class inherance its properties from person class the "sayname" method is attached to the employee1 object
            
        }
    }
}
