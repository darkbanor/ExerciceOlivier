using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary421
{
    public class De:IComparable<De>
    {
        private const int NB_FACE=6;
        private int valeur;

        public De()
        {
            valeur = Alea.Instance().Nouveau(1, NB_FACE+1);
        }

        public int Valeur
        {
            get => valeur;

        }

        public int CompareTo(De other)
        {
            return this.valeur.CompareTo(other.valeur);
        }

        public void SeJeter()
        {
            valeur = Alea.Instance().Nouveau(1, NB_FACE);
        }
        public override string ToString()
        {
            return Valeur.ToString();
        }

    }
}
