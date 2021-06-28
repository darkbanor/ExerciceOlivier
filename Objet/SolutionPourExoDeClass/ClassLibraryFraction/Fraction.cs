using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFraction
{
    public class Fraction:IComparable
    {
        private int numerateur;
        private int denominateur;

        public Fraction() //constructeur par defaut
        {
            numerateur = 0;
            denominateur = 1;
        }

        public Fraction(Fraction _fraction) //constructeur par clonage
        {
            numerateur = _fraction.numerateur;
            denominateur = _fraction.denominateur;
        }

        public Fraction(int _numérateur, int _denominateur) //constructeur par defaut
        {
            numerateur = _numérateur;
            denominateur = _denominateur;
        }

        public Fraction(int _numérateur) //constructeur pour null
        {
            numerateur = _numérateur;
            denominateur = 1;
        }

        public decimal Resultat()
        {
            decimal a = this.numerateur;
            decimal b = this.denominateur;
            decimal resultat = Math.Round((a/b), 2);
            return resultat;
        }
        public bool SuperieurA(Fraction _autreFraction)
        {
            bool resultat = false;

            decimal z = this.Resultat();
            decimal y = _autreFraction.Resultat();

            if (z>y)
            {
                resultat = true;
            }

            return resultat;
            
        }
        public bool EgalA(Fraction _autreFraction)
        {
            bool resultat = false;
            
            if (this.Resultat().CompareTo(_autreFraction.Resultat()) == 0)
            {
                resultat = true;
            }

            return resultat;
        }

        public void Oppose()
        {
            this.numerateur = -numerateur;
            this.denominateur = Math.Abs(denominateur);
            
        }
        // cette méthode enlève les signes --
        //public Fraction Oppose()
        //{
        //    return new Fraction((-numerateur), denominateur);
        //}

        public void Inverse()
        {
            int temp = numerateur;
            numerateur = denominateur;
            denominateur = temp;
        }

        public override string ToString()
        {
            string frac="";

            if (denominateur == 1)
            {
                frac = numerateur+"";
            }
            else
            {
                frac = numerateur + "/" + denominateur;
            }
            

            return frac;
        }

        private void Reduire()
        {
            int y = 2;
            this.GetPgcd();
        }

        private int GetPgcd()
        {
            int a = this.numerateur;
            int b = this.denominateur;
            int pgcd = 1;
            if (a != 0 && b != 0)
            {
                if (a < 0) a = -a;
                if (b < 0) b = -b;
                while (a != b)
                {
                    if (a < b)
                    {
                        b = b - a;
                    }
                    else
                    {
                        a = a - b;
                    }
                }
                pgcd = a;
            }
            return pgcd;
        }

        public int CompareTo(object obj)
        {
            Fraction _autreFraction = obj as Fraction;

            //if (this.Resultat() > _autreFraction.Resultat())
            //{
            //    return -1;
            //}
            //else if (this.Resultat() < _autreFraction.Resultat())
            //{
            //    return 1;
            //}
            //else
            //{
            //    return 0;
            //}


            //autre comparaison
            if (_autreFraction == null)
            {
                throw new ArgumentException("Obj n'est pas du type Resultat");
            }

            return this.Resultat().CompareTo(_autreFraction.Resultat());
        }
    }

}

