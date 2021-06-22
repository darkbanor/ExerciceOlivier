using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCompteBancaire
{
    public class Compte
    {
        private int decouvertAutorise;
        private string nom;
        private int numero;
        private int solde;

        public Compte() //constructeur par defaut
        {
            //pour exo le constructeur = zero (=commenté)
            //decouvertAutorise = -150;
            //nom = "Olivier";
            //numero = 123456;
            //solde = 1000;
        }

        public Compte(string _nom, int _numero, int _solde, int _decouvertAutorise)
        {
            nom = _nom;
            numero = _numero;
            solde = _solde;
            decouvertAutorise = _decouvertAutorise;
        }

        public void Crediter(int _montant)
        {
            solde += _montant; // rajoute un montant au solde
        }

        public bool Debiter(int _montant)
        {
            bool ok = false;
            int nouveauSolde = solde - _montant;

            //on debite seulement dans les limites de l'autorisation de decouvert
            if (nouveauSolde >= decouvertAutorise)  
            {
                solde -= _montant;
                ok = true;
            }

            return ok;
            
        }

        public bool Superieur(Compte _autreCompte)
        {
            bool ok = false;

            //compare si le solde courant est superieur au nouveau solde 
            if (this.solde > _autreCompte.solde)               
            {
                ok = true;
            }

            return ok;
        }

        public bool Transferer(int _montantTransfert, Compte _compteDestination)
        {
            bool ok = false;

            //on regarde si le compte courant peut etre debiter
            if (this.Debiter(_montantTransfert)) 
            {
                //si on peut debiter on credite le nouveau compte                 
                _compteDestination.Crediter(_montantTransfert);
                ok = true;

            }

            return ok;

        }

        // sert a afficher les données
        public override string ToString()
        {
            return " nom = " + nom + " numero de compte = "+ numero  +
                " solde = " + solde + " Decouvert Autorise = " + decouvertAutorise;
        }

        
    }
}

