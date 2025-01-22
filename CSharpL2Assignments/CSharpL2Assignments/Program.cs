using System;
using System.Collections.Generic;

namespace CSharpL2Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nameArray = { "Picard", "Kirk", "Janeway", "Sisko", "Archer", "Spock", "Sulu", "Data", "Riker" };
            Console.WriteLine("Welcome to the Star Trek Choice game!");
            Console.WriteLine("Pick a number between 0 - 8");
            int nameSelect = Convert.ToInt32(Console.ReadLine());
            bool validChoice = false;

            while (!validChoice)
            {
                try
                {
                    Console.WriteLine("Your favorite Star Trek character is: " + nameArray[nameSelect]);
                    validChoice = true;
                }
                catch
                {
                    Console.WriteLine("Try again. Pick a number between 0 and 8");
                    nameSelect = Convert.ToInt32(Console.ReadLine());
                }
            }

            List<string> positionList = new List<string>()
            {"Waste Extraction", "Red Shirt", "Transporter Operator", "Replicator Cook", "Bartender", "Holodeck Maintanence", "Captain",
             "Assistant to the Captain", "Stembolt Inventory" };

            Console.WriteLine("Again, pick a number between 0 - 8");
            int positionSelect = Convert.ToInt32(Console.ReadLine());
            bool validChoice2 = false;

            while (!validChoice2)
            {
                try
                {
                    Console.WriteLine("Your favorite job on a starship is: " + positionList[positionSelect]);
                    validChoice2 = true;
                }
                catch
                {
                    Console.WriteLine("Try again. Pick a number between 1 and 8");
                    positionSelect = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("Thank you for playing Choose the Choice. In app purchases coming soon!");
        }
    }  
}
