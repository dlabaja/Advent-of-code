using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace Advent_of_code
{
    class A2015_3_1
    {
        static string input = Input.input;
        static List<string> souradky = new List<string>();
        static int x = 0;
        static int y = 0;
        static void A1()
        {
            foreach (var item in input.ToCharArray())
            {
                if (item == '>')
                    x++;
                if (item == '<')
                    x--;
                if (item == '^')
                    y++;
                if (item == 'v')
                    y--;
                if (souradky.Contains(x + ":" + y))
                    continue;
                souradky.Add(x + ":" + y);
                System.Console.WriteLine(x + ":" + y);
            }
            System.Console.WriteLine(souradky.Count + 1);
        }
    }

    class A2015_3_2
    {
        static string input = Input.input;
        static List<string> souradky = new List<string>();
        static int x1 = 0;
        static int y1 = 0;
        static int x2 = 0;
        static int y2 = 0;
        static int pozice = 1;
        static void A2()
        {
            foreach (var item in input.ToCharArray())
            {
                if (pozice == 1)
                {
                    if (item == '>')
                        x1++;
                    if (item == '<')
                        x1--;
                    if (item == '^')
                        y1++;
                    if (item == 'v')
                        y1--;
                    if (!souradky.Contains(x1 + ":" + y1))
                        souradky.Add(x1 + ":" + y1);
                    System.Console.WriteLine("**1** " + x1 + ":" + y1);
                }

                else
                {
                    if (item == '>')
                        x2++;
                    if (item == '<')
                        x2--;
                    if (item == '^')
                        y2++;
                    if (item == 'v')
                        y2--;
                    if (!souradky.Contains(x2 + ":" + y2))
                        souradky.Add(x2 + ":" + y2);
                    System.Console.WriteLine("**2** " + x2 + ":" + y2);
                }

                pozice++;
                if (pozice > 2)
                    pozice = 1;
            }
            System.Console.WriteLine(input.ToCharArray().Count());
            System.Console.WriteLine(souradky.Count);
        }
    }
}