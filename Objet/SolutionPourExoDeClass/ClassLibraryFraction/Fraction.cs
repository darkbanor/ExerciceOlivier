using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFraction
{
    public class Fraction : IComparable
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
            if (denominateur == 0)
            {
                throw new ArithmeticException("Le denominateur de la fraction ne peut pas être égal à zéro");
            }
            numerateur = _numérateur;
            denominateur = _denominateur;
        }

        public Fraction(int _numérateur) //constructeur pour null
        {
            numerateur = _numérateur;
            denominateur = 1;
        }

        public float GetValue()
        {
            float a = this.numerateur;
            float b = this.denominateur;
            float resultat = (float)Math.Round((a / b), 2);
            return resultat;
        }
        public bool SuperieurA(Fraction _autreFraction)
        {
            bool resultat = false;

            float z = this.GetValue();
            float y = _autreFraction.GetValue();

            if (z > y)
            {
                resultat = true;
            }

            return resultat;

        }
        public bool EgalA(Fraction _autreFraction)
        {
            bool resultat = false;

            if (this.GetValue().CompareTo(_autreFraction.GetValue()) == 0)
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

        public Fraction Plus(Fraction _autreFraction)
        {
            int numerateur1 = (numerateur * _autreFraction.denominateur) + (denominateur * _autreFraction.numerateur);
            int denominateur1 = denominateur * _autreFraction.denominateur;
            Fraction f = new Fraction(numerateur1, denominateur1);
            f.Reduire();
            f.invSigneDenominateur(); // pour inverser le signe
            return f;
        }

        //argumet et signature -- surcharge
        public Fraction FPlus(Fraction _f1, Fraction _f2)
        {
            int numerateur1 = ((_f1.numerateur * _f2.denominateur) +
                (_f1.denominateur * _f2.numerateur));
            int denominateur1 = _f1.denominateur * _f2.denominateur;
            
            Fraction f = new Fraction(numerateur1, denominateur1);

            f.Reduire();
            f.invSigneDenominateur(); // pour inverser le signe
            return f;
        }

        public Fraction Moins(Fraction _autreFraction)
        {
            int numerateur1 = (numerateur * _autreFraction.denominateur) - (denominateur * _autreFraction.numerateur);
            int denominateur1 = denominateur * _autreFraction.denominateur;
            Fraction g = new Fraction(numerateur1, denominateur1);
            g.Reduire();
            g.invSigneDenominateur(); // pour inverser le signe
            return g;

        }
        public Fraction Multiplie(Fraction _autreFraction)
        {
            int numerateur1 = (numerateur * _autreFraction.numerateur);
            int denominateur2 = denominateur * _autreFraction.denominateur;
            Fraction f = new Fraction(numerateur1, denominateur2);
            f.Reduire();
            f.invSigneDenominateur(); // pour inverser le signe
            return f;

        }

        public Fraction Divise(Fraction _autreFraction)
        {
            int numerateur1 = (numerateur * _autreFraction.denominateur);
            int denominateur2 = denominateur * _autreFraction.numerateur;
            Fraction f = new Fraction(numerateur1, denominateur2);
            f.Reduire();
            f.invSigneDenominateur(); // pour inverser le signe
            return f;

        }
        public override string ToString()
        {
            string frac = "";

            if (denominateur == 1)
            {
                frac = numerateur + "";
            }
            else
            {
                frac = numerateur + "/" + denominateur;
            }


            return frac;
        }

 /*       public void Reduire() // autre methode de réduction (algo)
        {
            int a;
            int b;

            if (this.numerateur > this.denominateur)
            {
                a = this.numerateur;
                b = this.denominateur;
            }
            else
            {
                a = this.denominateur;
                b = this.numerateur;
            }

            int rest;
            while ((rest = a % b) != 0)
            {
                a = b;
                b = rest;
            }

            this.numerateur /=b;
            this.denominateur /= b;





       } */


        private void Reduire()
        {
            int pgcd = GetPgcd(); //3/9 pgcd=3
            this.numerateur = this.numerateur / pgcd;
            this.denominateur = this.denominateur / pgcd;

        }

        private int invSigneDenominateur()
        {
            if (this.denominateur < 0)
            {
                this.denominateur = this.denominateur * (- 1);
                this.numerateur = this.numerateur * (-1);
            }
            else if (this.denominateur <0 && this.numerateur < 0)
            {
                this.denominateur = this.denominateur * (-1);
                this.numerateur = this.numerateur * (-1);
            }

            return denominateur;
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

            return this.GetValue().CompareTo(_autreFraction.GetValue());
        }
    }

}

