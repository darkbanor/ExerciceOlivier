using System;

namespace ClassLibraryBouteille
{
    public class Bouteille
    {
        //attribut = field (champs)
        private double contenanceEnLitre;
        private int contenuEnPourcentage;
        private bool ouvert;
        private bool fermer;
        private double remplir;

        //constructeur
        public Bouteille ()// contructeur defaut
        {
            ouvert = false;
            fermer = true;
            contenanceEnLitre = 1.5;
            contenuEnPourcentage = 80;
        }

        public Bouteille (bool _ouvert, double _contenanceEnLitre, int _contenuEnPourcentage, double _remplir) // contructeur defaut
        {
            ouvert = _ouvert;
            remplir = _remplir;
            contenanceEnLitre = _contenanceEnLitre;
            contenuEnPourcentage = _contenuEnPourcentage;
        }

        //methode en c#

        public void Ouvert ()
        {
            ouvert = false;
        }

        public void Fermer()
        {
            fermer = true;
        }

        public void Remplir(int _arajouterEnPourcentage, double _contenanceEnLitre, int _contenuPourcentage)
        {
            if (ouvert == true)
            {
                remplir = (((_contenanceEnLitre * _contenuPourcentage / 100) - _contenanceEnLitre));
                _arajouterEnPourcentage = contenuEnPourcentage - _contenuPourcentage;

            }

            if (ouvert == false)
            {
                Console.WriteLine("impossible de remplir");

            }

        }

        public override string ToString()
        {
            return "ouvert = "+ ouvert + " fermer = " +fermer+ " remplir" + remplir;
        }
    }
}
