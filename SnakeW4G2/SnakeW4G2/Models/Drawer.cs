using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeW4G2.Models
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

        public void Save()
        {
            string fileName = "snake.xml";
            if (sign == '#')
                fileName = "wall.xml";
            if (sign == '$')
                fileName = "food.xml";

            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(GetType());
            xs.Serialize(fs, this);
            fs.Close();
        }
        public void Resume()
        {
            string fileName = "snake.xml";
            if (sign == '#')
                fileName = "wall.xml";
            if (sign == '$')
                fileName = "food.xml";

            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(GetType());

            if (sign == '#')
                Game.wall = xs.Deserialize(fs) as Wall;
            if (sign == 'o')
                Game.snake = xs.Deserialize(fs) as Snake;
            if (sign == '$')
                Game.food = xs.Deserialize(fs) as Food;
            fs.Close();                
        }
    }
}
