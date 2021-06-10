using ClassLibraryBouteille;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBouteille
{
    class Program
    {
        static void Main(string[] args)
        {
            Bouteille uneBouteilleDeperrier;
            uneBouteilleDeperrier = new Bouteille(1.5, 80, true);

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
            Console.WriteLine("A oter en litre ");
            Console.WriteLine(uneBouteilleDeperrier.ToString());
            Console.WriteLine("on doit vider = " + uneBouteilleDeperrier.AOterEnLitre());
            Console.WriteLine(uneBouteilleDeCola.ToString());
            Console.WriteLine("on doit vider = " + uneBouteilleDeCola.AOterEnLitre());
            


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

            ////////////////////
            /// 
            //Bouteille uneBouteilleDeperrier;
            //uneBouteilleDeperrier = new Bouteille(1.5, 80, false);

            //uneBouteilleDeperrier.Ouvrir();
            //bool test = uneBouteilleDeperrier.Ouvrir();

            //Assert.AreEqual(test, true);

            string sonStadeCourant = "papillon";

            string[] evolution = { "oeuf", "chenille", "chrysalide", "papillon" };

            string temp="papillon";


           for (int i=0; i<evolution.Length; i++)
            {
                Console.WriteLine("tableau = " + evolution [i]);

                if (sonStadeCourant == evolution [i] && sonStadeCourant != "papillon")
                {
                    //Console.WriteLine("dans boucle stade courant = " + evolution[i]);
                    temp = evolution[i+1];
                }
                
                
            } 

                Console.WriteLine("stade courant = " + sonStadeCourant + "stade evo = " + temp);

            Console.ReadKey();

        }
    }
}
