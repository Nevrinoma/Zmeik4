using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Zmeik4
{
    internal class Menu // класс главного меню программы
    {
        public void MainMenu() //функция с бесконечным циклом и приемом рещений
        {
            MessageBox.Show("Welcome to the Snake Game!", "Made by Nevrinoma"); //приветствие через окно
            while (true) // бесконечный цикл
            {
                Console.Write("Enter you Name >>> "); //знакомство для вывода имени в окно
                string nickname = Console.ReadLine();
                MessageBoxResult result = MessageBox.Show($"{nickname}, let's open the Main Menu?", "The Snake Game",MessageBoxButton.YesNo);
                if (result==MessageBoxResult.Yes)
                {
                    Console.WriteLine("1 >>> play the Snake Game\n2 >>>Play Cars\n3 >>> Check Tabble of Scores\n4 >>> Watch Video\n5 >>> Exit");
                    string menuchoice = Console.ReadLine();
                    if (menuchoice == "1")
                    {
                        Console.Clear(); //чистка консоли
                        SnakeGame zmeika = new SnakeGame();
                        zmeika.Snakegame(); //запуск змейки
                    }
                    if (menuchoice == "2")
                    {
                        Console.Clear();//чистка консоли
                        CarGame cars = new CarGame();
                        cars.Cargame(); // запуск машинок
                    }
                    if (menuchoice == "3")
                    {
                        Console.Clear();//чистка консоли
                        ScoreTab(); // запуск таблицы
                    }
                    if (menuchoice == "4")
                    {
                        Console.Clear();//чистка консоли
                        Video st = new Video();
                        st.video(); // запуск слайд шоу
                    }
                    if (menuchoice == "5")
                    {
                        Console.Clear();//чистка консоли
                        Console.Beep(); // запуск выхода
                    }
                    
                }
                else
	{
                 Console.Beep(); // запуск выхода
	}
                void ScoreTab()  // метод чтения файла и вывод текста из файла в консоль
                {
                    Console.Clear(); // запуск выхода
                    StreamReader from_file = new StreamReader(@"..\..\ScoreTab.txt");
                    string text = from_file.ReadToEnd();
                    Console.WriteLine(text);
                    from_file.Close();
                    Console.ReadKey(true);
                    Console.Clear();
                }


                Console.ReadLine();
                break;
            }
        }

        Console.ReadLine();
    }
}
