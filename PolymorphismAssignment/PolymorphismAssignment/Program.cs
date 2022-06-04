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
            IQuittable instantiate = new Employee(); //Instantiating a class.
            instantiate.Quit("b"); //Sending the value 'b' into 'Quit' (in the IQuittable interface).
            
            Console.ReadLine(); //Allows window to remain open until user closes.
        }
    }
}
