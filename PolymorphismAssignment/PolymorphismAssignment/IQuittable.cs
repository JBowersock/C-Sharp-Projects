using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    //Step 1.
    public interface IQuittable
    {
        public void Quit()
        {
            Console.Write("This is a sentence.");
        }
    }
}
