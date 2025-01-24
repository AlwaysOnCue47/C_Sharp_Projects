using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Module2Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = new List<string>() { "Fuel", "Radio", "Flaps", "Clear for landing"};
            Console.WriteLine("Enter your name to signoff on each item.");
            string name = Console.ReadLine();
            List<string> signedItems = new List<string>();

            foreach (string item in items)
            {
                signedItems.Add(item + " " + name);
            }

            foreach (string signeditem in signedItems) {
                Console.WriteLine(signeditem); 
            }

            Console.WriteLine("Now lets iterate thru a list of strings using a for loop.");
            Console.ReadLine();
            List<string> fruits = new List<string>() { "apples", "oranges", "pears", "grapes", "bananas", "Lemons"} ;

            for (int i = 0; i < fruits.Count; i++) {
                Console.WriteLine(fruits[i] + " are a healthy snack.");
                
            }
            Console.WriteLine();
            Console.WriteLine("What is your favorite fruit, " + name + "?");
            string fruitChoice = Console.ReadLine();
            bool fruitPick = false;

            while (!fruitPick)
            {
                try
                {
                    bool found = false;
                    for (int i = 0; i < fruits.Count; i++)
                    {
                        if (fruits[i] == fruitChoice) 
                        {
                            Console.WriteLine("Your choice is at index: " + i);
                            fruitPick = true;
                            found = true; break;
                        }
                    }
                    if (!found)
                    {
                        throw new Exception("Fruit not found"); // remove this line and enter a value that is not on the list and there's your infinite loop example
                    }
                }
                catch
                {
                    Console.WriteLine("Your choice was not found.");
                    Console.WriteLine("Enter a fruit from the list.");
                    fruitChoice = Console.ReadLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Now, we will iterate thru a grocery list and see if any items are listed more than once.");
            int counter = 0;
            List<string> groceries = new List<string>() { "Eggs", "Juice", "Bread", "Meat", "Soup", "Eggs", "Produce", "Bread", "Eggs", "Cheese"};

            foreach (string grocery in groceries) // instead of making a second list I run a for loop for each item to iterate thru the list and count how many times that instance occurs
            {
                for (int i = 0; i < groceries.Count; i++)
                {
                    if (grocery == groceries[i]) { counter = counter + 1; }
                }
                if (counter == 1) { Console.WriteLine(grocery); counter = 0; }

                else if (counter > 1) { Console.WriteLine(grocery + " listed " + counter + " times"); counter = 0; } // I can use the counter value to display how many times that item appears on the list
            }
            
         }
    }
}
