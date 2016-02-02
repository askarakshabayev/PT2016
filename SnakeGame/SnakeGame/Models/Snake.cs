using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Models
{
    class Snake : Drawer
    {
        public Snake()
        {
            color = ConsoleColor.Yellow;
            sign = 'o';
        }
        public void Move(int dx, int dy)
        {
            for (int i = body.Count - 1; i >= 1; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            body[0].x += dx;
            body[0].y += dy;
        }
    }
}
