using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryCompteBancaire;

namespace ConsoleAppCompteBancaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte c = new Compte();
            Compte c1 = new Compte("toto", 654321, -500, -100);

            Console.WriteLine(c.ToString());
            Console.WriteLine(c1.ToString());

            Compte b = new Compte("laurent", 546254, 2000, -500);
            b.Crediter(100);
            Console.WriteLine(b);
            bool ok = b.Debiter(100000);
            Console.WriteLine(b.ToString());
            if (ok)
            {
                Console.WriteLine("Débit Réussi !");
            }
            else
            {
                Console.WriteLine("Débit pas Réussi !");
            }

            // get Solde
            //c1.Solde;

            //pour test de débit
            bool ok1 = b.Debiter(123);
            Console.WriteLine(b.ToString());
            if (ok1)
            {
                Console.WriteLine("Débit Réussi !");
            }
            else
            {
                Console.WriteLine("Débit pas Réussi !");
            }
            //

            //transfert d'une sommes
            Compte c2 = new Compte("tata", 12345, 2000, -500);
            Compte c3 = new Compte("titi", 45657, 1000, -1000);
            
            c2.Transferer(3300, c3);

            Console.WriteLine(c2.ToString());
            Console.WriteLine(c3.ToString());

            if (c2.Superieur(c3))
            {
                Console.WriteLine("superieur");
            }
            else
            {
                Console.WriteLine("inferieur");
            }
            
            
            
            Console.ReadKey();
        }
    }
}
