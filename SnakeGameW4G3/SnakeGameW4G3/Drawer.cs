using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGameW4G3
{
    public class Drawer
    {
        public ConsoleColor color;
        public char sign;
        public List<Point> body = new List<Point>();

        public Drawer() { }

        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach(Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }

    }
}
