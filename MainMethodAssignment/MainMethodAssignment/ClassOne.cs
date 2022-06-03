using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class ClassOne
    {
        //Method
        public int Addition(int userChoice) //Property is 'public'. Data Type is 'int'. Name is 'Addition'. Then gave the parameter 'int userChoice'.
        {
            return userChoice + 12; //Returns calculation.
        }

        //Method (Note: named similarly to the one above, but done slightly differently).
        public int Addition(decimal userChoice2) //Property is 'public'. Data Type is 'int'. Name is 'Addition'. Then gave the parameter 'decimal userChoice'.
        {
            int num = Convert.ToInt32(userChoice2); //taking userchoice2, converting to and integer and saving to a variable named num.
            return num + 3; //Returns calculation.
        }

        //Method (Note: named similarly to the two above, but done slightly differently).
        public int Addition(string userChoice3) //Property is 'public'. Data Type is 'int'. Name is 'Addition'. Then gave the parameter 'string userChoice'.
        {
            int num = Convert.ToInt32(userChoice3); //taking userchoice3, converting to and integer and saving to a variable named num.
            return num + 33; //Returns calculation.
        }
    }
}
