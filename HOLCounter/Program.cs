using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o', ja 'l' tähte on lauses "Hello World!"

            Console.WriteLine("Sisestage sõna");

            string firstWord = Console.ReadLine();
            string lastWord = Console.ReadLine();
            string FullWord = $"{firstWord}{lastWord}".ToLower();
            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for(int i = 0; i < FullWord.Length; i++)
            {
                if(FullWord[i] == 'h')
                {
                    hCounter++;
                }
                else if(FullWord[i] == 'o')
                {
                    oCounter++;
                }
                else if(FullWord[i]=='l')
                {
                    lCounter++;
                }
                              
            }
            Console.WriteLine($"Sõnas 'Hello World' on {hCounter} 'h' täht, {oCounter} 'o' tähte ja {lCounter} 'l' tähte");

      
                

            
            




        }
    }
}
