using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee
    {
        // Property to store the Employee ID
        public int Id { get; set; }

        // Property to store the Employee's first name
        public string FirstName { get; set; }

        // Property to store the Employee's last name
        public string LastName { get; set; }

        // Overload the '==' operator to compare Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are null, or both are the same instance, return true
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If one is null, but not both, return false
            if (emp1 is null || emp2 is null)
                return false;

            // Compare Id properties
            return emp1.Id == emp2.Id;
        }

        // Overload the '!=' operator in conjunction with '=='
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals to match == logic (good practice)
        public override bool Equals(object obj)
        {
            if (obj is Employee other)
            {
                return this.Id == other.Id;
            }
            return false;
        }

        // Override GetHashCode to be consistent with Equals
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
