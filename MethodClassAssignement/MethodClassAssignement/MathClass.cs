using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MathClass
{
    // Void method taking two integer parameters
    public void DoMath(int number1, int number2)
    {
        int result = number1 * 2; // Do a math operation on the first number
        Console.WriteLine("Result of operation on first number: " + result);
        Console.WriteLine("Second number is: " + number2);
    }
}
