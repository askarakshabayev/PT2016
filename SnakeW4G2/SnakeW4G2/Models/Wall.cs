using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeW4G2.Models
{
    public class Wall : Drawer
    {
        public Wall()
        {
            color = ConsoleColor.Red;
            sign = '#';
            setLevel(1);
        }

        public void setLevel(int level)
        {
            string fileName = string.Format("level{0}.txt", level);
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            string map = sr.ReadToEnd();
            string[] rows = map.Split('\n');

            // ......####.... rows[0]
            // .....####..... rows[1]
            body.Clear();
            for (int i = 0; i < rows.Length; i++)
                for (int j = 0; j < rows[i].Length; j++)
                    if (rows[i][j] == '#')
                        body.Add(new Point(j, i));

            sr.Close();
            fs.Close();
        }
    }
}
