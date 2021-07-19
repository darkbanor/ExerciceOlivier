using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary421
{
    public class Manche
    {
        private List<De> mes3Des;
        private const int NB_MAX_LANCER = 3;
        private int nbLancer_Courant;

        public Manche()
        {
            this.nbLancer_Courant = 1;
            //instanciation des dés
            De de1 = new De();
            De de2 = new De();
            De de3 = new De();

            //initialiser la valeur des Dés
            de1.SeJeter();

            Mes3Des();
           
        }
        

        public void LancerLes3Des()
        {
            //nbLancer_Courant++;
            Console.WriteLine(" à écrire");

            ////initialiser la valeur des Dés
            //this.de1.SeJeter();
            //de2.SeJeter();
            //de3.SeJeter();
        }

        public void Mes3Des()
        {           

            //les triés
            mes3Des.Sort();
            mes3Des.Reverse();
        }

        public void Lancer()
        {
            throw new System.NotImplementedException();
        }

        public bool AEncoreUnLancer()
        {
            throw new System.NotImplementedException();
        }

        public bool AGagnerLaManche()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            string mot = " à écrire";
            return mot;
            //foreach (De c in mes3Des)
            //{
            //    Console.WriteLine("Valeur dé =" + c);
            //}

            //return mes3Des;
        }
        public void Affiche()
        {
            foreach (De c in mes3Des)
            {
                Console.WriteLine("Valeur dé =" + c);
            }

        }

    }
}