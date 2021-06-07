using System;

namespace ClassLibraryBouteille
{
    public class Bouteille
    {
        //attribut = field (champs)
        private double contenanceEnLitre;
        private double contenuEnPourcentage;
        private bool ouvert;

        public bool Ouvert { get => ouvert;/* set => ouvert = value;*/ }


        //constructeur
        public Bouteille() // contructeur defaut
        {
            contenanceEnLitre = 1.5;
            contenuEnPourcentage = 100;
            ouvert = false;
        }

        public Bouteille(double _contenanceEnLitre, int _contenuEnPourcentage, bool _ouvert)
        {
            contenanceEnLitre = _contenanceEnLitre;
            contenuEnPourcentage = _contenuEnPourcentage;
            ouvert = _ouvert;
        }

        public bool Ouvrir()
        {
            bool resultat;

            if (ouvert == true)
            {
                resultat = false;
            }
            else
            {
                ouvert = true;
                resultat = true;
            }

            return resultat;
        }

        public bool Fermer()
        {
            bool resultat;

            if (ouvert == true)
            {
                ouvert = false;
                resultat = true;
            }
            else
            {
                resultat = false;
            }

            return resultat;
        }

        public double ViderTout()
        {
            if (ouvert == true)
            {
                contenanceEnLitre = 0;                
            }
            else
            {
                throw new Exception("Impossible vider car bouteille est ferme");
            }

            return contenanceEnLitre;
            
        }

        public double OterEnPourcentage()
        {
            if (ouvert == true)
            {
                contenuEnPourcentage = contenuEnPourcentage - 100;
            }
            else
            {
                throw new Exception("Impossible vider car bouteille est ferme");
            }

            return contenuEnPourcentage;

        }

        public double AOterEnLitre ()
        {
            double resteEnLitreAVider;
            double pourcentage;            

            if (ouvert == true)
            {
                pourcentage = (contenuEnPourcentage * contenanceEnLitre) / 100 ;
                resteEnLitreAVider = contenanceEnLitre - pourcentage ;
                contenanceEnLitre = Math.Round(resteEnLitreAVider,3);
            }
            else
            {
                throw new Exception("Impossible vider car bouteille ferme");
            }

            return contenanceEnLitre;
        }



        public override string ToString() // pour tester
        {
            return "Contenance en litre = " + contenanceEnLitre + " Contenu en % = " + contenuEnPourcentage
                + " Etat du bouchon = " + ouvert;
        }

        
        
    }
}
