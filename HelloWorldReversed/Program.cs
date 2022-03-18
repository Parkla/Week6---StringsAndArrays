using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset 'Hello World' tagurpidi

            Console.WriteLine("Sisestage sõna:");

            string newWord = Console.ReadLine();

            for(int i = newWord.Length-1; i >= 0; i--)
            {
                Console.Write(newWord[i]);
            }
        }
    }
}
