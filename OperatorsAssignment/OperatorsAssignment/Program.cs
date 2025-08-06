using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first Employee object and assign values
            Employee employee1 = new Employee
            {
                Id = 101,
                FirstName = "Nafisat",
                LastName = "Ogunleye"
            };

            // Create the second Employee object and assign values
            Employee employee2 = new Employee
            {
                Id = 102,
                FirstName = "Lateef",
                LastName = "Iyanda"
            };

            // Compare the two Employee objects using the overloaded '=='
            bool areEqual = employee1 == employee2;

            // Display the result of the comparison
            Console.WriteLine($"Are employee1 and employee2 equal? {areEqual}");

            // Change employee2's Id to match employee1's Id
            employee2.Id = 101;

            // Compare again after updating Ids
            areEqual = employee1 == employee2;

            // Display the updated result
            Console.WriteLine($"Are employee1 and employee2 equal after matching Ids? {areEqual}");

            Console.ReadLine();
        }
    }
}
