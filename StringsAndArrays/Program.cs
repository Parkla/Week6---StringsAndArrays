using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm kuvab kasutaja eesnime pikkust

            Console.WriteLine("Sisetage eesnimi");
            string firstName = Console.ReadLine();

            //int firstNameLenght = firstName.Lenght
                     
            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit");
        }
    }
}
