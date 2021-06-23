using ClassLibraryPointGeo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPointGeo
{
    class Program
    {
        static void Main(string[] args)
        {
            //cree premier coordonnee par defaut
            Point ncoor = new Point();

            //afficher ncoor
            Console.WriteLine("Absisse X,  Ordonnee Y");
            Console.WriteLine(ncoor.ToString());

            //deplacer Point
            ncoor.Deplacer(1, 2);

            //afficher ncoor
            Console.WriteLine("nouveau coordonnee : Absisse X,  Ordonnee Y");
            Console.WriteLine(ncoor.ToString());

            ncoor.SymetrieAxeOrigine();

            Console.WriteLine("Symetrie axe Origine : ");
            Console.WriteLine(ncoor.ToString());

            ncoor.SymetrieAxeOrigine();
            Console.WriteLine(ncoor.ToString());

            ncoor.Permuter();
            Console.WriteLine("Permutation  : ");
            Console.WriteLine(ncoor.ToString());








            Console.ReadKey();
        }

    }
}
