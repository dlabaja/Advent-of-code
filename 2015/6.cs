using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;


namespace Advent_of_code
{
    class A2015_6_1
    {
        static string input = Input.input;
        static bool[,] souradnice = new bool[1000, 1000];

        static void A1()
        {
            foreach (var item in input.Split("\n", StringSplitOptions.RemoveEmptyEntries))
            {

                System.Console.WriteLine(item);
                if (item.Contains("on"))
                {
                    Svetylka(item, true, false);
                }
                else if (item.Contains("off"))
                {
                    Svetylka(item, false, false);
                }
                else
                {
                    Svetylka(item, false, true);
                }
            }
            int vysledek = 0;
            foreach (var item in souradnice)
            {
                if (item)
                    vysledek++;
            }

            System.Console.WriteLine(vysledek);
        }
        static void Svetylka(string item, bool b, bool toggle)
        {
            string[] čísla = Regex.Split(item, @"\D+");
            int x1 = int.Parse(čísla[1]);
            int y1 = int.Parse(čísla[2]);
            int x2 = int.Parse(čísla[3]);
            int y2 = int.Parse(čísla[4]);

            for (int x = x1; x < x2 + 1; x++)
            {
                for (int y = y1; y < y2 + 1; y++)
                {
                    if (toggle)
                    {
                        souradnice[x, y] = !souradnice[x, y];
                        continue;
                    }
                    if (b)
                    {
                        souradnice[x, y] = true;
                    }
                    else
                    {
                        souradnice[x, y] = false;
                    }
                }
            }
        }
    }

    class A2015_6_2
    {
        static string input = Input.input;
        static bool[,] souradnice = new bool[1000, 1000];
        static int[,] jas = new int[1000, 1000];
        static int bright = 0;
        static void A2()
        {
            foreach (var item in input.Split("\n", StringSplitOptions.RemoveEmptyEntries))
            {

                System.Console.WriteLine(item);
                if (item.Contains("on"))
                {
                    Svetylka(item, true, false);
                }
                else if (item.Contains("off"))
                {
                    Svetylka(item, false, false);
                }
                else
                {
                    Svetylka(item, false, true);
                }
            }
            int vysledek = 0;
            foreach (var item in souradnice)
            {
                if (item)
                    vysledek++;
            }

            System.Console.WriteLine(vysledek);
            System.Console.WriteLine(bright);

        }
        static void Svetylka(string item, bool b, bool toggle)
        {
            string[] čísla = Regex.Split(item, @"\D+");
            int x1 = int.Parse(čísla[1]);
            int y1 = int.Parse(čísla[2]);
            int x2 = int.Parse(čísla[3]);
            int y2 = int.Parse(čísla[4]);

            for (int x = x1; x < x2 + 1; x++)
            {
                for (int y = y1; y < y2 + 1; y++)
                {
                    if (toggle)
                    {
                        souradnice[x, y] = !souradnice[x, y];
                        jas[x, y] += 2;
                        bright += 2;
                        continue;
                    }
                    if (b)
                    {
                        souradnice[x, y] = true;
                        jas[x, y]++;
                        bright++;
                    }
                    else
                    {
                        souradnice[x, y] = false;
                        if (jas[x, y] != 0)
                        {
                            jas[x, y]--;
                            bright--;
                        }
                    }
                }
            }
        }
    }
}
