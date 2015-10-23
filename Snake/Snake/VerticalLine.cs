using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int x, int yBottom, int yTop, char sym )
        {
            pList = new List<Point>();
            for (int y=yBottom; y<=yTop; y++) 
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
