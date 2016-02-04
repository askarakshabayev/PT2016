using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlSerializationW4G3
{
    public class Point
    {
        public int x, y;
        public Info info = new Info();
        public Point() { }
        
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Info
    {
        public string owner, version;
        public Info() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            F2();
        }
        static void F1()
        {
            FileStream fs = new FileStream("state.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Point p = new Point(5, 6);
            p.info.owner = "abc";
            p.info.version = "1.0";
            XmlSerializer xs = new XmlSerializer(typeof(Point));
            xs.Serialize(fs, p);
            fs.Close();
        }

        static void F2()
        {
            FileStream fs = new FileStream("state.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Point));
            Point a = xs.Deserialize(fs) as Point;

            Console.WriteLine(a.x);
            Console.WriteLine(a.info.owner);
            Console.WriteLine(a.info.version);
            Console.ReadKey();

            fs.Close();
        }
    }
}
