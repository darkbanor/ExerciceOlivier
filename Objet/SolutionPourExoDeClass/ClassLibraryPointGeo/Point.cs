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

        public Point(Point _point) // ?????
        {
            x = _point.x;
            
            //idem pour y
            y = _point.y;

        }

        public void Deplacer(float _nouveauX, float _nouveauY)
        {
            x = _nouveauX;
            y = _nouveauY;
        }

        public void Permuter()
        {
            float temp = x;
            x = y;
            y = temp;
        }

        public Point SymetrieAxeAbsisse()
        {
            return new Point(x, -y);
        }

        public Point SymetrieAxeOrdonnee()
        {
            return new Point(-x, y);
        }

        public Point SymetrieAxeOrigine()
        {
            return new Point(-x, -y);
            //return new Point ((this.Point SymetrieAxeAbsisse()), (this.Point SymetrieAxeOrdonnee()));
        }

        // sert a afficher les données
        public override string ToString()
        {
            return " x = " + x + " y = " + y;
        }
    }
}
