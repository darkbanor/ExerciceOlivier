using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere.Evolution
{
    public abstract class StadeDEvolution
    {
        public abstract void SeDeplacer();
        public abstract StadeDEvolution DonnerProchainStade();

        public override string ToString()
        {
            return base.ToString();
        }

    }
}