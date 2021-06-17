using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoiture
{
    public class Voiture
    {
        private int compteurEnKm;
        private Moteur monMoteur;
        private List<Roue> mesRoues;

        public Voiture()
            :this(0, new List<Roue>() {new Roue(), new Roue(), new Roue(), new Roue() }, new Moteur())
        {

        }

        private Voiture(int compteurEnKm, List<Roue> mesRoues, Moteur monMoteur)
        {
            this.compteurEnKm = compteurEnKm;
            this.monMoteur = monMoteur;
            this.mesRoues = mesRoues;
        }
        
        public Voiture (int compteurEnKm, bool tourne, int diametre, bool estDemarre, int nbCV) // contructeur defaut
        :this(compteurEnKm,
             new List<Roue>() {new Roue (tourne, diametre), new Roue(tourne, diametre), 
             new Roue(tourne, diametre), new Roue(tourne, diametre) }, new Moteur(estDemarre, nbCV))
        {


            //pour les roues
            //this.mesRoues = new List<Roue>();
            //this.mesRoues.Add(new Roue(_voitureARecopier.mesRoues[0]));
            //this.mesRoues.Add(new Roue(_voitureARecopier.mesRoues[1]));
            //this.mesRoues.Add(new Roue(_voitureARecopier.mesRoues[2]));
            //this.mesRoues.Add(new Roue(_voitureARecopier.mesRoues[3]));

            //pour monMonteur
            //this.monMoteur = new Moteur(estDemarre, nbCV);

        }

        public bool Avancer()
        {
            return monMoteur.EntrainerRoues(mesRoues[0], mesRoues[1], mesRoues[2], mesRoues[3]);
        }

        public Voiture(Voiture _voitureARecopier)
        {
            //pour le compteur
            this.compteurEnKm = _voitureARecopier.compteurEnKm;
            
            // faux car même roue partout
            //this.mesRoues = _voitureARecopier.mesRoues:

            //pour les roues
            this.mesRoues = new List<Roue>();
            this.mesRoues.Add(new Roue(_voitureARecopier.mesRoues[0]));
            this.mesRoues.Add(new Roue(_voitureARecopier.mesRoues[1]));
            this.mesRoues.Add(new Roue(_voitureARecopier.mesRoues[2]));
            this.mesRoues.Add(new Roue(_voitureARecopier.mesRoues[3]));

            //pour monMonteur
            this.monMoteur = new Moteur(_voitureARecopier.monMoteur);

        }

        public bool Arreter()
        {
            return monMoteur.ArreterRoues(mesRoues[0], mesRoues[1], mesRoues[2], mesRoues[3]);
        }        

        public bool Demarrer()
        {
            return monMoteur.Demarrer();
        }
    }
}
