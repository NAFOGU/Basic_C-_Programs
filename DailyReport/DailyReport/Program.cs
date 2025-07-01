using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a program to create a daily report for students of AOLCC
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            int pageNum = int.Parse(Console.ReadLine()); //Casts response as integer
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string help = Console.ReadLine();
            bool helpBool = bool.Parse(help); // casts string response as boolean
            Console.WriteLine("Were there any positive experiences you\'d like to share? Please give specifics");
            string specifics = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you\'d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int hours = int.Parse(Console.ReadLine()); // casts response as integer
            Console.WriteLine("Thank you for your answers. An instructor will respond" +
                " shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}