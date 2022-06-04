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

            //Second person.
            personTwo.firstName = "Cindy-Lou"; //Assigning firstName.
            personTwo.lastName = "Who"; //Assigning lastName.

            personTwo.sayName(); //Calling method from class 'Person'. (Result: Prints string.)

            if(personOne.id == personTwo.id) //If statement, Parameters set with Equality Operator.
            {
                Console.WriteLine("The id for these two people match!"); //Prints string.
            }
            else //Else statement.
            {
                Console.WriteLine("The id for these two people do not match."); //Prints string.
            }

            Console.ReadLine(); //Allows window to remain open until user closes.
        }
    }
}
