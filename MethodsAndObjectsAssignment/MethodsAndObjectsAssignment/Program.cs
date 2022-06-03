using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 4.
            Employee employee = new Employee();
            employee.FirstName = new List<string> { "Sample" };
            employee.LastName = new List<string> { "Student" };

            //Step 5.
            employee.SayName();

            Console.ReadLine();
        }
    }
}
