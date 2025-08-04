using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathHandler mathHandler = new MathHandler();

            // Call method that takes an int
            int intResult = mathHandler.ProcessNumber(15);
            Console.WriteLine("Int version: 15 + 10 = " + intResult);

            // Call method that takes a decimal
            int decimalResult = mathHandler.ProcessNumber(7.5m);
            Console.WriteLine("Decimal version: 7.5 * 2 = " + decimalResult);

            // Call method that takes a string
            int stringResult = mathHandler.ProcessNumber("20");
            Console.WriteLine("String version: 20 - 5 = " + stringResult);
            Console.ReadLine();
        }
    }
}
