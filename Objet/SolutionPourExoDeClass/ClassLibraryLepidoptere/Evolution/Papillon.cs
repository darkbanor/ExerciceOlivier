using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere.Evolution
{
    public class Papillon : StadeDEvolution
    {
        public override StadeDEvolution DonnerProchainStade()
        {
            return new Papillon();
        }

        public override void SeDeplacer()
        {
            Console.WriteLine("Je vole");
        }
    }
}