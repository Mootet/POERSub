using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POE._1
{
    [Serializable]
    class GameEngine
    {
        private Map map;
        
        public GameEngine(Map Map)
        {
            this.map = Map ;
            
        }


        public bool MovePlayer(Charchter.Movement move)
        {
            if(move == 0)
            {

            }
            return true;
        }
    }
}
