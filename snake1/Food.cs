using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeII
{
    public class Food : GameObject
    {
        public Food()
        {
            this.sign = '$';
            this.points.Add(new Point(new Random().Next() % 30, new Random().Next() % 30));
    }
    }
}