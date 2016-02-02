using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Models
{
    class Drawer
    {
        public ConsoleColor color;
        public char sign;
        public List<Point> body = new List<Point>();

        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach(Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }
        public Drawer() { }

        public void Save()
        {
            string fileName = "";
            if (sign == '#')
                fileName = "wall.xml";
            if (sign == '$')
                fileName = "food.xml";
            if (sign == 'o')
                fileName = "snake.xml";

            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(GetType());
            xs.Serialize(fs, this);
            fs.Close();
        }

        public void Resume()
        {
            string fileName = "";
            if (sign == '#')
                fileName = "wall.xml";
            if (sign == '$')
                fileName = "food.xml";
            if (sign == 'o')
                fileName = "snake.xml";

            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(GetType());
            fs.Close();
        }
    }
}
