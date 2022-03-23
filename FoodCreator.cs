using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeik4
{
	internal class FoodCreator //класс создания еды для змейки
	{
		int mapWidht; // поля для значения ширины игрового поля
		int mapHeight; // поля для значения длины игрового поля
		char sym; // поля для значения символа еды 

		Random random=new Random();

		public FoodCreator(int mapWidth,int mapHeight,char sym) //конструктор генерации еды
		{
			this.mapWidht = mapWidth;
			this.mapHeight = mapHeight; //"this." используется для определения обращения к полям за конструктором, а не его аргументам
			this.sym = sym;
		}

		public Point CreateFood() //метод создания еды в случайном месте
		{
			int x = random.Next(2, mapWidht - 2);
			int y = random.Next(2, mapHeight - 2);
			return new Point(x, y, sym); //"new" - создает новую точку, "return" - её возвращает, "Point" - подставляет аргументы в конструктор
		}
	}
}
