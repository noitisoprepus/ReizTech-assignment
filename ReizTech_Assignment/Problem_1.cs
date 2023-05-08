using System;

namespace ReizTech_Assignment
{
    class Problem_1
    {
        public static void Run()
        {
            // Getting user inputs
            int hour = GetIntInput("Enter the hour for the Analog Clock (1 - 12): ", 1, 12);
            int minutes = GetIntInput("Enter the hour for the Analog Clock (1 - 60): ", 1, 60);

            // Calculating the hand angles if they were on a real analog clock
            // The HOUR hand moves 0.5 degrees per minute
            // The MINUTE hand moves 6 degrees per minute
            float hArrowAngle = ((hour * 60) + minutes) * 0.5f;
            float mArrowAngle = minutes * 6;

            // Getting the angle between the hands, and getting the lower value
            float angleDifference = Math.Abs(hArrowAngle - mArrowAngle);
            float lesserAngle = Math.Min(angleDifference, 360 - angleDifference);

            Console.WriteLine("The lesser angle is {0}", lesserAngle);
        }

        static int GetIntInput(string message, int min, int max)
        {
            int intInput;

            Console.Write(message);
            string input = Console.ReadLine();
            
            // Checks if the given input is an integer
            if (!int.TryParse(input, out intInput))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                return GetIntInput(message, min, max);
            }

            // Checks if the converted integer is within the given bounds
            if (intInput >= min && intInput <= max)
                return intInput;
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer within the bounds of {0} and {1}.", min, max);
                return GetIntInput(message, min, max);
            }
        }
    }
}
