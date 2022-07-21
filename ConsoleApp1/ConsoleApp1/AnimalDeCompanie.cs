using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AnimalDeCompanie
    {
        public string nume;


        public void setNume(string nume) {
            if (nume.Length < 3)
            {
                throw new StringTooShortException(nume);
            }
        }
    }
}
