using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POE._1
{
    [Serializable]
    abstract class Charchter : Tile
    {
        private Map map;
        private weapon weapon;
        protected int gold;
        protected string symbol;
        protected int hP;
        protected int maxHP;
        protected int damage;
        protected Tile[,] Vision;
        protected int range;
        public enum Movement
        {
            No_Movement, Up, Down, Left, Right
        }

        public bool isdead = false;

        public int HP { get => hP; set => hP = value; }
        public string Symbol { get => symbol; set => symbol = value; }
        public int MaxHP { get => maxHP; set => maxHP = value; }
        public int Damage { get => damage; set => damage = value; }
        public Map Map { get => map; set => map = value; }
        public int Gold { get => gold; set => gold = value; }
        protected weapon Weapon { get => weapon; set => weapon = value; }

        public Charchter(int x_coordinate, int y_coordinate, int damage) : base(x_coordinate, y_coordinate)
        {
            X_coordinate = x_coordinate;
            Y_coordinate = y_coordinate;

            Damage = damage;
        } 
       
        public void pickup(Item i)
        {

        }
        public virtual void Attack(Charchter target)
        {
            if(target != null)
            {
                if (target.HP <= 0)
                {

                }
                else
                {
                    target.HP -= this.Damage;
                }
            }
        }
     
      
       
        public void Move(Movement move)
        {
            
            switch (move)
            {
                case Movement.Up:
                        this.X_coordinate--;
                    break;
                case Movement.Down:
                    this.X_coordinate++;
                    break;
                case Movement.Left:
                    this.Y_coordinate--;
                    break;
                case Movement.Right:
                    this.Y_coordinate++;
                    break;
                case Movement.No_Movement:
                    break;
            }

        }
        private int DistanceTo(Charchter target)
        {
            int spaces = 0;


            return spaces;
        }
        public virtual bool CheckRange(Charchter target)
        {
            if (DistanceTo(target) <= range)
            {
                return true;
            }
            else
            {
                return false;

            }

        }

        public void loot(Charchter target)
        {
            this.gold += target.gold;
        }

        public abstract Movement Returnmove(Movement move = 0);
      
        public abstract override string ToString();

    }
}
