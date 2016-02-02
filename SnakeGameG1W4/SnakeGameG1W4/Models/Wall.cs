using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGameG1W4.Models
{
    public class Wall : Drawer
    {
        public Wall(int level)
        {
            color = ConsoleColor.Red;
            sign = '#';
            Init(level);
        }
        public void Init(int level)
        {
            body.Clear();
            FileStream fs = new FileStream(string.Format("level{0}.txt", level), FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string[] token = sr.ReadToEnd().Split('\n');
            int row = -1;
            foreach(string s in token)
            {
                row++;
                int col = -1;
                foreach(char ch in s)
                {
                    col++;
                    if (ch == '#')
                        body.Add(new Point(col, row));
                }
            }
        }
    }
}
