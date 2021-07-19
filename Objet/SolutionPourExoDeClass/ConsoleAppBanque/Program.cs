using ClassLibraryCompteBancaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBanque
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<Compte> mesComptes = new List<Compte>();
            //Compte lise = new Compte(1568, "lise", 1000, 300);
            //Compte elisa = new Compte(2548, "elisa", 2100, 300);
            //mesComptes.Add(lise);
            //mesComptes.Add(elisa);
            //mesComptes.Sort();
            //int r = lise.CompareTo(elisa);
            //Console.WriteLine(lise.ToString());
            //Console.WriteLine(elisa.ToString());
            //Console.WriteLine("lise compareTo Lisa (-1 inferieur, 0 egal, 1 superieur) = " + r.ToString());
            //Console.WriteLine();

            Console.OutputEncoding = Encoding.UTF8;

            Banque b = new Banque("Credit mumut", "Mulhouse");
            b.AjouterCompte(1251, "Robert", 1000, 300);

            Compte cDenis = new Compte(4784, "Denis", 2000, 300);
            b.AjouterCompte(cDenis);

            b.AjouterCompte(8451, "Jocia", 2500, -10);
            b.AjouterCompte(120145, "BillGate", 250000, -10000);
            b.AjouterCompte(3254, "Bernard", -40, 0);

            Console.WriteLine(b.ToString());

            Console.WriteLine("le compte avec le plus de solde pour la banque Credit mumut = ");
            Console.WriteLine(b.CompteSup().ToString());

            Console.WriteLine("Quel numero de compte recherchez vous ? = ");
            int saisie = 0;
            saisie = int.Parse(Console.ReadLine());

            if (b.RendCompte(saisie) == null)
            {
                Console.WriteLine("Pas trouver ! ");
            }
            else
            {
                Console.WriteLine(b.RendCompte(saisie).ToString());
            }

            Console.WriteLine();
            Banque c = new Banque("Banque Pop", "Colmar");
            c.AjouterCompte(1245, "Francois", 2000, 300);
            c.AjouterCompte(2568, "Denis", 1000, 300);

            if (c.Transferer(1245, 2568, 1000))
            {
                Console.WriteLine("transfert effectué");
            }
            else
            {
                Console.WriteLine("tranfert impossible");
            }
            bool resultat = c.Transferer(1245, 2568, 5000);

            Console.WriteLine("Résultat de transfert 5000 ="+resultat);
            Console.WriteLine(c.ToString());

            Console.ReadKey();
        }
    }
}
