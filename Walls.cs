using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeik4
{
	internal class Walls//класс для стен
	{
		List<Figure> wallList;//список длязначений стен

		public Walls(int mapWidth, int mapHeight)//конструктор, копирующий размер поля 
		{
			wallList = new List<Figure>();//создает список с классом фигура

			
			HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '▀');
			HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '▄');
			VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '▓');
			VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '▓');

			wallList.Add(upLine);
			wallList.Add(downLine);
			wallList.Add(leftLine);
			wallList.Add(rightLine);
		}

		internal bool IsHit(Figure figure)//метод для значений класса "figure"
		{
			foreach (var wall in wallList)//перебор списка wallList
			{
				if (wall.IsHit(figure))//проверка класса фигуры на столкновение со стеной
				{
					return true;//возврат
				}
			}
			return false;//возврат
		}

		public void Draw()//метод вывода стен в консоль
		{
			foreach (var wall in wallList)//перебор количества нужных для вывода значений в списке
			{
				wall.Draw();//вывод
			}
		}
	}
}
