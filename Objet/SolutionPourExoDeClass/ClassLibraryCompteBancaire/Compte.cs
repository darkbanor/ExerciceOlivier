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
            //decouvertAutorise = -150;
            //nom = "Olivier";
            //numero = 123456;
            //solde = 1000;
        }       
        
        public int Solde
        { get => solde; }

        public Compte(string _nom, int _numero, int _solde, int _decouvertAutorise)
        {
            nom = _nom;
            numero = _numero;
            solde = _solde;
            decouvertAutorise = _decouvertAutorise;
        }
        public void Crediter(int _montant)
        {
            solde += _montant;
        }

        public bool Debiter(int _montant)
        {
            bool ok = false;
            int nouveauSolde = solde - _montant;

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

            if (this.solde > -_autreCompte.solde)                
                {
                   
                }

            return ok;
        }

        public override string ToString()
        {
            return " nom = " + nom + " numero de compte = "+ numero  +
                " solde = " + solde + " Decouvert Autorise = " + decouvertAutorise;
        }

        public bool Transferer(int _montantTransfert, Compte _compteDestination)
        {
            bool ok = false;

            if (this.Debiter(_montantTransfert))
            {
                //compte à crediter                 
                _compteDestination.Crediter(_montantTransfert);
                ok = true;

            }

            return ok;            

        }
    }
}

