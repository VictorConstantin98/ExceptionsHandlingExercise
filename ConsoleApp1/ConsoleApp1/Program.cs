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

            int varsta = 0;
            int b = 5;

            try
            {
                b = b / varsta;

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


            AnimalDeCompanie animal = null;

            try
            {
                person.setAnimalDeCompanie(animal);
            }
            catch (NullReferenceException ex)  // Null Reference Exception
            {
                Console.WriteLine(ex.Message);
            }

            // Citire fisier
           
            string content = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(),"\\file2.txt"));

            try
            {
                content = System.IO.File.ReadAllText(@"C:\file.txt");  // FileNotFoundException - Fisierul nu exista

            } catch(FileNotFoundException ex)
            {
                
                Console.WriteLine("Retry to load the file");
            }


            //System.ArgumentOutOfRangeException + IndexOutRangeException;

            List<int> listOre = new List<int>();
            listOre.Add(1);
            listOre.Add(2);
            listOre.Add(3);

            try
            {
                int ora = listOre[3]; // aici se arunca;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                string mesajEroare = ex.ActualValue + "is the problem as it is to big, the capacity is " + listOre.Count;
                Console.WriteLine(mesajEroare);

            }

               string[] Nume = content.Split("\r\n");

                Console.WriteLine(Nume[0]);
                try
                {
                Console.WriteLine(Nume[4]); // arunca IndexOutOfRange pentru ca nu avem decat 3 elemente deci ultimul este 2;
                } catch(IndexOutOfRangeException ex)
                {
                Console.WriteLine("We have just " + Nume.Length+ "positions");
                }

                string url = "www.google.com";

                string[] parts = url.Split(".");
                
                Console.WriteLine("Extensia URL-ului este: "+ parts[2]);


                  string url2 = "google.com";

                  string[] parts2 = url2.Split(".");
            try
            {
                Console.WriteLine("Extensia URL-ului este: " + parts2[2]); // arunca excepti pentru ca URL-ul nu este corect;
            }
            catch
            {
                Console.WriteLine("Prins in Catch: Extensia URL-ului este: " + parts2[1]);
            }

            /*int varsta = 5;

            person2 = (Person)varsta;*/

           /* object o = "10";
            int x = (int)o;
*/
            Person persoana3 = new Baiat();  // downcast - cast de la un obiect copil la un obiect parinte

            try
            {
                Fata fata = (Fata)persoana3;  //upcast - cast de la un obiect parinte la un obiect copil
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }


            /// Custom Exception Handling
            /// 
            try
            {
                animal = new AnimalDeCompanie();
                animal.setNume("bc");
            }
            catch (StringTooShortException ex)
            {
                Console.WriteLine(ex.Message);
            }


            try
            {
                person2.setName("Ana");
            }
            catch (StringTooShortException ex)
            {
                Console.WriteLine(ex.Message); // arunca prima exceptie
            }
            catch (UpperLetterException ex) {
                Console.WriteLine(ex.Message);
            }


            try
            {
                person2.setName("alexandru");
            }
            catch (StringTooShortException ex)
            {
                Console.WriteLine(ex.Message); 
            }
            catch (UpperLetterException ex)
            {
                Console.WriteLine(ex.Message); // arunca a doua exceptie
            }

            try
            {
                person2.setName("Alexandru"); // a mers
            }
            catch (StringTooShortException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UpperLetterException ex)
            {
                Console.WriteLine(ex.Message); 
            }
        }
    }
}
