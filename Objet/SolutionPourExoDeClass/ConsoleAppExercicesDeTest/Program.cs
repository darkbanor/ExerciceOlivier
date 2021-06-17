using ClassLibraryExercicesDeTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercicesDeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Chat yoda = new Chat();
            yoda.Miauler();
            yoda.Manger();
            

            RobotAspirateur monRobot = new RobotAspirateur();
            monRobot.Nettoyer();

            SuperRobot henry = new SuperRobot();
            henry.Bouger();
            henry.Aboyer();
            henry.JoueAuxJeux();

            



            Console.ReadKey();
        }
    }
}
