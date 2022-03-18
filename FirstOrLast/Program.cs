using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kontrollib andmete pikkust eraldi
            //programm kuvab kumb nendest on pikem, kas ees- või perekonnanime

            Console.WriteLine("Palun sisestada eesnimi");
            string firstName = Console.ReadLine();
            Console.WriteLine("Palun sisesta perekonnanimi");
            string lastName = Console.ReadLine();
            if(firstName.Length > lastName.Length)
            {
                Console.WriteLine("Eesnimi on pikem");
            }

            else if(lastName.Length > firstName.Length)
            {
                Console.WriteLine("Perekonnanimi on pikem");
            }
                             
                    

            

            
        }
    }
}
