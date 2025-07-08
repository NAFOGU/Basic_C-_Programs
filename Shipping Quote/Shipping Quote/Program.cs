using System;


namespace Shipping_Quote
{
    class Program
    {
        static void Main(string[] args)
        {
            // The heading of the application
            Console.WriteLine("Welcome to Package Express");
            // Prompt to request for the weight of customer's package
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());
            // 
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped by Package Express.\n" +
                    "Have a good day!");
            }
            else
            {
                // Prompt to request for the width, height and length of the customer's package
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int length = Convert.ToInt32(Console.ReadLine());

                // Calculate the total dimensions of the package
                int totalDim = width + height + length;

                if (totalDim > 50)
                {
                    Console.WriteLine("Package too heavy to be shipped by Package Express.\n" +
                        "Have a good day!");
                }
                else
                {
                    // Calculate the quote for shipping the package
                    int quote = ((height * width * length) * weight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote
                        + "\nThank you!");
                }
            }
            Console.ReadLine();
        }
    }
}
