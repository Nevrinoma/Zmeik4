using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeik4
{
	internal class Figure
	{
		protected List<Point> pList;


		public void Draw()
		{
			foreach (Point p in pList)
			{
				p.Draw();
			}

		}


	}
}
