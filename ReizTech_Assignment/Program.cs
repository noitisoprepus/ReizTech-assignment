using System;

namespace ReizTech_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Made by Ralph Ryan Peralta for the ReizTech .NET Developer Intern Application");
            
            OutputHeading("Problem 1 Answer");
            Problem_1.Run();

            OutputHeading("Problem 2 Answer");
            Problem_2.Run();

            Console.Write("Press any key to exit");
            Console.ReadKey();
        }

        static void OutputHeading(string headingText)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(headingText);
            Console.ResetColor();
        }
    }
}
