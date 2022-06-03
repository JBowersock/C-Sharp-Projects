using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    public class Person(string firstName, string lastName) //made public.
    {
        public void sayName()
        {
            Console.WriteLine("Name:[full name]");
        }
    }
}
