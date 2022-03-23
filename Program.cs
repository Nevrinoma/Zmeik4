using System;
using System.Collections.Generic;
using System.Threading;

namespace Zmeik4
{
	internal class Program
    {
		static void Main(string[] args)
		{
			Console.SetWindowSize(81, 41);// фиксированный размер окна консоли

			Walls walls = new Walls(80, 40);// задаем аргументы для вывода стенок игрового поля
			walls.Draw();// выводим стенки в консоль

			Point p = new Point(4, 5, '#');//создание символа змейки и аргументов
			Snake snake = new Snake(p, 4, Direction.RIGHT); //тело змейки
			snake.Draw();// вывод змейки

			FoodCreator foodCreator = new FoodCreator(80, 40, '&'); //допустимые значения для появления еды
			Point food = foodCreator.CreateFood();  //появление еды
			food.Draw();// вывод в консоль еды

			while (true) //цикл игры с проверкой на столкновение и движением
			{
				if (walls.IsHit(snake) || snake.IsHitTail())//конструкция действий при столкновении
				{
					break;// выход из цикла
				}
				if (snake.Eat(food)) //конструкция действий при поедании 
				{
					food = foodCreator.CreateFood();// смена координаты еды на новое место
					food.Draw();// вывод в консоль
				}
				else
				{
					snake.Move();// если ифы выше не сработали, продолжить движение по направлению
				}

				Thread.Sleep(100);//чтобы направление не менялось мнгновенно
				if (Console.KeyAvailable)//проверка нажатия на кнопку
				{
					ConsoleKeyInfo key = Console.ReadKey();// смена значения переменной
					snake.HandleKey(key.Key); // изменение направления движения
				}

			}
			WriteGameOver();//вывод информации при выходе из цикла
			Console.ReadLine();// чтобы не закрывалось консоль после вывода инфо
		}
		static void WriteGameOver()// метод который выводит информацию о статусе игры
		{
			int xOffset = 25;
			int yOffset = 8;
			Console.ForegroundColor = ConsoleColor.Red; //перекрашивает все новые значения в красный цвет
			Console.SetCursorPosition(xOffset, yOffset++);
			WriteText("============================", xOffset, yOffset++);
			WriteText("G A M E     O V E R", xOffset + 1, yOffset++);
			yOffset++;
			WriteText("                     ", xOffset + 2, yOffset++);
			WriteText("Made by Nevrinoma", xOffset + 1, yOffset++);
			WriteText("============================", xOffset, yOffset++);
		}

		static void WriteText(String text, int xOffset, int yOffset)// метод для вывода информации в определенной позиции с 3 аргументами
		{
			Console.SetCursorPosition(xOffset, yOffset);// вывод в консоль в определенной позиции
			Console.WriteLine(text);
		}
	}

}
