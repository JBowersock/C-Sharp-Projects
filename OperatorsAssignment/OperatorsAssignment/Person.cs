using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public abstract class Person //Class, Abstract, Public.
    {
        public string firstName { get; set; } //Properties, then Get/Set Method.
        public string lastName { get; set; } //Properties, then Get/Set Method.

        public virtual void sayName() //Method, Public, Void return type.
        {
            Console.WriteLine("Name: " + firstName + " " + lastName); //Prints string and two values.
        }
    }
}
