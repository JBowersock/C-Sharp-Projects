using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 5.
            Employee instantiate = new Employee(); //Instantiating Employee objects.
            instantiate.firstName = "Sample"; //Instantiating Employee firstnames.
            instantiate.lastName = "Student"; //Instantiating Employee lastnames.

            instantiate.SayName(); //Calling 'SayName()' method on object.

            Console.ReadLine(); //Allows window to remain open until user closes.
        }
    }
}
