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
            Console.WriteLine(f1.ToString());
            Console.WriteLine(f1.Resultat());

            f1.Oppose();
            //f1.Inverse();
            Console.WriteLine("oppose = "+f1.ToString());


            Fraction f2 = new Fraction();
            Console.WriteLine(f2.ToString());

            Fraction f3 = new Fraction(6);
            Console.WriteLine(f3.ToString());

            Fraction f = new Fraction(11, 7);
            Fraction f4 = new Fraction(84, 4);
            //bool estSuperieur1 = f.SuperieurA(f4); //pour tester true ou false
            int estSuperieur2 = f.CompareTo(f4);
            //Console.WriteLine("sup1= "+estSuperieur1.ToString());
            Console.WriteLine("sup2= "+estSuperieur2.ToString());

            Fraction f5 = new Fraction(11, 7);
            Fraction f6 = new Fraction(22, 14);
            bool estSuperieur3 = f5.EgalA(f6); //pour tester true ou false
            //int estSuperieur4 = f5.CompareTo(f6);
            Console.WriteLine("sup1= " + estSuperieur3.ToString());
            //Console.WriteLine("sup2= " + estSuperieur4.ToString());



            Console.ReadKey();
        }
    }
}
