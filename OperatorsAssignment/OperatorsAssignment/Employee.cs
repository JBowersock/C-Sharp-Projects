using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee : Person //Class, Public, also Inhereting from class 'Person'.
    {
        public int id { get; set; } //Properties, then Get/Set Method.

        public override void sayName() //Method.
        {
            Console.WriteLine("Employee ID: 113"); //Prints string.
            base.sayName(); //Prints method from class 'Person'.
        }
    }
}
