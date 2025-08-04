using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Employee and set property values
            Employee emp1 = new Employee()
            {
                FirstName = "John",   // Set inherited FirstName property
                LastName = "Robin",   // Set inherited LastName property
                Id = 1001               // Set Employee-specific Id
            };

            // Display the full name using SayName() method
            emp1.SayName();

            // Use polymorphism: create an object of type IQuittable and assign emp1 to it
            IQuittable quittableEmp = emp1;

            // Call the Quit method using the interface reference
            quittableEmp.Quit();

            // Optional: Pause the program so console doesn't close immediately
            Console.ReadLine();
        }
    }
}
