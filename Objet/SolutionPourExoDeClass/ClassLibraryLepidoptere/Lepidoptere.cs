using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere
{
    class Lepidoptere 
    {
        //attribut = field (champs)
        private string nom;
        private string sonStadeCourant;

        //constructeur
        public Lepidoptere() // contructeur defaut
        {
            nom = "PapillonVert";
            sonStadeCourant = "oeuf";
        }

        public Lepidoptere(string _nom, string _sonStadeCourant)
        {
            nom = _nom;
            sonStadeCourant = _sonStadeCourant;
        }

        public void SeDeplacer()
        {
            return;
        }

        public void SeTransformer()
        {
            
            string[] evolution = { "oeuf", "chenille", "chrysalide", "papillon" };

            string temp = "papillon";


            for (int i = 0; i < evolution.Length; i++)
            {
                Console.WriteLine("tableau = " + evolution[i]);

                if (sonStadeCourant == evolution[i] && sonStadeCourant != "papillon")
                {
                    //Console.WriteLine("dans boucle stade courant = " + evolution[i]);
                    temp = evolution[i + 1];
                }


            }
            sonStadeCourant = temp;

        }

        //public void SeDeplacer()
        //{
        //    string deplacement = sonStadeCourant;

        //    if (deplacement == "oeuf")
        //    {
        //        Console.WriteLine("je ne sais pas me deplacer tout seul");

        //    }
        //    else if (deplacement == "chenille")
        //    {
        //        Console.WriteLine("je rampe");

        //    }
        //    else if (deplacement == "chrysalide")
        //    {
        //        Console.WriteLine("je ne sais pas me deplacer tout seul");

        //    }
        //    else if (deplacement == "papillon")
        //    {
        //        Console.WriteLine("je vole");

        //    }
        //    return deplacement;

        //}

        


    }
}
