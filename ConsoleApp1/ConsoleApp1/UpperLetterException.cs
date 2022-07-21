using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class UpperLetterException : Exception
    {
        public UpperLetterException(string mesaj) : base(mesaj + " litera mare nu exista")
        {

        }
    }
}
