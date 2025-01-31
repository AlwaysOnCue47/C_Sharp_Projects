using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsAndObjects
{
    public class Employee : Person, IQuitTable  // creating a class called Employee which inherance the properties of the person class and the IQuitTable interface and adds another property called Id
    {
        public int Id { get; set; } // Id variable in integer data type

        public void Quit() // have to reference this function in this class since we are inheriting the IQuitTable interface - I still don't understand why we created an interface since the Quit() function is being defined here. 
        {
            Console.WriteLine($"This employee has submitted their resignation: {this.FirstName} {this.LastName}"); // Whichever Employee object calls the Quit function that Employee object's FirstName and LastName will be displayed. 
            
        }
    }
}
