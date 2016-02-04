using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGameW4G3
{
    public class Food : Drawer
    {
        public Food()
        {
            color = ConsoleColor.Yellow;
            sign = '$';
        }

        public void SetNewPosition()
        {
            int x = new Random().Next() % 20;
            int y = new Random().Next() % 20;
            if (body.Count == 0)
                body.Add(new Point(x, y));
            else
            {
                body[0].x = x;
                body[0].y = y;
            }
        }

    }
}
