using ClassLibraryFraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(12, 7);
            Console.WriteLine("Affiche valeur f1 et sa sommes ");
            Console.WriteLine(f1.ToString());
            Console.WriteLine(f1.GetValue());

            Console.WriteLine("Affiche valeur f2 qui est par defaut ");
            Fraction f2 = new Fraction();
            Console.WriteLine(f2.ToString());


            f1.Oppose();
            //f1.Inverse();
            Console.WriteLine("oppose = "+f1.ToString());

            Console.WriteLine("Affiche valeur f3 une seul chiffre ");
            Fraction f3 = new Fraction(6);
            Console.WriteLine(f3.ToString());

            Fraction f = new Fraction(11, 7);
            Fraction f4 = new Fraction(84, 4);
            //bool estSuperieur1 = f.SuperieurA(f4); //pour tester true ou false
            int estSuperieur2 = f.CompareTo(f4);
            //Console.WriteLine("sup1= "+estSuperieur1.ToString());
            Console.WriteLine("f compareTo (f4) = "+estSuperieur2.ToString());

            Fraction f5 = new Fraction(5, 7);
            Fraction f6 = new Fraction(9, -8);
            Console.WriteLine("f5 = "+ f5.ToString());
            Console.WriteLine("f6 = " + f6.ToString());
            Console.WriteLine("Affiche f5 est il egal à f6 = ");
            bool estSuperieur3 = f5.EgalA(f6); //pour tester true ou false
            //int estSuperieur4 = f5.CompareTo(f6);
            Console.WriteLine("sup1= " + estSuperieur3.ToString());
            //Console.WriteLine("sup2= " + estSuperieur4.ToString());

            Console.WriteLine("Affiche addition deux fraction f5 et f6 ");
            Fraction resultatPlus= f5.Plus(f6);
            Console.WriteLine(resultatPlus);

            Console.WriteLine("Affiche surcharge addition deux fraction f5 + f6 ");
            Fraction FPlus = f5 + f6;
            Console.WriteLine(FPlus);

            Console.WriteLine("Affiche soustraction deux fraction f5 et f6 ");
            Fraction resultatMoins = f5.Moins(f6);
            Console.WriteLine(resultatMoins);

            Console.WriteLine("Affiche multiplication deux fraction f5 et f6 ");
            Fraction resultatMultiple = f5.Multiplie(f6);
            Console.WriteLine(resultatMultiple);

            Console.WriteLine("Affiche division deux fraction f5 et f6 ");
            Fraction resultatDivise = f5.Divise(f6);
            Console.WriteLine(resultatDivise);




            Console.ReadKey();
        }
    }
}
