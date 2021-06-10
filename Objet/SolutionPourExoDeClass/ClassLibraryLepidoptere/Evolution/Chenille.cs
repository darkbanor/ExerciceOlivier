using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere.Evolution
{
    public class Chenille : StadeDEvolution
    {
        public override StadeDEvolution DonnerProchainStade()
        {
            return new Chrysalide();
        }

        public override void SeDeplacer()
        {
            Console.WriteLine("Je rampe");
        }
    }
}