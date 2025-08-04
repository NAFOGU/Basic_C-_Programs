using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MathClass math = new MathClass();

            // Call the method with positional arguments
            math.DoMath(5, 10);

            Console.WriteLine();

            // Call the method with named arguments
            math.DoMath(number1: 8, number2: 15);

            Console.ReadLine();
        }
    }
}
