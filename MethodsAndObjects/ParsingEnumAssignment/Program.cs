using System;

namespace ParsingEnumAssignment
{
    internal class Program
    {
        enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            bool validInput = false;

            while (!validInput)
            {
                try
                {
                    Console.WriteLine("Enter a day of the week:");
                    string userInput = Console.ReadLine();
                    DaysOfTheWeek dayValue = (DaysOfTheWeek)Enum.Parse(typeof(DayOfWeek), userInput);
                    Console.WriteLine($"Have a good: {dayValue}!");
                    validInput = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Type the name exactly correct - first letter is capital.");
                }
            }
        }     
    }
}
