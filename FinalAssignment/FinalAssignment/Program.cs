using System;
using System.Linq;

namespace FinalAssignment
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var db = new SchoolContext())
            {
                // Create and add one student
                var student = new Student
                {
                    FirstName = "Nafisat",
                    LastName = "Ogunleye",
                    Email = "adenike2014@gmail.com",
                    EnrolledOn = DateTime.UtcNow
                };

                db.Students.Add(student);
                db.SaveChanges();

                // Verify by querying back
                var count = db.Students.Count();
                var latest = db.Students.OrderByDescending(s => s.Id).FirstOrDefault();

                Console.WriteLine($"Students in DB: {count}");
                Console.WriteLine($"Last inserted: {latest?.FirstName} {latest?.LastName} (Id={latest?.Id})");
                Console.WriteLine("Done. Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}
