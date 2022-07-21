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
        private List<int> phoneNumberList;
        private AnimalDeCompanie animalDeCompanie;

        public string getName() { 
            return name;
        }

        public void setAge(int age)
        {
            if (age < 0) {
                throw new ArgumentOutOfRangeException(age.ToString());
            }
        }

        public void setPhoneNumberList(List<int> phoneNumberList) {

            foreach (int phoneNumber in phoneNumberList) { 
                this.phoneNumberList.Add(phoneNumber);
            }
        }
        /*public List<int> getListGoala()
        {
            List<int> listaNeinitializata ;
            return listaNeinitializata;
        }*/
        public void setAnimalDeCompanie(AnimalDeCompanie animal) {

            if (animal == null)
            {
                throw new ArgumentNullException("Animal is Null");
            }

            this.animalDeCompanie = animal;
            Console.WriteLine(animal.nume);
        }

        public void setName(string name) {

            if (name.Length <= 5)
            {
                throw new StringTooShortException();
            }
            char firstLetter = name[0];
            if (!char.IsUpper(firstLetter)) {
                throw new UpperLetterException("Prima");
            }
        }

    }
}
