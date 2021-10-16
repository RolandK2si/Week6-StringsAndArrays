using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Don't panic" nulliga (0)
            //programm asendab kõik 'a' tähed samas lauses number neljaga

            string fullLause = "Don't panic";

            fullLause = fullLause.Replace('o', '0');
            fullLause = fullLause.Replace('a', '4');

            Console.WriteLine(fullLause);

        }
    }
}
