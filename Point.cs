using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeik4
{
	internal class Point
	{
		public int x; // значение "х"
		public int y; // значение "у"
		public char sym; // вид символа

		public Point() //пустой конструктор
		{
		}
		public Point(int x, int y, char sym) //конструктор с аргументами по позициям и виду символа
		{
			this.x = x;
			this.y = y;
			this.sym = sym;
		}
		public Point(Point p) // конструктор для обнавления значений
		{
			x = p.x;
			y = p.y; // замена предедущего значение на новое
			sym = p.sym;
		}
		public void Move(int offset,Direction direction) //метод для передвижения змейки по игровому полю
		{
			if (direction==Direction.RIGHT) //меняет направление на выбранную из списка "enum direction" сторону, путем распознования нажатой кнопки
			{
				x = x + offset; //изменение направления 
			}
			else if (direction == Direction.LEFT)
			{
				x = x - offset;
			}
			else if (direction == Direction.UP)
			{
				y = y - offset;
			}
			else if (direction == Direction.DOWN)
			{
				y = y + offset;
			}
		}

		public bool IsHit(Point p) //метод проверки сталкивания змейки со своим телом
		{
			return p.x == this.x && p.y == this.y;
		}

		public void Draw() //корневой метод отрисовки точек в заданой позиции и заданым символом
		{
			Console.SetCursorPosition(x, y);
			Console.Write(sym);
		}

		public void Clear() // метод для очистки координаты от символа, путем замены на пробел
		{
			sym = ' ';
			Draw();
		}

		public override string ToString()
		{
			return x + ", " + y + ", " + sym;
		}
	}
}
