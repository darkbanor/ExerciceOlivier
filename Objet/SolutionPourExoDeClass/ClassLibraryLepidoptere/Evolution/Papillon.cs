using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere.Evolution
{
    public class Papillon : StadeDEvolution
    {
        const int poids = 2;
        public override StadeDEvolution DonnerProchainStade()
        {
            return this;
        }

        public override void SeDeplacer()
        {
            Console.WriteLine("Je vole");
        }

        public override string ToString()
        {
            return base.ToString() +poids;
        }
    }
}