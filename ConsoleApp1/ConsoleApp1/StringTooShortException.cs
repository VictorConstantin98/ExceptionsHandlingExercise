using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StringTooShortException : Exception
    {
        public StringTooShortException() : base("The String is too small")
        {
        }

        // Mesaj Custom 
        /*public StringTooShortException(string message) : base(message)
        {
        }*/

        public StringTooShortException(string TooShortString) :
            base(TooShortString + " is too small")
        { 
        }

    }
}
