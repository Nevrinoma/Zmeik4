using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeik4
{
	internal class Figure // класс вывода фигур и проверки столкновения с ними
	{
		protected List<Point> pList; // закрытый список типа "Point", благодоря "protected" виден наследникам класса "Figure"

		public void  Draw() // метод для отрисовки точек
		{
			foreach (Point p in pList) //цикл выводящий каждое значение "р" из списка "pList"
			{
				p.Draw();
			}
		}

		internal bool IsHit(Figure figure) // метод проверки столкновения для обьектов класса "Figure"
		{
			foreach (var p in pList)
			{
				if (figure.IsHit(p)) //при столкновении возвращает bool значение
					return true;
			}
			return false;
		}

		private bool IsHit(Point point) // метод проверки столкновения для обьектов класса "Point"
		{
			foreach (var p in pList)
			{
				if (p.IsHit(point)) //при столкновении возвращает bool значение
					return true;
			}
			return false;
		}



	}
}
