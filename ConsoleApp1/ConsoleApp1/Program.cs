using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            ///  Exception Example
            ///  

            // Structura try - care ruleaza o secventa de cod si o incearca. (Structura care este verificata)
            try
            {

            }
            catch (NullReferenceException exception)
            {
                /// Secventa de cod care se ruleaza in cazul in care se prinde NullReferenceException
            }
            // Prinde exceptia de tip Exception daca aceasta este aruncata in blocul de Try. Daca este aruncata atunci ruleaza urmatoarea secventa
            catch (Exception exception)
            {
                // Secventa de cod care se ruleaza in cazul in care se prinde o exceptie de tip Exception


            }


            Person person  = null;

            try
            {
                string name = person.getName();

            }
            catch (NullReferenceException exception) {
                Console.WriteLine(exception.Message);
            }

            int a = 0;
            int b = 5;

            try
            {
                b = b / a;

            }
            catch (DivideByZeroException exception) {

                Console.WriteLine("Incearca dinou cu alte numere");
            }

            Person person2 = new Person();

            try
            {
                person2.setAge(-10);
            }
            // daca nu sti pui clasa parinte Exception
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }


        }
    }
}
