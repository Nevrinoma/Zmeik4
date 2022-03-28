using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows;

namespace Zmeik4
{
	internal class Program // основной класс
	{
		static void Main(string[] args)
		{

			Console.SetWindowSize(81, 41);// фиксированный размер окна консоли

			Menu menu = new Menu();  //вызов меню
			menu.MainMenu();

		}
	}
}