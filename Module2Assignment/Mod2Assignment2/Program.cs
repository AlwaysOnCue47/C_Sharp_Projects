using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Mod2Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the 'divide numbers in an array by user inputted number' program");
            
            // the variables
            List<int> numList = new List<int>() { 4, 5, 10, 16, 20, 25, 42, 53 };
            decimal result = 0;
            bool validInput = false;
            decimal userNum = 0;

            while (!validInput)
            {
                try
                {
                    Console.WriteLine("Enter a number between 1 and 10:"); // Placing this inside the try catch block so exceptions run if invalid data is inputted.
                    userNum = decimal.Parse(Console.ReadLine()); // using decimal data type because double and float return infinity when divided by zero - not an exception. 
                    foreach (int num in numList)
                    {
                        result = num / userNum;
                        result = Math.Round(result, 2); // rounding to two decimal places. 
                        Console.WriteLine(num + " divided by " + userNum + " equals: " + result);
                        validInput = true;
                    }
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Can't divide by zero.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Try again. Type a valid number."); // this should catch any other exception including format exceptions
                }
                if (validInput) // if calculation was successful this gives user ability to run it again. 
                {
                    Console.WriteLine("Again? y/n");
                    string choice = Console.ReadLine();
                    if (choice == "y") { validInput = false; }
                    else { Console.WriteLine("Good day to you"); }
                }
            }
        }
    }
}
