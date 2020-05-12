using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C2_Dungeon
{
    class Heros
    {

        string m_sName;

        public Heros()
        {
            userInterface.displayInfo(Program.debug, "On est dans le constructeur par defaut de  heros");
        }

        public Heros(string p_sName)
        {
            m_sName = p_sName;
            userInterface.displayInfo(Program.debug, "On est dans le constructeur avec arguments de heros : ", m_sName);
        }

    }
}
