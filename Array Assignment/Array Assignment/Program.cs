using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creates an array of strings
        string[] namesArray = { "Nafisat", "Lateef", "Awwal", "Medinah" };

        // Asks the user to select a number to dispaly the string attached to that index
        Console.WriteLine("Choose a number between 0 and 3:");
        int stringChoice = Convert.ToInt32(Console.ReadLine());
        bool validString = false;

        while(!validString)
        {
            try
            {
                Console.WriteLine("The person you chose is " + namesArray[stringChoice]);
                validString = true;
            }

            // Add a message to display if the user picks an index that does not exists
            catch
            {
                Console.WriteLine("Oops! The number you selected is invalid. Please choose a number " +
                    "between 0 and 3");
                stringChoice = Convert.ToInt32(Console.ReadLine());
            }
        }

        // List of strings
        List<string> familyHeirarchy = new List<string>()
        {
            "Grandfather", 
            "Grandmother", 
            "Father", 
            "Mother", 
            "Son", 
            "Daughter"
        };

        // Asks the user to select a number to dispaly the string attached to that index
        Console.WriteLine("\nChoose a number between 0 and 5:");
        int listChoice = Convert.ToInt32(Console.ReadLine());
        bool validList = false;

        while (!validList)
        {
            try
            {
                Console.WriteLine("The person you chose is " + familyHeirarchy[listChoice]);
                validList = true;
            }

            // Add a message to display if the user picks an index that does not exists
            catch
            {
                Console.WriteLine("Oops! The number you selected is invalid. Please choose a number " +
                    "between 0 and 5");
                listChoice = Convert.ToInt32(Console.ReadLine());
            }
        }

    }
}
