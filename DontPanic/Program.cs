using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o tähed lauses "Dont Panic" nulliga
            //programm asendab kõik 'a' tähed samas lauses number neljaga

            string DontPanic = "Dont Panic";

            DontPanic = DontPanic.Replace('o', '0');
            DontPanic = DontPanic.Replace('a', '4');

            Console.WriteLine(DontPanic);


          
        }
    }
}
