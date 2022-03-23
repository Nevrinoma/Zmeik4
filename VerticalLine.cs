using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeik4
{
	internal class VerticalLine : Figure //наследственный класс
	{

		public VerticalLine(int yUp, int yDown, int x, char sym) //конструктор использующий аргументы координат от и до по "y",комер строки(коордлинаты по"x") и символ стенки
		{
			pList = new List<Point>();//список для "Point"
			for (int y = yUp; y <= yDown; y++)//заполнение от "y" начала до "y" конца, путем перебора до ограничения 
			{
				Point p = new Point(x, y, sym);//создание обьекта
				pList.Add(p);// добавление обьекта в список
			}

		}
		
	}
}
