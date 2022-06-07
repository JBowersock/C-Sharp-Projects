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
            base.sayName(); //Prints method from class 'Person'.
        }

        //Overloaded Operator (must have method for == and !=).
        public static bool operator ==(Employee employee1, Employee employee2) 
        {
            return employee1.id == employee2.id;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.id != employee2.id;
        }
    }
}
