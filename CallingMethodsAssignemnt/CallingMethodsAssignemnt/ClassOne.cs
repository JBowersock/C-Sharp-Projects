using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignemnt
{
    public class ClassOne //Class.
    {
        //Method1
        public int Addition(int userChoice) //Property is 'public'. Data Type is 'int'. Name is 'Addition'. Then gave the parameter 'int userChoice'.
        {
             return userChoice + 12; //Returns calculation.
        }

        //Method2
        public int Subtract(int userChoice) //Property is 'public'. Data Type is 'int'. Name is 'Subtract'. Then gave the parameter 'int userChoice'.
        {
            return userChoice - 8; //Returns calculation.
        }

        //Method3
        public int Multiply(int userChoice) //Property is 'public'. Data Type is 'int'. Name is 'Multiply'. Then gave the parameter 'int userChoice'.
        {
            return userChoice * 3; //Returns calculation.
        }
    }
}
