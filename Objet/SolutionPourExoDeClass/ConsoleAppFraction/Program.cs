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
            Console.WriteLine("Fraction f1 = {0} et sa sommes {1}",f1.ToString(), f1.GetValue());
            Console.WriteLine();

            Console.Write($"Fraction par defaut f2 = new Fraction(); ");
            Fraction f2 = new Fraction();
            Console.WriteLine(f2.ToString());
            Console.WriteLine();


            f1.Oppose();
            //f1.Inverse();
            Console.Write("Oppose de f1 = "+f1.ToString());
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Fraction f3 = new Fraction (6) = ");
            Fraction f3 = new Fraction(6);
            Console.WriteLine(f3.ToString());
            Console.WriteLine();

            Fraction f = new Fraction(11, 7);
            Fraction f4 = new Fraction(22, 14);
            Console.WriteLine("f = " + f.ToString());
            Console.WriteLine("f4 = " + f4.ToString());
            bool estSuperieur1 = f.SuperieurA(f4); //pour tester true ou false
            Console.WriteLine($"f est-il superieur à f4 SuperieuA methode (true ou false) = " + estSuperieur1.ToString());
            int estSuperieur2 = f.CompareTo(f4);
            Console.WriteLine($"f et f4 avec compareTo methode (-1 false (inferieur), 0 egal, 1 true(superieur)) = "+estSuperieur2.ToString());
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Resultat des operations Pour les fractions f5 et f6 ");
            Fraction f5 = new Fraction(5, 7);
            Fraction f6 = new Fraction(9, 8);
            Console.WriteLine("f5 = "+ f5.ToString());
            Console.WriteLine("f6 = " + f6.ToString());
            //Console.Write("f5 est il egal à f6 true ou false = ");
            //bool estSuperieur3 = f5.EgalA(f6); //pour tester true ou false
            //int estSuperieur4 = f5.CompareTo(f6);
            //Console.WriteLine(estSuperieur3.ToString());
            //Console.WriteLine("f5 est-il superieur à f6 en Compareto methode = " + estSuperieur4.ToString());

            Fraction resultatPlus= f5.Plus(f6);
            Console.Write($"Addition _f5Plus(f6)_ = ");
            Console.WriteLine(resultatPlus);

            Fraction fPlus = f5 + f6;
            Console.Write($"Addition surcharge _f5+f6_ = ");
            Console.WriteLine(fPlus);

            Console.Write("Soustraction = ");
            Fraction resultatMoins = f5.Moins(f6);
            Console.WriteLine(resultatMoins);

            Console.Write("Multiplication = ");
            Fraction resultatMultiple = f5.Multiplie(f6);
            Console.WriteLine(resultatMultiple);

            Console.Write("Division = ");
            Fraction resultatDivise = f5.Divise(f6);
            Console.WriteLine(resultatDivise);




            Console.ReadKey();
        }
    }
}
