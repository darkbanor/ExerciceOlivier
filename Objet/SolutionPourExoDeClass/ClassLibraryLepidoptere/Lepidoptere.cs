using ClassLibraryLepidoptere.Evolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere
{
    public class Lepidoptere 
    {
        //attribut = field (champs)
        string nom;
        StadeDEvolution stadeCourant;

        //constructeur
        public Lepidoptere(string _nom) // contructeur defaut
        {
            nom = _nom;
            stadeCourant = new Oeuf();
        }

        public void SeDeplacer()
        {
            stadeCourant.SeDeplacer();
        }

        public void SeTransformerObjet()
        {
            stadeCourant = stadeCourant.DonnerProchainStade(); 
        }

        //public void SeTransformerAlgo()
        //{
        //    if (stadeCourant is Oeuf)
        //    {
        //        stadeCourant = new Chenille();
        //    }
        //    else if (stadeCourant is Chenille)
        //    {
        //        stadeCourant = new Chrysalide();
        //    }
        //}

       
        public override string ToString() // pour tester
        {
            return "Nom = " + nom + " Son stade courant = " + stadeCourant;
        }


    }
}
