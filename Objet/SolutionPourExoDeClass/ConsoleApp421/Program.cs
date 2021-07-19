using System;
using ClassLibrary421;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp421
{
    class Program
    {
        static void Main(string[] args)
        {
            // exemple affichage caractère spéciaux
            //Console.WriteLine("Mes 60 €");
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("Mes 60 €");

            //Manche partie1 = new Manche();


            // partie1.Affiche();

            JeuxAlgo();

            //De de1 = new De();
            //De de2 = new De();
            //De de3 = new De();

            //de1.SeJeter();
            //de2.SeJeter();
            //de3.SeJeter();


            //List<De> mes3DesList = new List<De>() { de1, de2, de3 };


            //Affiche(mes3DesList);

            //Trie(mes3DesList);
            //Console.WriteLine(" *** apres trie *** ");

            //Affiche(mes3DesList);



            Console.ReadKey();
        } // end static main

        public static void Affiche(De de1, De de2, De de3)
        {
            Console.WriteLine("Valeur de Dé numéro 1 = " + de1);
            Console.WriteLine("Valeur de Dé numéro 2 = " + de2);
            Console.WriteLine("Valeur de Dé numéro 3 = " + de3);

        } //end affiche de de1 de2 de3

        //public static void Affiche(List<De> mes3DesList) //De de1, De de2, De de3
        //{

            //affiche les 3 dés dans une liste
            // int count = 1;
            //foreach (De c in mes3DesList)
            //{
            //    Console.WriteLine("Valeur dé"+count+" = " + c);
            //    count++;
            //}

        //} //end affiche

        public static void JeuxAlgo()
        {
            //variable
            De de1 = new De();
            De de2 = new De();
            De de3 = new De();
            bool sortie = false;
            int nbmanche = 0;
            int inc = 1;

            de1.SeJeter();
            de2.SeJeter();
            de3.SeJeter();

            //Trie();
            //List<De> mes3DesList = new List<De>() { de1, de2, de3 };
            //Trie(mes3DesList);

            // nombre de manche
            Console.WriteLine("Combien de Manche voulez vous (entrez un nombre) ? ");
            nbmanche = int.Parse(Console.ReadLine());
            //bool sortie1 = false;
            //Console.WriteLine();

            //tri en algo
            //int tmp;
            //if (de1 > de2) tmp = de2; de2 = de1; de1 = tmp;
            //if (de2 > de3) tmp = de3, de3 = de2, de2 = tmp;
            //if (de1 > de2) tmp = de2, de2 = de1, de1 = tmp;

            //Affiche(mes3DesList);
            Affiche(de1, de2, de3);

            //TrierLesDes(de1, de2, de3);
            //Affiche(de1, de2, de3);

            //while (sortie1 != true)

            //{


                while (sortie == false)
                {
                    Console.WriteLine("Manche " + inc);
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("Combien de Dé voulez vous re lancer (1, 2 ou 3) ? ");
                    int saisie = 0;
                    int saisie1 = 0;
                    int saisie2 = 0;
                    int saisie2a = 0;

                    saisie = int.Parse(Console.ReadLine()); // nombre de Dé a jeter

                    if (saisie == 1)
                    {
                        Console.WriteLine("Quel numéro de Dé voulez vous relancer (1, 2 ou 3) ?");

                        saisie1 = int.Parse(Console.ReadLine()); // jeter qu'un seul Dé
                        if (saisie1 == 1)
                        {
                            de1.SeJeter();
                        }
                        else if (saisie1 == 2)
                        {
                            de2.SeJeter();
                        }
                        else if (saisie1 == 3)
                        {
                            de3.SeJeter();
                        }

                    }
                    else if (saisie == 2)
                    {
                        Console.WriteLine("Quel sont les numéros des 2 Dés que voulez vous relancer (parmis 1, 2 ou 3) ?");
                        Console.WriteLine("Premier numéro ?");
                        saisie2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Deuxieme numéros ?");
                        saisie2a = int.Parse(Console.ReadLine());

                        if (saisie2 == 1)
                        {
                            de1.SeJeter();
                        }
                        else if (saisie2 == 2)
                        {
                            de2.SeJeter();
                        }
                        else if (saisie2 == 3)
                        {
                            de3.SeJeter();
                        }
                        if (saisie2a == 1)
                        {
                            de1.SeJeter();
                        }
                        else if (saisie2a == 2)
                        {
                            de2.SeJeter();
                        }
                        else if (saisie2a == 3)
                        {
                            de3.SeJeter();
                        }
                    }
                    else if (saisie == 3)
                    {
                        de1.SeJeter();
                        de2.SeJeter();
                        de3.SeJeter();
                    }


                    //condition de sortie de boucle (4 2 1)
                    //if ( mes3DesList[0].Valeur == 4 && mes3DesList[1].Valeur == 2 && mes3DesList[2].Valeur == 1)
                    //{
                    //    sortie = true;
                    //}

                    if (de1.Valeur == 4 && de2.Valeur == 2 && de3.Valeur == 1)
                    {
                        sortie = true;
                    }
                    else if (de1.Valeur == 4 && de2.Valeur == 1 && de3.Valeur == 2)
                    {
                        sortie = true;
                    }
                    else if (de1.Valeur == 2 && de2.Valeur == 1 && de3.Valeur == 4)
                    {
                        sortie = true;
                    }
                    else if (de1.Valeur == 2 && de2.Valeur == 4 && de3.Valeur == 1)
                    {
                        sortie = true;
                    }
                    else if (de1.Valeur == 1 && de2.Valeur == 4 && de3.Valeur == 2)
                    {
                        sortie = true;
                    }
                    else if (de1.Valeur == 1 && de2.Valeur == 2 && de3.Valeur == 4)
                    {
                        sortie = true;
                    }
                    else if (nbmanche >= inc)
                    {
                        Console.WriteLine("Vous avez perdu !!");
                        sortie = true;
                    }
                    

                    //Affiche(mes3DesList);
                    Affiche(de1, de2, de3);
                  
                    inc++;
                } // end while

                Console.WriteLine("Vous avez gagné !!");
                //inc++;

            // } //end for pour la manche



        } //end jeuxalgo

        public static void Trie(List<De> mes3DesList) //
        {

            mes3DesList.Sort();

            mes3DesList.Reverse();

         
        } //end tri dé
        public static List<De> TrierLesDes(De de1, De de2, De de3)
        {
         
            List<De> mes3Des = new List<De>();
            mes3Des.Add(de1);
            mes3Des.Add(de2);
            mes3Des.Add(de3);

            bool trie = false;
            De tmp=null;


            while (!trie)
            {
                for (int i = 0; i < mes3Des.Count - 1; i++)
                {
                    //tri en algo
                   
                    if (de1.Valeur > de2.Valeur) tmp = de2; de2 = de1; de1 = tmp;
                    if (de2.Valeur > de3.Valeur) tmp = de3; de3 = de2; de2 = tmp;
                    if (de1.Valeur > de2.Valeur) tmp = de2; de2 = de1; de1 = tmp;

                    //if (de1.Valeur < de2.Valeur)
                    //{
                    //    De temp = mes3Des[i];
                    //    mes3Des[i] = mes3Des[i + 1];
                    //    mes3Des[i + 1] = temp;
                   trie = true;
                    //}
                }
            }

            return mes3Des;



        }





    }
}
