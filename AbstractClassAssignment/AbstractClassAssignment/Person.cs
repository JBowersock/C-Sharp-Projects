using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //Step 1.
    public abstract class Person //Public, and Abstract class.
    {
    public string firstName { get; set; } //Class Property.
    public string lastName { get; set; } //Class Property.

        //Step 2.
        public void SayName() //Public void Method.
        {
            Console.WriteLine();
        }
    }
}
