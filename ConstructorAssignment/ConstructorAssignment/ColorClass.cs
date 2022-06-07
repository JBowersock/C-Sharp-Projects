using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class ColorClass //Public.
    {
        public ColorClass(string color3) : this(color3, "Purple") //Constructor name must be same as Class name.
        {
            //No return value needed.
        }

        public ColorClass(string color3, string color4) //Constructor name must be same as Class name.
        {
            Color3 = color3;
            Color4 = color4;
        }

        public string Color3 { get; set; }
        public string Color4 { get; set; }
    }
}
