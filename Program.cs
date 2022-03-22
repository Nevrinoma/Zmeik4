using System;
using System.Collections.Generic;

namespace Zmeik4
{
	internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(81, 41);

            Point p1=new Point(0,0,'*');
            p1.Draw();

            Point p2=new Point(4,5,'¤');
            p2.Draw();

            HorizontalLine upLine=new HorizontalLine(0,80,0,'#');
            HorizontalLine downLine = new HorizontalLine(0, 80, 40, '#');
            VerticalLine leftLine = new VerticalLine(0, 40, 0, '#');
            VerticalLine rightLine = new VerticalLine(0, 40, 80, '#');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();
                


            Console.ReadLine();
        }

    }

}
