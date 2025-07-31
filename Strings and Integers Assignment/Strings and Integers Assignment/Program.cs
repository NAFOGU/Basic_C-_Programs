using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        // Creates a list of integers
        List<int> integers = new List<int>() { 3, 5, 6, 7, 1, 9, 2, 8 };

        // Asks the user for input and loop through the list dividing each number by the input
        bool numValid = false;

        while (!numValid)
        {
            try
            {
                Console.WriteLine("\n Enter a number to divide the above list by: ");
                float numDivide = float.Parse(Console.ReadLine());
                // Checks if the user enter 0
                if (numDivide == 0)
                {
                    Console.WriteLine("Please enter a number other than 0.");
                }
                // Divides each number in the list by the user's input
                else
                {
                    foreach(int num in integers)
                    {
                        float Divide = num / numDivide;
                        Console.WriteLine(num + " / " + numDivide + " = " + Divide);
                    }
                    numValid = true;
                }
            }
            // Catch block to display error message for string input
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number");
            }
        }
        // Message to let the user know the program has exited the try/catch block
        Console.WriteLine("The program has exited the try/catch block");
        Console.ReadLine();
    }
}
