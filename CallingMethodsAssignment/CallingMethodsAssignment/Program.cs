using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks the user for a number
            Console.WriteLine("Enter a number to perform mathe operations on:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int result1 = MathMethods.AddTen(userInput);
            Console.WriteLine($"{userInput} + 10 = {result1}");
            int result2 = MathMethods.MultiplyByTwo(userInput);
            Console.WriteLine($"{userInput} * 2 = {result2}");
            int result3 = MathMethods.SubtractFive(userInput);
            Console.WriteLine($"{userInput} - 5 = {result3}");
            Console.ReadLine();
        }
    }
}
