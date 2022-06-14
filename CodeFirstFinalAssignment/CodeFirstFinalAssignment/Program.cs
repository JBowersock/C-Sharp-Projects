using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; //Added to list.

namespace CodeFirstFinalAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext()) //
            {
                //Creating and saving new Students.
                Console.WriteLine("Enter Student Name:");
                var name = Console.ReadLine();

                var stood = new Student { Name = name };
                db.Students.Add(stood);
                db.SaveChanges();

                //Displaying all Students from database.
                var query = from b in db.Students
                            orderby b.Name
                            select b;

                Console.WriteLine("Students in Database:");
                foreach (var person in query)
                {
                    Console.WriteLine(person.Name);
                }

                Console.WriteLine("Press Enter to Exit.");
                Console.ReadLine();
            }
        }
    }

    public class Student //
    {
        public int StudentID { get; set; } //
        public string Name { get; set; } //
    }

    public class StudentContext : DbContext //
    {
        public DbSet<Student> Students { get; set; } //
    }
}