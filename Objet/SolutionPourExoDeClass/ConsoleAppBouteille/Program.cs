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

            Bouteille uneBouteilleDeCola;
            uneBouteilleDeCola = new Bouteille(2, 50, true);

            Console.WriteLine(uneBouteilleDeperrier.ToString());
            Console.WriteLine(uneBouteilleDeCola.ToString());

            uneBouteilleDeperrier.Ouvrir();            

            Console.WriteLine();
            Console.WriteLine("données de bouteille de perrier Ouvrir ");
            Console.WriteLine(uneBouteilleDeperrier.ToString());

            uneBouteilleDeCola.Ouvrir();

            Console.WriteLine();
            Console.WriteLine("données bouteille de Cola de Fermer ");
            Console.WriteLine(uneBouteilleDeCola.ToString());

            uneBouteilleDeperrier.AOterEnLitre();
            uneBouteilleDeCola.AOterEnLitre();

            Console.WriteLine();
            Console.WriteLine("données de AOterEnLitre ");
            Console.WriteLine(uneBouteilleDeperrier.ToString());
            Console.WriteLine(uneBouteilleDeCola.ToString());

            uneBouteilleDeperrier.ViderTout();

            Console.WriteLine();
            Console.WriteLine("données de ViderTout ");          
            Console.WriteLine(uneBouteilleDeperrier.ToString());

            //uneBouteilleDeperrier.Fermer();

            //Console.WriteLine();
            //Console.WriteLine("données de Fermer ");           
            //Console.WriteLine(uneBouteilleDeperrier.ToString());

            uneBouteilleDeperrier.RemplirEnPourcentage();

            Console.WriteLine();
            Console.WriteLine("données de Remplir En % ");
            Console.WriteLine(uneBouteilleDeperrier.ToString());



        }
    }
}
