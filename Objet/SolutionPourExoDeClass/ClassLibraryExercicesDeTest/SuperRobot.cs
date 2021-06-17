using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExercicesDeTest
{
    public class SuperRobot
    {       
        private Robot unRobot;
        private Chien unChien;
        private RobotAspirateur unRobotAspirateur;
        private Chat unChat;

        public SuperRobot()
        {
            unRobot = new Robot();
            unChien = new Chien();
            unRobotAspirateur = new RobotAspirateur();
            unChat = new Chat();
        }

        public void Bouger()
        {
            unRobot.Bouge();
        }
        public void Aboyer()
        {
            unChien.Aboyer();
        }
        public void NettoyerSR()
        {
            unRobotAspirateur.Nettoyer();
        }
        public void Miauler()
        {
            unChat.Miauler();
            unChat.Manger();
        }
        public void JoueAuxJeux ()
        {
            Console.WriteLine("Je suis en train de jouer aux Jeux !");

        }
    }
}
