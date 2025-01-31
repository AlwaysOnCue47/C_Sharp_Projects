using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsAndObjects
{
    public abstract class Person // Defining a new abstract class called Person. Public so it's accessable throughout this namespace
    {
        public string FirstName { get; set; } // this class has two properties. String data type variables called FirstName and LastName.
        public string LastName { get; set; } // these values can be both "set" and "get" (retrieved) when instructed to

        public void SayName() // this is like a function attached to the object. When a specific instance of this object calls this function it will print it's string values
        {
            Console.WriteLine($"Name: {this.FirstName} {this.LastName}"); // using the $ method in the string to make it easier to concatenate multiple variables
        }//                     "this" is refers to this instance of the object. If an object's sayname method is called it will print that object's name
    }
}
