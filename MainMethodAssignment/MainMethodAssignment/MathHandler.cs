using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MathHandler
{
    // Method 1: Takes an integer and adds 10
    public int ProcessNumber(int number)
    {
        return number + 10;
    }

    // Method 2: Takes a decimal and multiplies by 2, then returns int
    public int ProcessNumber(decimal number)
    {
        return (int)(number * 2);
    }

    // Method 3: Takes a string, converts to int, then subtracts 5
    public int ProcessNumber(string numberString)
    {
        int number = int.Parse(numberString);
        return number - 5;
    }
}
