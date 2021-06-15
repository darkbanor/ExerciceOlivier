using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryVoiture
{
    public class Moteur
    {
        private bool demarre;
        private Voiture saVoiture;

        public Moteur(bool _demarre)
        {
            demarre = _demarre;            
        }

        public void Arreter()
        {
            throw new System.NotImplementedException();
        }

        public void Demarrer()
        {
            throw new System.NotImplementedException();
        }

        public void FaireTourner()
        {
            throw new System.NotImplementedException();
        }
    }
}