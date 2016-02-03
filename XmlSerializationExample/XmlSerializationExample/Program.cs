using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlSerializationExample
{
    public class Point
    {
        public int x, y;
        private int z;
        public Info info = new Info();

        public Point() { }

        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
    public class Info
    {
        public string owner, version;
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
            Point a = new Point(3, 4, 5);
            a.info.owner = "ABC";
            a.info.version = "1.0";
            XmlSerializer xs = new XmlSerializer(typeof(Point));
            xs.Serialize(fs, a);

            fs.Close();
        }

        static void F2()
        {
            FileStream fs = new FileStream("state.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Point));
            Point b = xs.Deserialize(fs) as Point;
            Console.WriteLine(b.info.version);
            Console.WriteLine(b.x);
            Console.ReadKey();
            fs.Close();
        }
    }
}
