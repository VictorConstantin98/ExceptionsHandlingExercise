using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        private string name;
        private int age;

        public string getName() { 
            return name;
        }

        public void setAge(int age)
        {
            if (age < 0) {
                throw new ArgumentOutOfRangeException(age.ToString());
            }
        }
    }
}
