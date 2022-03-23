using System;
using System.Collections.Generic;
using System.Threading;

namespace Zmeik4
{
	internal class Program
    {
        static void Main(string[] args)
        {
            //Console.SetWindowSize(81, 41);
            VerticalLine v1 = new VerticalLine(0, 10, 5, '%');
            Draw(v1);










            Point p=new Point(4,5,'¤');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(82, 42, '&');
            Point food = foodCreator.CreateFood();
            food.Draw();

			while (true)
			{
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
			}

			while (true)
			{
				if (Console.KeyAvailable)
				{
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);

                }
                Thread.Sleep(100);
                snake.Move();
			}
            /*
            HorizontalLine upLine=new HorizontalLine(0,80,0,'#');
            HorizontalLine downLine = new HorizontalLine(0, 80, 40, '#');
            VerticalLine leftLine = new VerticalLine(0, 40, 0, '#');
            VerticalLine rightLine = new VerticalLine(0, 40, 80, '#');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();
            */  


            Console.ReadLine();
        }
        static void Draw(Figure figure)
		{
            figure.Draw();
		}
    }

}
