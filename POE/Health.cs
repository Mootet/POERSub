using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE._1
{
    [Serializable]
    class Health : Item
    {
        Random random = new Random();
        public int hprec;
        public Health(int X_coordinate, int Y_coordinate) : base(X_coordinate, Y_coordinate)
        {
            hprec = random.Next(2, 10);

        }

        public override string ToString()
        {
            return "+";
        }
    }
}
