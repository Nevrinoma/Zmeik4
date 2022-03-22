using System;
using System.Collections.Generic;

namespace Zmeik4
{
	internal class Program
    {
        static void Main(string[] args)
        {
            Point p1=new Point(0,0,'*');
            p1.Draw();

            Point p2=new Point(4,5,'¤');
            p2.Draw();

            HorizontalLine line=new HorizontalLine(5,10,8,'+');
            line.Drow();

            Console.ReadLine();
        }

    }

}
