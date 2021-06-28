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
            Point ncoorClone = new Point(ncoor);

            //afficher ncoor
            Console.WriteLine("Absisse X,  Ordonnee Y");
            Console.WriteLine(ncoor.ToString());
            Console.WriteLine("Clone du point : " + ncoorClone.ToString());

            //deplacer Point
            ncoor.Deplacer(5, 12);

            //afficher ncoor
            Console.WriteLine("nouveau coordonnee apres deplacement: ");
            Console.WriteLine(ncoor.ToString());

            ncoor.SymetrieAxeAbsisse();
            Console.WriteLine("Symetrie axe Absisse : "+ncoor.SymetrieAxeAbsisse());

            ncoor.SymetrieAxeOrdonnee();
            Console.WriteLine("Symetrie axe Ordonnee : " + ncoor.SymetrieAxeOrdonnee());

            
            Point nouveauPointSymetriqueOrigine  = ncoor.SymetrieAxeOrigine();

            Console.WriteLine("Symetrie axe Origine : "+ nouveauPointSymetriqueOrigine.ToString());

            ncoor.Permuter();
            Console.WriteLine("Permutation  : " + ncoor.ToString());



            Console.ReadKey();
        }

    }
}
