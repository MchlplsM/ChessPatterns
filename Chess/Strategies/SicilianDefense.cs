using System;
using Chess.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Strategies
{
    class SicilianDefense :IStrategies
    {
        //CONSTRUCTOR
        public SicilianDefense()
        { }
        //METHOD
        public void FillTheLines()
        {
            List<string> lines = new List<string>();
            int counter = 0;
            int even = 8;
            int odd = 7;
            Console.WriteLine("4.Sicilian Defense");
            Console.WriteLine("      A     B     C     D     E     F     G     H  ");
            Console.WriteLine("   -------------------------------------------------");
            for (int i = 0; i < 24; i++)
            {
                if (counter == 1)
                {
                    lines.Add($"{even}  | [R] ||[N]|| [B] ||[Q]|| [K] ||[B]|| [N] ||[R]||  {even}");
                    Console.WriteLine(lines[i]);
                    even -= 2;
                }
                else if (counter == 4)
                {
                    lines.Add($"{odd}  ||[P]|| [P] ||[P]||     ||[P]|| [P] ||[P]|| [P] |  {odd}");
                    Console.WriteLine(lines[i]);
                    odd -= 2;
                }
                else if (counter == 0 || counter == 2 || counter == 6 || counter == 7 || counter == 8 || counter == 12 || counter == 13 || counter == 14 || counter == 18 || counter == 20)
                {
                    if (counter == 7 || counter == 13)
                    {
                        if (counter == 7)
                        {
                            lines.Add($"{even}  |     |||||||     |||||||     |||||||     |||||||  {even}");
                            Console.WriteLine(lines[i]);
                            even -= 2;
                        }
                        else
                        {
                            lines.Add($"{even}  |     |||||||     |||||||     ||(P)||     |||||||  {even}");
                            Console.WriteLine(lines[i]);
                            even -= 2;
                        }
                    }
                    else
                    {
                        lines.Add("   |     |||||||     |||||||     |||||||     |||||||");
                        Console.WriteLine(lines[i]);
                    }
                }
                else if (counter == 3 || counter == 5 || counter == 9 || counter == 10 || counter == 11 || counter == 15 || counter == 16 || counter == 17 || counter == 21 || counter == 23)
                {
                    if (counter == 10 || counter == 16)
                    {
                        if (counter == 10)
                        {
                            lines.Add($"{odd}  |||||||     ||||||| [P] |||||||     |||||||     |  {odd}");
                            Console.WriteLine(lines[i]);
                            odd -= 2;
                        }
                        else
                        {
                            lines.Add($"{odd}  |||||||     |||||||     |||||||     |||||||     |  {odd}");
                            Console.WriteLine(lines[i]);
                            odd -= 2;
                        }
                    }
                    else
                    {
                        lines.Add("   |||||||     |||||||     |||||||     |||||||     |");
                        Console.WriteLine(lines[i]);
                    }
                }
                else if (counter == 19)
                {
                    lines.Add($"{even}  | (P) ||(P)|| (P) ||(P)|| (P) ||||||| (P) ||(P)||  {even}");
                    Console.WriteLine(lines[i]);
                    even -= 2;
                }
                else if (counter == 22)
                {
                    lines.Add($"{odd}  ||(R)|| (N) ||(B)|| (Q) ||(K)|| (B) ||(N)|| (R) |  {odd}");
                    Console.WriteLine(lines[i]);
                    odd -= 2;
                }
                counter++;
            }
            Console.WriteLine("   -------------------------------------------------");
            Console.WriteLine("      A     B     C     D     E     F     G     H  ");

        }
    }
}
