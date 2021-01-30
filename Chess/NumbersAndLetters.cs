using Chess.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    
    class NumbersAndLetters
    {
        static Set chessSet = new Set();
        static RuyLopez chessSetRL = new RuyLopez();
        static ItalianGame chessSetIG = new ItalianGame();
        static SicilianDefense chessSetSD = new SicilianDefense();
        static FrenchDefense chessSetFD = new FrenchDefense();
        static CaroKannDefense chessSetCKD = new CaroKannDefense();
        //CONST
        public NumbersAndLetters()
        {
            addNumbersAndLetters();
        }
        //METHOD
        public void addNumbersAndLetters()
        {

            int counter = 0;
            for (; ; )
            {
                if (counter == 0)
                {
                    chessSet.FillTheLines();
                    var key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        counter++;
                        Console.Clear();
                    }
                }
                else if(counter == 1) 
                { 
                    chessSetRL.FillTheLines();
                    var key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        counter++;
                        Console.Clear();
                    }
                }
                else if (counter == 2)
                {
                    chessSetIG.FillTheLines();
                    var key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        counter++;
                        Console.Clear();
                    }
                }
                else if (counter == 3)
                {
                    chessSetSD.FillTheLines();
                    var key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        counter++;
                        Console.Clear();
                    }
                }
                else if (counter == 4)
                {
                    chessSetFD.FillTheLines();
                    var key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        counter++;
                        Console.Clear();
                    }
                }
                else if (counter == 5)
                {
                    chessSetCKD.FillTheLines();
                    var key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        counter = 0;
                        Console.Clear();
                    }
                }
            }
        }
    }
}
