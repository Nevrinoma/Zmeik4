using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Zmeik4
{
    internal class Menu
    {
        public void MainMenu()
        {
            MessageBox.Show("Welcome to the Snake Game!", "Made by Nevrinoma");
            while (true)
            {
                Console.Write("Enter you Name >>> ");
                string nickname = Console.ReadLine();
                MessageBoxResult result = MessageBox.Show($"{nickname}, let's open the Main Menu?", "The Snake Game",MessageBoxButton.YesNo);
                if (result==MessageBoxResult.Yes)
                {
                    Console.WriteLine("1 >>> play the Snake Game\n2 >>>Play Cars\n3 >>> Check Tabble of Scores\n4 >>> Watch Video\n5 >>> Exit");
                    string menuchoice = Console.ReadLine();
                    if (menuchoice == "1")
                    {
                        Console.Clear();
                        SnakeGame zmeika = new SnakeGame();
                        zmeika.Snakegame();
                    }
                    if (menuchoice == "2")
                    {
                        Console.Clear();
                        CarGame cars = new CarGame();
                        cars.Cargame();
                    }
                    if (menuchoice == "3")
                    {
                        Console.Clear();
                        ScoreTab();
                    }
                    if (menuchoice == "4")
                    {
                        Console.Clear();
                        Video st = new Video();
                        st.video();
                    }
                    if (menuchoice == "5")
                    {
                        Console.Clear();
                        Console.Beep();
                    }
                    
                }

                void ScoreTab()
                {
                    Console.Clear();
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


    }
}
