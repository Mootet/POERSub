using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE._1
{
    [Serializable]
    class Mage : Enemey
    {
        private int rndX;
        private int rndY;

        
           
        

        public Mage(int x_coordinate, int y_coordinate) : base(x_coordinate, y_coordinate, 5 , " M", 5)
        {
            this.HP = 5;
            this.rndX = x_coordinate;
            this.rndY = y_coordinate;
            this.gold = 3;
        }
       
        public override Movement Returnmove(Movement move = 0)
        {
            throw new NotImplementedException();
        }

        public override bool CheckRange(Charchter target)
        {
            return base.CheckRange(target);
        }
        public override string ToString()
        {
            return "barehanded: Mage at [" + X_coordinate + "," + Y_coordinate + "]" + "HP:" + this.HP+ "(5 DMG)";
        }
    }
}
