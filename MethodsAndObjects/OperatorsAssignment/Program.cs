using System;
using System.Collections.Generic;
using System.Linq;

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

            List<Employee> employees = new List<Employee>(); // create new list for employee objects
            employees.Add(employee1); // add previously created employees
            employees.Add(employee2);
            employees.Add(new Employee() {firstName="Ben",lastName = "Sisko", Id = 3 }); // add eight more to list including two named Joe
            employees.Add(new Employee() { firstName = "Will", lastName = "Riker", Id = 4 });
            employees.Add(new Employee() { firstName = "Kathy", lastName = "Janeway", Id = 5 });
            employees.Add(new Employee() { firstName = "Beverly", lastName = "Crusher", Id = 6 });
            employees.Add(new Employee() { firstName = "Joe", lastName = "Redshirt", Id = 7 });
            employees.Add(new Employee() { firstName = "Joe", lastName = "Blueshirt", Id = 8 });
            employees.Add(new Employee() { firstName = "Wesley", lastName = "Crusher", Id = 9 });
            employees.Add(new Employee() { firstName = "Miles", lastName = "O'brien", Id = 10 });

            foreach (Employee employee in employees) // display all employees in Employee list
            {
                Console.WriteLine($"Person info: {employee.firstName} {employee.lastName} Idenificatio #: {employee.Id}");
            }

            List<Employee> employeesNamedJoe = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    employeesNamedJoe.Add(employee);
                }
            }
            foreach (Employee employee in employeesNamedJoe)
            {
                Console.WriteLine($"{employee.firstName} {employee.lastName}");
            }

            List<Employee> joeList2 = employees.Where(X => X.firstName == "Joe").ToList();

            foreach (Employee employee in joeList2)
            {
                Console.WriteLine($"{employee.firstName} {employee.lastName}");
            }


        }
    }
}
