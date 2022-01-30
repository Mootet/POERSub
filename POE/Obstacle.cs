using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE._1
{
    [Serializable]
    class Obstacle : Tile
    {
        private string Symbol;

        public string symbol { get; set; }

        public Obstacle(int x_coordinate, int y_coordinate) : base(x_coordinate, y_coordinate)
        {

        }

        public override string ToString()
        {
            return " * ";
        }
    }

}
