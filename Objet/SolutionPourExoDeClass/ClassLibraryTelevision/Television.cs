using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTelevision
{
    public class Television
    {
        //attribut = field (champs)
        private bool allume;
        private int diagonal;

        //constructeur
        public Television() // contructeur defaut
        {
            allume = false;
            diagonal = 17;
        }

        public Television(bool _allume, int _diagonal) // contructeur defaut
        {
            allume = _allume;
            diagonal = _diagonal;
        }

        //methode en c#

        public void Allume()
        {
            allume = true;
        }

        public void Eteindre()
        {
            allume = false;
        }

        public override string ToString()
        {
            return  "allummer= "+ allume+ " diagonal= " +diagonal;
        }

    }
}
