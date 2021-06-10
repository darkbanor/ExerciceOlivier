using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere.Evolution
{
    public class Oeuf : Evolution.StadeDEvolution
    {
        public override StadeDEvolution DonnerProchainStade()
        {
            return new Chenille();
        }

        public override void SeDeplacer()
        {
            Console.WriteLine("Je ne sais pas me déplacer");
        }
    }
}