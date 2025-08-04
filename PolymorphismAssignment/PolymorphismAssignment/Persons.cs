using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    public class Person
    {
        // FirstName property of the person
        public string FirstName { get; set; }

        // LastName property of the person
        public string LastName { get; set; }

        // Method that prints the full name of the person
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
