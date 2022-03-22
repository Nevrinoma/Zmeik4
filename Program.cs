using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


            Console.ReadLine();
        }

    }

}
