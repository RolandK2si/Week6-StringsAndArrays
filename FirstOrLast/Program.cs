using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendest on pikem

            Console.WriteLine("Palun sisesta oma eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Palun sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine();

            int firstNameLenght = firstName.Length;
            int lastNameLenght = lastName.Length;

            if(firstNameLenght > lastNameLenght)
            {
                Console.WriteLine("Sinu eesnimi on pikem kui sinu perekonnanimi.");
            }
            else if(firstNameLenght < lastNameLenght)
            {
                Console.WriteLine("Sinu perekonnanimi on pikem kui sinu eesnimi.");
            }
            else
            {
                Console.WriteLine("Sinu ees- ja perekonnanimes on sama palju sümboleid.");
            }

        }
    }
}
