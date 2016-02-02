using System;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGameG1W4.Models
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
            FileStream fs;
            if (sign == 'o')
                fs = new FileStream("snake.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            else if (sign == '#')
                fs = new FileStream("wall.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            else
                fs = new FileStream("food.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            XmlSerializer xs = new XmlSerializer(GetType());
            xs.Serialize(fs, this);
            fs.Close();                
        }
    }
}
