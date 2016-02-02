using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Models
{
    class Wall : Drawer
    {
        public Wall()
        {
            color = ConsoleColor.Blue;
            sign = '#';
        }
    }
}
