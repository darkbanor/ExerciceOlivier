using ClassLibraryTelevision;
using System;

namespace ConsoleAppMonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Television laTeleDuSalon; // declatation
            laTeleDuSalon = new Television(); // initialisation par intanciation


            Television laTeleDuSalon2; // declatation
            laTeleDuSalon2 = new Television(true,20); // initialisation par intanciation

            Console.WriteLine( laTeleDuSalon.ToString ());

            laTeleDuSalon.Allume();

            Console.WriteLine(laTeleDuSalon.ToString());
            Console.WriteLine(laTeleDuSalon2.ToString());

        }
    }
}
