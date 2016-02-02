using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Point
    {
        public int x;
        public int y;
        public int z;
        public Info info;

        public Point()
        {
            x = 10;
            y = 20;
            z = 30;
            info = new Info();
            info.owner = "abc";
            info.version = "1.0";
        }
    }

    public class Info
    {
        public string owner;
        public string version;
    }

    class Program
    {
        static void Main(string[] args)
        {
            F2();
        }
        public static void F1()
        {
            Point a = new Point();

            FileStream fs = new FileStream("state.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Point));
            xs.Serialize(fs, a);
            fs.Close();
        }
        public static void F2()
        {
            FileStream fs = new FileStream("state.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Point));
            Point b = xs.Deserialize(fs) as Point;

            Console.WriteLine(b.x);
            Console.WriteLine(b.info.owner);
            Console.ReadKey();

            fs.Close();
        }
    }
}
