using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryLepidoptere;


namespace ConsoleAppLepidoptere
{
    class Program
    {
        static void Main(string[] args)
        {
            Lepidoptere gargouille;
            gargouille = new Lepidoptere("Garf");

            gargouille.SeDeplacer();

            Console.WriteLine(gargouille.ToString());

            gargouille.SeTransformerObjet();

            Console.WriteLine(gargouille.ToString());   




            Console.ReadKey();
        }
    }
}
