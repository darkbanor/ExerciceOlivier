using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoiture
{
    public class Voiture
    {
        private decimal compteurEnKm;
        private Moteur moteur;
        private Dictionary<string, Roue> mesRoues = new Dictionary<string, Roue>();
        
        public Voiture (decimal _compteurEnKm, Moteur _moteur) // contructeur defaut
        {
            compteurEnKm = _compteurEnKm;
            moteur = _moteur;
            mesRoues.Add("roueMotriceAvtGauche", new Roue());
            mesRoues.Add("roueMotriceAvtDroit", new Roue());
            mesRoues.Add("roueArrGauche", new Roue());
            mesRoues.Add("roueArrDroit", new Roue());

        }

        public void Arreter()
        {
            throw new System.NotImplementedException();
        }

        public void Avancer()
        {
            throw new System.NotImplementedException();
        }

        public void Demarrer()
        {
            throw new System.NotImplementedException();
        }
    }
}
