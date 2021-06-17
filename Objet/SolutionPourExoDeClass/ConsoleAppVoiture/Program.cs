using ClassLibraryVoiture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVoiture
{
    class Program
    {
        static void Main(string[] args)
        {
            //test cration de voiture
            Voiture maDacia; 
            maDacia = new Voiture();
            
            Voiture ma206 = new Voiture(maDacia); //par recopie

            //test pour voir si la voiture a demarrer 
            //maDacia.Demarrer();
            ma206.Demarrer();
            bool aReussitADemarrerMaDacia = maDacia.Demarrer();
            bool aReussitADemarrerMa206 = maDacia.Demarrer();
            Console.WriteLine("MaDacia = " + maDacia + " demarrer = " + aReussitADemarrerMaDacia);
            Console.WriteLine("Ma206 = " + ma206 + " demarrer = " + aReussitADemarrerMa206);

            //test entre voiture et voiture par recopie par gethashcode
            ma206.GetHashCode();
            maDacia.GetHashCode();
            Console.WriteLine("Hascode Dacia = " + maDacia + " " + maDacia.GetHashCode());
            Console.WriteLine("Hascode ma206 = " + ma206 + " " + ma206.GetHashCode());

            //entrainement des roues
            //maDacia.Avancer();
            bool avance = maDacia.Avancer();
            Console.WriteLine("MaDacia = " + maDacia + " Avancer = " + avance);

            //arret de la voiture
            maDacia.Arreter();
            bool arreter = maDacia.Arreter();
            Console.WriteLine("MaDacia = " + maDacia + " Arreter = " + arreter);



            //Console.WriteLine("roue = " + comteurEnKM);
            


            Console.ReadKey();
        }
    }
}
