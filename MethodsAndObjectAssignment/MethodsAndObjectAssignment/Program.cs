using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Employee object and assign values to its properties
            Employee emp = new Employee()
            {
                FirstName = "Nafisat",   // Set the inherited FirstName property
                LastName = "Ogunleye",   // Set the inherited LastName property
                Id = 1                  // Set the Id property specific to Employee
            };

            // Call the SayName() method, inherited from the Person class
            emp.SayName();

            Console.ReadLine();
        }
    }
}
