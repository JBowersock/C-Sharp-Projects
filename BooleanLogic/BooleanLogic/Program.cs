using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //AND Operator ( && ) [All must be True to result: True]
            Console.WriteLine(true && false); //Result: False. Only 1 of the two are 'True'.
            Console.WriteLine(true && true); //Result: True. Both are True.
            Console.WriteLine(false && false); //Result: False. Neither of the two are True.

            Console.WriteLine(); //Line Break

            //OR Operator ( || ) [Only one must be True to result: True]
            Console.WriteLine(true || true); //Result: True.
            Console.WriteLine(true || false); //Result: True.
            Console.WriteLine(false || false); //Result: False.

            Console.WriteLine(); //Line Break

            //EQUALS Operator ( == ) [Both must be the same to result: True]
            Console.WriteLine(true == true); //Result: True.
            Console.WriteLine(true == false); //Result: False.
            Console.WriteLine(false == false); //Result: True.

            Console.WriteLine(); //Line Break

            //DOES NOT EQUAL Operator ( == ) [Neither must be the same to result: True]
            Console.WriteLine(true != true); //Result: False.
            Console.WriteLine(true != false); //Result: True.
            Console.WriteLine(false != false); //Result: False.

            Console.WriteLine(); //Line Break

            //XOR Operator ( ^ ) [Will result:True if one is 'true', but not both.]
            Console.WriteLine(true ^ true); //Result: False.
            Console.WriteLine(true ^ false); //Result: True.
            Console.WriteLine(false ^ false); //Result: False.

            Console.WriteLine(); //Line Break

            Console.ReadLine();
        }
    }
}
