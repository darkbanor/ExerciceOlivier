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
            //  exo Poo

            Compte c = new Compte();
            Compte c1 = new Compte("toto", 654321, 1000, -500); // nom, num de compte, solde, debit autoriser

            //affiche resultat conforme à exo 1.
            Console.WriteLine("------------resultats de la creation de comptes");
            Console.WriteLine(c.ToString());
            Console.WriteLine(c1.ToString());
            Console.WriteLine();

            //exercice 2. methode crediter et debiter
            Console.WriteLine("------------resultats exo pour crediter et debiter");
            Compte b = new Compte("laurent", 545454, 2000, -500);

            //afficher compte avant credit
            Console.WriteLine("avant crédit de 100");
            Console.WriteLine(b);
            b.Crediter(100);
            Console.WriteLine();

            //afficher compte apres debit
            Console.WriteLine("aprés crédit de 100");
            Console.WriteLine(b);
            Console.WriteLine();

            //afficher compte avant debit de 100000
            Console.WriteLine("avant débit de 100000");
            Console.WriteLine(b);
            Console.WriteLine();

            //afficher compte apres debit de 100000
            Console.WriteLine("aprés débit de 100000");
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
            Console.WriteLine();


            //transfert d'une sommes exo2
            Console.WriteLine("------------resultats exo pour transfert d'une somme");
            Compte c2 = new Compte("toto", 12345, 1000, -500); // c2 car c1 est utiliser
            Compte c3 = new Compte("titi", 45657, 2000, -1000);
            Compte c4 = new Compte("toto", 12345, 1000, -500);
            Compte c5 = new Compte("titi", 45657, 2000, -1000);

            //compte avant transfert 
            Console.WriteLine("compte avant tout transfert");
            Console.WriteLine(c2.ToString());
            Console.WriteLine(c3.ToString());
            Console.WriteLine();

            //aprés transfert 1300
            c2.Transferer(1300, c3); // c2=c1 c3=c2 dans exo

            Console.WriteLine("aprés transfert de 1300");
            Console.WriteLine(c2.ToString());
            Console.WriteLine(c3.ToString());
            Console.WriteLine();

            // transfert d'une somme 2ime partie
            c4.Transferer(3300, c5); // c4=c1 c5=c2 dans exo

            Console.WriteLine("aprés transfert de 3300 ");
            Console.WriteLine(c4.ToString());
            Console.WriteLine(c5.ToString());
            Console.WriteLine();

            //comparer 2 comptes
            Console.WriteLine("------------resultat exo compte courant est il superieur à :");
            //compte avant transfert 
            Console.WriteLine("compte :");
            Console.WriteLine(c4.ToString());
            Console.WriteLine("est compare à :");
            Console.WriteLine(c5.ToString());
            Console.WriteLine();

            if (c4.Superieur(c5)) // dans exo c4=c1 c5=c2
            {
                Console.WriteLine("résultat = superieur");
            }
            else
            {
                Console.WriteLine("résultat = inferieur");
            }


            Console.ReadKey();
        }
    }
}
