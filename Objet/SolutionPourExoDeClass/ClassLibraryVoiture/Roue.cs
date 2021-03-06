using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryVoiture
{
    class Roue
    {
        private bool tourne;
        private int diametre;

        public Roue() //defaut
        {
            tourne = false;
            diametre = 17;
        }
        public Roue(bool tourne, int diametre) //classique
        {
            this.tourne = tourne;
            this.diametre = diametre;
        }
        public Roue(int diametre) //melange classic et defaut
        {
            this.tourne = false;
            this.diametre = diametre;
        }

        public Roue(Roue _roueARecopier) // par recopie
        {
            this.tourne = _roueARecopier.tourne;
            this.diametre = _roueARecopier.diametre;
        }

        public bool Tourner()
        {
            bool ok = false;

            if (!tourne)
            {
                tourne = true;
                ok = true;
            }
            return ok;
        }

        public bool Arreter()
        {
            bool ok = true;

            if (tourne == true)
            {
                tourne = false;
                ok = false;
            }
            
            return ok;
        }
    }
}