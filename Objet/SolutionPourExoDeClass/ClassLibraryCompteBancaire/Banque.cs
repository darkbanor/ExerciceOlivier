using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryCompteBancaire
{
    public class Banque
    {
        private Compte[] mesComptes;
        private int nbComptes;
        private string nom;
        private string ville;

        private Banque(string _nom, string _ville) // constructeur
        {
            nbComptes++;
            nom = _nom;
            ville = _ville;
            Compte[] mesComptes = new Compte[] {};
        }

        public Banque() // constructeur par defaut
        {
            Compte[] mesComptes = new Compte[] { };
            nbComptes = 0;
            nom = "";
            ville = "";
        }

        private void AjouteCompte(Compte unCompte)
        {
        }

        public void AjouterCompte(string _nom, int _num, int _solde, int _decouvertAutoriser)
        {
            Compte unCompte = new Compte(_nom, _num, _solde, _decouvertAutoriser);
          
        }

        public override string ToString()
        {
            return " nom = " + nom + " nombre de compte = " + nbComptes +
                " ville = " + ville;
            //for mesComptes
        }

    }
}