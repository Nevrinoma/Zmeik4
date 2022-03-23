using System;
using System.Collections.Generic;
using System.Threading;

namespace Zmeik4
{
	internal class Program
    {
		static void Main(string[] args)
		{
			Console.SetWindowSize(81, 41);

			Walls walls = new Walls(80, 40);
			walls.Draw();

			Point p = new Point(4, 5, '#');
			Snake snake = new Snake(p, 4, Direction.RIGHT);
			snake.Draw();

			FoodCreator foodCreator = new FoodCreator(80, 40, '&');
			Point food = foodCreator.CreateFood();
			food.Draw();

			while (true)
			{
				if (walls.IsHit(snake) || snake.IsHitTail())
				{
					break;
				}
				if (snake.Eat(food))
				{
					food = foodCreator.CreateFood();
					food.Draw();
				}
				else
				{
					snake.Move();
				}

				Thread.Sleep(100);
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}




			}
			WriteGameOver();
			Console.ReadLine();
		}
		static void WriteGameOver()// функция которая выводит информацию после поражения в игре
		{
			int xOffset = 25;
			int yOffset = 8;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.SetCursorPosition(xOffset, yOffset++);
			WriteText("============================", xOffset, yOffset++);
			WriteText("G A M E     O V E R", xOffset + 1, yOffset++);
			yOffset++;
			WriteText("                     ", xOffset + 2, yOffset++);
			WriteText("Made by Nevrinoma", xOffset + 1, yOffset++);
			WriteText("============================", xOffset, yOffset++);
		}

		static void WriteText(String text, int xOffset, int yOffset)
		{
			Console.SetCursorPosition(xOffset, yOffset);
			Console.WriteLine(text);
		}
	}

}
