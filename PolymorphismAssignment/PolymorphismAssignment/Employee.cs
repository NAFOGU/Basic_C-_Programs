using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    public class Employee : Person, IQuittable
    {
        // Property specific to Employee that stores their ID
        public int Id { get; set; }

        // This method implements the Quit() method from the IQuittable interface
        public void Quit()
        {
            // Just a simple message indicating the employee has quit
            Console.WriteLine(FirstName + " " + LastName + " has quit the job.");
        }
    }
}
