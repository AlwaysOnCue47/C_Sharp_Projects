using System;

namespace OperatorsAssignment // Module 6  - Operator Assignment Submission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operator Overload Assignment");
            Employee employee1 = new Employee(){firstName = "Jim", lastName = "Kirk", Id = 1}; // Instantiating new Employee object
            Employee employee2 = new Employee(){firstName = "Jean-luc", lastName = "Picard", Id=2}; // Instatiating second employee object with different values
            Console.WriteLine($"{employee1.firstName} {employee1.lastName} Identification number: {employee1.Id}"); // printing both Emplyee objects to confirm instantiation
            Console.WriteLine($"{ employee2.firstName} {employee2.lastName} Identification number: {employee2.Id}") ;

            bool checkId = employee1 == employee2; // create bool variable called checkId - value returned based on the operator overload instructions in the employee class definition
            Console.WriteLine($"Does employee 1 and employee 2 have the same ID number? {checkId}") ; // display value of checkId
            
        }
    }
}
