using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace lab1._2
{

    public class Point
    {
        public Info info;
        public int t;
        public int x;
        [XmlIgnore]
        private int y;
        protected int z;
        public void Method1()
        {

        }
        public Point()
        {
            x = 10;
            y = 20;
            z = 30;
            t = 40;
            info = new Info { owner = "Askar", version = "1.0" };
        }
    }

    public class Point2 : Point
    {
        public void Method1()
        {
            
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
        public static void F2()
        {
            FileStream fs = new FileStream("state.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Point));
            Point p = (Point)xs.Deserialize(fs);
            Console.WriteLine(p.x);
            Console.WriteLine(p.t);
            Console.ReadKey();
        }
        public static void F1()
        {
            FileStream fs = new FileStream("state.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer();
            Point p = new Point();
            xs.Serialize(fs, p);
        }
    }
}
