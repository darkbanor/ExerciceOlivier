using System;
using ClassLibraryBouteille;

namespace ConsoleAppBouteille
{
    class Program
    {
        static void Main(string[] args)
        {
            Bouteille uneBouteilleDeperrier;
            uneBouteilleDeperrier = new Bouteille(1.5, 80, false);

            Console.WriteLine(uneBouteilleDeperrier.ToString());                        

            uneBouteilleDeperrier.Ouvrir();

            Console.WriteLine();
            Console.WriteLine("données de Ouvrir ");
            Console.WriteLine(uneBouteilleDeperrier.ToString());

            uneBouteilleDeperrier.AOterEnLitre();

            Console.WriteLine();
            Console.WriteLine("données de AOterEnLitre ");
            Console.WriteLine(uneBouteilleDeperrier.ToString());            

            uneBouteilleDeperrier.ViderTout();

            Console.WriteLine();
            Console.WriteLine("données de ViderTout ");          
            Console.WriteLine(uneBouteilleDeperrier.ToString());

            uneBouteilleDeperrier.Fermer();

            Console.WriteLine();
            Console.WriteLine("données de Fermer ");           
            Console.WriteLine(uneBouteilleDeperrier.ToString());

            

        }
    }
}
