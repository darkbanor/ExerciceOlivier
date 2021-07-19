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

        public Compte[] MesComptes
        {
            get => mesComptes;

        }

        public Banque(string _nom, string _ville) // constructeur
        {
            mesComptes = new Compte[200];
            nbComptes = 0;
            nom = _nom;
            ville = _ville;
        }

        public Banque() // constructeur par defaut
        {
            mesComptes = new Compte[200];
            nbComptes = 0;
            nom = "";
            ville = "";
        }

        public void AjouterCompte(Compte unCompte)
        {
            mesComptes[nbComptes] = unCompte;
            nbComptes++;
        }

        public void AjouterCompte(int _num, string _nom, int _solde, int _decouvertAutoriser)
        {
            Compte unCompte = new Compte(_num, _nom, _solde, _decouvertAutoriser);
            mesComptes[nbComptes] = unCompte;
            nbComptes++;
        }

        public Compte CompteSup()
        {
            
            List<Compte> mescomptesList = new List<Compte>();

            foreach (Compte c in mesComptes)
            {
                if (c != null)
                {
                    mescomptesList.Add(c);
                }
            }
            
            if (mesComptes != null)
            {                
               mescomptesList.Sort();
               mescomptesList.Reverse();

                if (mescomptesList.Count != 0)
                {

                    return mescomptesList[0];
                }
                else
                {
                    return null;
                }
                
            }
            else
            {
               throw new IndexOutOfRangeException("..fin des champs remplis.. "); 
            }

        }
        public bool Transferer(int _compteSource, int _compteDestination, int _montantTransfert)
        {
            bool ok = false;

            Compte CpmSource=RendCompte(_compteSource);
            Compte CpmDestination=RendCompte(_compteDestination);

            //on regarde si le compte courant peut etre debiter
            if (CpmSource.Debiter(_montantTransfert))
            {
                //si on peut debiter on credite le nouveau compte                 
                CpmDestination.Crediter(_montantTransfert);

                ok = true;

            }

            return ok;

        }
        public Compte RendCompte(int num)
        {
            int i = 0;
            while (i < nbComptes && num != mesComptes[i].NumCompte)
            {
                i++;
               
            }

            if (i==nbComptes)
            {
                return null;
                
            }
            else
            {
                return mesComptes[i];
            }
                

        }


        public override string ToString()
        {
            string affichecompte = "";

            for (int i = 0; i <= nbComptes; i++)
            {
                affichecompte += this.mesComptes[i];
            }

            return "Nom de la Banque = " + nom + ", ville = " + ville + ", nombre de compte = " + nbComptes + "\n" + affichecompte;

        }

    }
}