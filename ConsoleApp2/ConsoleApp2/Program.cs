using System;
using System.Runtime.Intrinsics.X86;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below."); // welcome message
            Console.WriteLine("Please enter the package weight");
            string weight = Console.ReadLine(); // read user input as string
            int weightNum = Convert.ToInt32(weight); // convert string to integer to perform math on it
            if (weightNum > 50) // check if weight is over 50. If yes program ends
            {
                Console.WriteLine("Sorry, package too heavy to be shipped. Have a good day.");
            }
            else // if less than 50
            {
                Console.WriteLine("Please enter package width.");
                string width = Console.ReadLine(); // read user input as string
                int widthNum = Convert.ToInt32(width); // convert string to integer to perform math on it
                Console.WriteLine("Please enter the package height.");
                string height = Console.ReadLine(); // read user input as string
                int heightNum = Convert.ToInt32(height); // convert string to integer to perform math on it
                Console.WriteLine("Please enter the package length.");
                string length = Console.ReadLine(); // read user input as string
                int lengthNum = Convert.ToInt32(length); // convert string to integer to perform math on it

                int totalDimension = widthNum + heightNum + lengthNum;
                if (totalDimension > 50) // if total sum of dimensions is greater than 50 program ends
                {
                    Console.WriteLine("Sorry, package is too big to be shipped. Have a good day.");
                }
                else
                {
                    double totalCost = ((widthNum * heightNum * lengthNum) * weightNum) / 100.00; // claculate shipping cost. Use double for decimal places
                    Console.WriteLine("Your estimated total for shipping this package is: $" + totalCost.ToString()); // convert double to string and display result
                    Console.WriteLine("Thank-you!");

                    // final readLine() not needed. Console automatically stays open until key is pressed
                }
            }
        }
    }
}
