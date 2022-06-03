using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class ClassOne
    {
        public int methodOne(int userChoice1, int userChoice2 = 0) 
        //By inserting '= 0' here, it will utilize a default value of 0 for the second parameter (userChoice2). So, if the user doesnt enter a number the procedure will continue.
        {
            return userChoice1 + userChoice2;
        }
    }
}
