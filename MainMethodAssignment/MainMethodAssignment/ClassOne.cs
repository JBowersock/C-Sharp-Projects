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
        public double Addition(double userChoice2) //Property is 'public'. Data Type is 'Double'. Name is 'Addition'. Then gave the parameter 'Double userChoice'.
        {
            return userChoice2 + 0.12; //Returns calculation.
        }

        //Method (Note: named similarly to the two above, but done slightly differently).
        public string Addition(string userChoice3) //Property is 'public'. Data Type is 'string'. Name is 'Addition'. Then gave the parameter 'string userChoice'.
        {
            return userChoice3 + 33; //Returns calculation.
        }
    }
}
