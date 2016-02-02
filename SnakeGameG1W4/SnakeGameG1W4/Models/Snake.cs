using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGameG1W4.Models
{
    public class Snake : Drawer
    {
        public Snake()
        {
            color = ConsoleColor.Green;
            sign = 'o';
        }

        public void move(int dx ,int dy)
        {
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            body[0].x += dx;
            body[0].y += dy;

            // checking eating food
            if (body[0].x == Game.food.body[0].x && 
                body[0].y == Game.food.body[0].y)
            {
                Game.food.NewRandomPosition();
                body.Add(new Point(0, 0));
            }

            for (int i = 0; i < Game.wall.body.Count - 1; i++)
            {
                if (body[0].x == Game.wall.body[i].x && 
                    body[0].y == Game.wall.body[i].y)
                {
                    Game.GameOver = true;
                }
            }
        }
    }
}
