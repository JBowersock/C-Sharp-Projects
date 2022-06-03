using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    //Step 1.
    public class Person //made public.
    {
    public string FirstName { get; set; }
    public string LastName { get; set; }

        //Step 2.
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
