using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //Step 3.
    class Employee : Person //Inheriting from class 'Person'.
    {
        //Step 4.
        public void SayName() //Public void Method.
        {
            Console.WriteLine(firstName + " " + lastName); //Prints two values.
        }
    }
}
