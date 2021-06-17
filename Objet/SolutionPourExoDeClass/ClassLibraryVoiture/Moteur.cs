using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryVoiture
{
    class Moteur
    {

        private bool estDemarre;
        private int nbCV;

        public Moteur()
            :this(false,5)
        {
            //constructeur classique
            //estDemarre = false;
            //nbCV = 5;
        }
        public Moteur(bool _estDemarre, int _nbCV)
        {
            estDemarre = _estDemarre;
            nbCV = _nbCV;
        }
        public Moteur(Moteur _moteurARecopie)
            :this(_moteurARecopie.estDemarre, _moteurARecopie.nbCV)
        {
            //par recopie classique

            //this.estDemarre = _moteurARecopie.estDemarre;
            //this.nbCV = _moteurARecopie.nbCV;
        }

        public bool Demarrer()
        {
            bool success = false;

            if (!estDemarre)
            {
                success = true;
                estDemarre = true;
            }

            return success;
        }

        public bool EntrainerRoues(Roue _roueMotrice1, Roue _roueMotrice2, Roue _roueArrDroite, Roue _roueArrGauche)
        {
            bool ok = false;
            if (estDemarre)
            {
                bool okRoue1 = _roueMotrice1.Tourner();
                bool okRoue2 = _roueMotrice2.Tourner();
                bool okRoue3 = _roueArrDroite.Tourner();
                bool okRoue4 = _roueArrGauche.Tourner();

                ok = okRoue1 && okRoue2 && okRoue3 && okRoue4;
            }
            return ok;
        }

        public bool ArreterRoues(Roue _roueMotrice1, Roue _roueMotrice2, Roue _roueArrDroite, Roue _roueArrGauche)
        {
            bool ok = false;
            if (estDemarre)
            {
                bool okRoue1 = _roueMotrice1.Arreter();
                bool okRoue2 = _roueMotrice2.Arreter();
                bool okRoue3 = _roueArrDroite.Arreter();
                bool okRoue4 = _roueArrGauche.Arreter();

                ok = okRoue1 && okRoue2 && okRoue3 && okRoue4;
            }
            return ok;
        }
    }
}