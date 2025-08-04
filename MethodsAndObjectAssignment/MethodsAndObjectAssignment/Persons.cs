using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectAssignment
{
    public class Person
    {
        // Property to store the first name
        public string FirstName { get; set; }

        // Property to store the last name
        public string LastName { get; set; }

        // Method that displays the full name in the format: "Name: FirstName LastName"
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
