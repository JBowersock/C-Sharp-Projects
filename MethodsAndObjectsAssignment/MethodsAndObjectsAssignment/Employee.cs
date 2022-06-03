using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Employee : Person //Inhereting from the class 'Person'.
    {
        public List<string> FirstName { get; set; }
        public List<string> LastName { get; set; }

        public int Id = 20; //property
    }
}
