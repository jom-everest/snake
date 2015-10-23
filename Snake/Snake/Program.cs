using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            (new HorizontalLine(0, 78, 0, '+')).Draw();
            (new HorizontalLine(0, 78, 24, '+')).Draw();
            (new VerticalLine(0, 0, 24, '+')).Draw();
            (new VerticalLine(78, 0, 24, '+')).Draw();
            Console.SetCursorPosition(3, 3);

            Console.ReadLine();
        }
    }
}
