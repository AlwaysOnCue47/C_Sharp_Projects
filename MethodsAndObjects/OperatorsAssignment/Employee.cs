using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsAssignment
{
    public class Employee //defining employee class
    {
        public string firstName {  get; set; } // class has three parameters, firstName, lastName and ID
        public string lastName { get; set; }
        public int Id { get; set; }

        public static bool operator ==(Employee em1, Employee em2) // define how the bool operator == evaluates the objects to determine equality
        {
            if (em1.Id == em2.Id)
            {
                return true;
            }
            return false;       // instructs the program to compare the ID int value in each object to determine if the objects are equal or not. 
        }

        public static bool operator !=(Employee em1, Employee em2)
        {
            if (em1.Id != em2.Id) 
            {
                return true;
            } 
            return false; // since we are overloading == we must define how the opposite (!=) is determined. Also by comparing the values of the int Id.
        }
    }
}
