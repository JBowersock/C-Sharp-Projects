using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee personOne = new Employee(); //Instantiating class object.
            Employee personTwo = new Employee(); //Instantiating class object.

            //First person.
            personOne.firstName = "Joe"; //Assigning firstName.
            personOne.lastName = "Schmoe"; //Assigning lastName.
            personOne.id = 001; //Assigning Id.

            //Second person.
            personTwo.firstName = "Cindy-Lou"; //Assigning firstName.
            personTwo.lastName = "Who"; //Assigning lastName.
            personTwo.id = 002; //Assigning Id.

            personTwo.sayName(); //Calling method from class 'Person'. (Result: Prints string.)

            Console.WriteLine(personOne == personTwo); //Checking to see personOne & Two are the same.

            Console.ReadLine(); //Allows window to remain open until user closes.
        }
    }
}
