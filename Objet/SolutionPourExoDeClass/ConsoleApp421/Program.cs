using System;
using ClassLibrary421;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp421
{
    class Program
    {
        static void Main(string[] args)
        {
            De de1 = new De();
            De de2 = new De();
            De de3 = new De();

            AfficheDe(de1, de2, de3);

            Console.WriteLine("Combien de Dé voulez vous re lancer (1, 2 ou 3) ? ");
            int saisie = 0;
            int saisie1 = 0;
            int saisie2 = 0;
            int saisie2a = 0;
            int saisie3 = 0;

            saisie = int.Parse(Console.ReadLine()); // nombre de Dé a jeter

            if (saisie == 1)
            {
                Console.WriteLine("Quel numéro de Dé voulez vous relancer (1, 2 ou 3) ?");

                saisie1 = int.Parse(Console.ReadLine()); // jeter qu'un seul Dé
                if (saisie1 == 1)
                {
                    de1.SeJeter();
                }
                else if (saisie1 == 2)
                {
                    de2.SeJeter();
                }
                else if (saisie1 == 3)
                {
                    de3.SeJeter();
                }
              
            }
            else if (saisie == 2)
            {
                Console.WriteLine("Quel sont les numéros des 2 Dés que voulez vous relancer (parmis 1, 2 ou 3) ?");
                Console.WriteLine("Premier numéro ?");
                saisie2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Deuxieme numéros ?");
                saisie2a = int.Parse(Console.ReadLine());

                if (saisie2 == 1)
                {
                    de1.SeJeter();
                }
                else if (saisie2 == 2)
                {
                    de2.SeJeter();
                }
                else if (saisie2 == 3)
                {
                    de3.SeJeter();
                }
                if (saisie2a == 1)
                {
                    de1.SeJeter();
                }
                else if (saisie2a == 2)
                {
                    de2.SeJeter();
                }
                else if (saisie2a == 3)
                {
                    de3.SeJeter();
                }
            }
            else if (saisie == 3)
            {
                de1.SeJeter();
                de2.SeJeter();
                de3.SeJeter();
            }

            AfficheDe(de1, de2, de3);


            Console.ReadKey();
        }
        public static void AfficheDe(De _de1, De _de2, De _de3)
        {
            Console.WriteLine("Valeur du Dé 1 = " + _de1);
            Console.WriteLine("Valeur du Dé 2 = " + _de2);
            Console.WriteLine("Valeur du Dé 3 = " + _de3);
        
        }
    }
}
