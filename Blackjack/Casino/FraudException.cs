using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException : Exception //Public, with Inheretance from 'Exception'.
    {
        public FraudException()
            : base() { } //Inhereting from 'base' constructor.
        public FraudException(string message)
            : base(message) { } //Inhereting from 'base' constructor.
    }
}
