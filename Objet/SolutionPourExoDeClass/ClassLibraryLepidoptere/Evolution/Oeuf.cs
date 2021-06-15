using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere.Evolution
{
    public class Oeuf : Evolution.StadeDEvolution
    {
        uint diametre = 2;
        public override StadeDEvolution DonnerProchainStade()
        {
            return new Chenille();
        }

        public override void SeDeplacer()
        {
            Console.WriteLine("Je ne sais pas me déplacer");
        }

        public override string ToString()
        {
            return base.ToString() + " diametre oeuf = "+ diametre;
        }
    }
}