using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello World!" tagurpidi

            string fullLause = "Hello World!";

            for(int i = fullLause.Length-1; i >= 0; i--)
            {
                Console.Write(fullLause[i]);
            }
        }
    }
}
