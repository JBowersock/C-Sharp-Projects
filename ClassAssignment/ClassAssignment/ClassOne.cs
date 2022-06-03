using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public class ClassOne
    {
        //Step 1 (Void Method)
        public void methodOne(int userInput) //Property is 'public'. Data Type is 'int'. Name is 'methodOne'. Parameters are 'int userInput'.
        {
            Console.WriteLine(userInput / 2);
        }

        //Step 4. (Method with Output Parameters)
        public void methodTwo(out int num) 
        {
            num = 22;
        }         

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

    //Step 6.
    public static class ClassTwo //When class is 'static', all methods within must also be 'static' as well.
    {
        public static void methodFour()
        {
            Console.WriteLine("This is a message from my static class.");
        }
    }
}