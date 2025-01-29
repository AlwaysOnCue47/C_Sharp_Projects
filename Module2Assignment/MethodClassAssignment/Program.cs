using System;
using Microsoft.VisualBasic;

namespace MethodClassAssignment // Method Class Assignment Submission Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oranges in a basket program - Module 4 - Method Class Assignment Submission");
            Console.WriteLine(); // adding these extra write lines to place a space between text lines - easier to read output. 
            Console.WriteLine("If you had 17 oranges and 2 baskets to put them in what is the highest equal number of oranges per basket?"); 
            Console.WriteLine("My Basket method can compute that!");
            Console.WriteLine();
            Basket baskit = new Basket(oranges: 17, baskets: 2); // instantiating new class with values assigned to parameters 
            Console.WriteLine();
            Console.WriteLine("Now you try. How many oranges?"); // Give user ability to input custom values to parameters
            int userOranges = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("And how many baskits?");
            int userBaskits = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Basket userBaskit = new Basket(oranges:  userOranges, baskets: userBaskits); // instantiating another basket class with user inputted values. 
            Console.WriteLine("Have a good day!");

        }
    }
}
