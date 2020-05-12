 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Dungeon
{



    class Program
    {

        public const int nbRoom = 5;
        public const int nbWeapon = 10;
        public const bool debug = false; 

        static void Main(string[] args)
        {
            userInterface.displayInfo(false, "Bienvenue au donjon Webstart");

            Heros myHeros = new Heros("ariel");
            Dungeon dungeon = new Dungeon();

            Console.ReadLine();

        }
    }
}
