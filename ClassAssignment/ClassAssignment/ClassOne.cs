using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public class ClassOne
    {
        //Step 1 + 6: (Void Method) + (Declare a Method Static)
        public static void methodOne(int userInput) //Property is 'public'. Data Type is 'int'. Name is 'methodOne'. Parameters are 'int userInput'.
        {
            int divideByTwo = userInput / 2; //Assigning math operation to a variable.
            return;
        }

        //Step 4. (Method with Output Parameters)
        public int methodTwo(out int num) => num = 22; //Property is 'public'. Data Type is 'int'. Name is 'methodTwo'.

        //Step 5. (Overload Method)
        public int methodThree(int a, int b) //Property is 'public'. Data Type is 'int'. Name is 'methodThree'. Parameters are 'int a, int b'.
        {
            int sum = a + b; //Assigning math operation to a variable.
            return sum; //Return result.
        }
        public int methodThree(int a, int b, int c) //Property is 'public'. Data Type is 'int'. Name is 'methodThree'. Parameters are 'int a, int b, int c'.
        {
            int sum = a + b + c; //Assigning math operation to a variable.
            return sum; //Return result.
        }
    }
}
