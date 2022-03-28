using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zmeik4
{
    internal class Video //класс для подобия мини проигрывателя
    {
        public void video() //функция для проигрывателя
        {

            for (int i = 0; i <= 100; i++) // отсчет процентов 
            {
                Console.Write($"\rProgress: {i}%   ");
                Thread.Sleep(25);
            }
            Console.Write("\rDone!          ");
            Thread.Sleep(200);
            Console.Clear();                                  // переключение между картинок с призраками
            Console.WriteLine(@"                       
     .-.
   .'   `.
   :g g   :
   : o    `.
  :         ``.
 :             `.
:  :         .   `.
:   :          ` . `.
 `.. :            `. ``;
    `:;             `:'
       :              `.
        `.              `.     .
          `'`'`'`---..,___`;.-'");
            Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine(@"
       ###, ,##, ,##,
       #  # #  # #  #
       ###  #  # #  #
       #  # #  # #  #
       ###' '##' '##'
            .--,
           /  (
          /    \
         /      \ 
        /  0  0  \
((()   |    ()    |   ()))
\  ()  (  .____.  )  ()  /
 |` \_/ \  `""`  / \_/ `|
 |       `.'--'.`       |
  \        `""`        /
   \                  /
    `.              .'    ,
     |`             |  _.'|
     |              `-'  /
     \                 .'
      `.____________.-'");
            Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine(@"
        ___
      _/ ..\
     ( \  0/__
      \    \__)
      /     \
     /      _\
    `""""""");
            Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine(@"
        ___
     __/ oo\
     ( \  -/__
      \    \__)
      /     \
     /      _\
    `""""""");
            Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine(@"
        ___
      _/ @@\
     ( \  O/__
      \    \__)
      /     \
     /      _\
    `""""""");
            Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine(@"
        ___
      _/ 66\
     ( \  ^/__
      \    \__)
      /     \
     /      _\
    `""""""");
            Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine(@"
        ___
      _/ ""\
     ( \  ~/__
      \    \__)
      /     \
     /      _\
    `""""""");





        }

    }
}   
