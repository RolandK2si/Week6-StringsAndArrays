using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis mitu 'h', 'o' ja 'l' tähte on lauses "Hello world!"

            string fullLause = "Hello World!".ToLower();

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for(int i = 0; i < fullLause.Length; i++)
            {
                if(fullLause[i] == 'h')
                {
                    hCounter++;
                }
                if(fullLause[i] == 'o')
                {
                    oCounter++;
                }
                if (fullLause[i] == 'l')
                {
                    lCounter++;
                }
            }

            Console.WriteLine($"Lauses 'Hello World' on {hCounter} 'h' tähte, {oCounter} 'o' tähte ja {lCounter} 'l' tähte.");

        }
    }
}
