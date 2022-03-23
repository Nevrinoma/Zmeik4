using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeik4
{
	internal class HorizontalLine : Figure
	{
		
		public HorizontalLine(int xLeft,int xReight,int y,char sym) //конструктор использующий аргументы координат от и до по "х",комер строки(коордлинаты по "у") и символ стенки
		{ 
			pList = new List<Point>(); //список для "Point"
			for (int x = xLeft; x <= xReight; x++) //заполнение от "х" начала до "х" конца, путем перебора до ограничения 
			{
				Point p = new Point(x, y, sym); //создание обьекта
				pList.Add(p);// добавление обьекта в список
			}
		}





	}
}
