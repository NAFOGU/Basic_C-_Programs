using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Assignment 1
        // Creates an array of strings
        string[] phrases = { "Hello", "Welcome", "See you", "Goodbye", "Take care" };

        //Asks the user to input some text
        Console.WriteLine("Enter your name to append to the array: ");
        string userInput = Console.ReadLine();

        //Iterate to append the user's input
        for (int i = 0; i < phrases.Length; i++)
        {
            phrases[i] += " " + userInput;
        }

        //Second loop to print each modified string
        Console.WriteLine("\nUpdated phrases:");
        foreach (string phrase in phrases)
        {
            Console.WriteLine(phrase);
        }

        // Assignment 2
        // Infinite loop
        while (true) // This creates an infinite loop
        {
            Console.WriteLine("Type 'exit' to stop the loop, or press Enter to see Hello again:");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                // Fix: Exit the loop when user types "exit"
                break;
            }

            Console.WriteLine("Hello!");
        }

        // Assignment 3
        // This loop uses '<' and prints 1 to 4
        Console.WriteLine("\nUsing '<' operator:");

        for (int i = 1; i < 5; i++)
        {
            Console.WriteLine("Number: " + i);
        }

        Console.WriteLine("\nUsing '<=' operator:");

        // This loop uses '<=' and prints 1 to 6
        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine("Number: " + i);
        }


        // Assignment 4
        // Iterating through a list
        
        // Create a list of fruits
        List<string> fruits = new List<string> { "Apple", "Banana", "Orange", "Mango", "Grapes"};

        // Asks the user to enter a fruit name
        Console.WriteLine("Enter the name of a fruit to search for:");
        string userInput1 = Console.ReadLine();

        bool found = false; // Flag to track if the item is found

        // Loops through the list to find a match
        for (int j = 0; j < fruits.Count; j++)
        {
            if (fruits[j].ToLower() == userInput1.ToLower())
            {
                Console.WriteLine($"'{userInput1}' found at index {j}.");
                found = true;
                break; // This stops the loop once a match is found
            }
        }

        // If not match is found
        if (!found)
        {
            Console.WriteLine($"'{userInput1}' is not on the list.");
        }


        // Assignment 5
        // Search and display all matching indices

        // Creates a list with at least two identical strings
        List<string> colors = new List<string> { "Red", "Blue", "Green", "Red", "Yellow", "Blue" };

        // Asks the user to search for a color
        Console.WriteLine("Available colors: Red, Blue, Green, Yellow");
        Console.WriteLine("Enter a color to search for: ");
        string userInput2 = Console.ReadLine();

        bool matchFound = false;

        // Loops through the list and prints all matching indexes
        for (int k = 0; k < colors.Count; k++)
        {
            if (colors[k].ToLower() == userInput2.ToLower())
            {
                Console.WriteLine($"Match found at index {k}");
                matchFound = true;
            }
        }

        // If no matches found
        if (!matchFound)
        {
            Console.WriteLine($"'{userInput2}' is not on the list.");
        }

        // Assignment 6
        // Creates a list of strings that has at least two identical strings in the list

        List<string> names = new List<string> { "Lateef", "Awwal", "Nafisat", "Lateef",
        "Medinah", "Nafisat", "Medinah"};

        // Creates an empty list to keep track of seen items
        List<string> seenItems = new List<string>();
        Console.WriteLine("Family members:");

        // Loops through each item in the list

        foreach (string name in names)
        {
            if (seenItems.Contains(name))
            {
                Console.WriteLine($"{name} - This name is a duplicate");
            }
            else
            {
                Console.WriteLine($"{name} - This name is unique");
                seenItems.Add(name); // Adds to seen list
            }
        }
        

        // Keep console open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}


