using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPointGeo
{
    public class Point
    {
        private float x;
        private float y;

        public Point() //constructeur par defaut
        {
            x = 0;
            y = 0;
        }

        public Point(float _absisseX, float _ordonneeY)
        {
            x = _absisseX;
            y = _ordonneeY;
        }

        public Point(Point _point)
        {
            throw new System.NotImplementedException();
        }
        public void Deplacer(float _nouveauX, float _nouveauY)
        {
            x = _nouveauX;
            y = _nouveauY;
        }

        public void Permuter()
        {
            if (y > 0 && x > 0) //bissectile y0 et x0
            {
                float temp = x;
                x = y;
                y = temp;
            }
            
        }

        public void SymetrieAxeAbsisse()
        {
            y = -y;
        }

        public void SymetrieAxeOrdonnee()
        {
            x = -x;
        }

        public void SymetrieAxeOrigine()
        {
            y = -y;
            x = -x;
        }

        // sert a afficher les données
        public override string ToString()
        {
            return " x = " + x + " y = " + y;
        }
    }
}
