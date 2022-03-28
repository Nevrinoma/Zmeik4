using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeik4
{
	internal class Snake : Figure //наследственный класс
	{
		int score = 0;
		Direction direction; //для направлений движения из "enum"
		public Snake(Point tail,int lenght,Direction _direction,int score)// конструктор змейка с аргументами
		{
			direction = _direction;//приравнение направления
			pList = new List<Point>();//генерация списка
			for (int i = 0; i < lenght; i++)
			{
				Point p = new Point(tail);//создания точки тела(в хвосте)
				p.Move(i, direction);// смещение тела
				pList.Add(p);// добавление ячейки тела(символа)
			}
		}

		public int ScorePoint()
		{
			score++; //прибавление очков
			Console.SetCursorPosition(69, 39); //установка позиции Score
			Console.WriteLine($"Score: {score}"); //вывод
			return score;
		}

		internal void Move()//метод движения
		{
			Point tail = pList.First();//хвост ставится на первую позицию в списке
			pList.Remove(tail);//удаление точки хвоста
			Point head = GetNextPoint();//создание головы
			pList.Add(head);//добавление головы в список

			tail.Clear();//замена хвоста на пробел
			head.Draw();// вывод головы в консоль
		}

		public Point GetNextPoint() //метод для создания и передвижения тела змейки
		{
			Point head = pList.Last();
			Point nextPoint= new Point(head);
			nextPoint.Move(1, direction); //смещает голову на деление в направление змейки
			return nextPoint;// возврат
		}

		internal bool IsHitTail()// метод проверки самопоедания
		{
			var head = pList.Last();//создание переменной  равной последней точке в списке
			for (int i = 0; i < pList.Count - 2; i++)//цикл повторяющийся до соответсвия с кол-ва значений с анологичным в списке
			{
				if (head.IsHit(pList[i]))//конструкция проверки столкновения головы с любой частью тела
					return true;//выход из цикла
			}
			return false;
		}

		public void HandleKey(ConsoleKey key)//метод управления с помощью стрелочек на клавиатуре
		{
			if (key == ConsoleKey.LeftArrow)
				direction = Direction.LEFT;
			else if (key == ConsoleKey.RightArrow)
				direction = Direction.RIGHT;                //конструкция считывания нажатия кнопки и изменения направления на аналогичное
			else if (key == ConsoleKey.DownArrow)
				direction = Direction.DOWN;
			else if (key == ConsoleKey.UpArrow)
				direction = Direction.UP;
		}

		internal bool Eat(Point food) //метод поедания еды
		{
			Point head = GetNextPoint();//новая точка головы
			if (head.IsHit(food))// при столкновении с едой
			{
				food.sym = head.sym; //еда заменяется на голову
				pList.Add(food);// добавление в список
				return true;
			}
			else              //возврат значений bool
			{
				return false;
			}
		}
	}
}
