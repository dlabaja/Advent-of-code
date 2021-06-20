using System;
using System.Collections.Generic;


namespace Advent_of_code
{
    class A2015_5_1
    {
        static string input = Input.input;
        static int pocetStringu = 0;
        static int pozice = 1;
        static int samohlasky = 0;
        static char LastChar = ':';
        static bool dveHlasky = false;
        static bool dveVedle = false;
        static List<Char> samohlaskyList = new List<char>()
        {
'a',
'e',
'i',
'o',
'u'
        };

        static List<String> DisallowedList = new List<string>()
        {
"ab",
"cd",
"pq",
"xy"
        };


        static void A1()
        {
            foreach (char item in input.ToCharArray())
            {
                if (!Char.IsLetter(item))
                    continue;

                if (samohlaskyList.Contains(item))
                    samohlasky++;

                if (LastChar == item)
                    dveHlasky = true;

                if (DisallowedList.Contains(LastChar + "" + item))
                    dveVedle = true;

                if (pozice == 16)
                {
                    if (samohlasky >= 3 && dveHlasky == true && dveVedle == false)
                        pocetStringu++;

                    pozice = 1;
                    samohlasky = 0;
                    dveHlasky = false;
                    dveVedle = false;
                    LastChar = ':';
                    continue;
                }
                pozice++;
                LastChar = item;
            }
            System.Console.WriteLine(pocetStringu);
        }
    }

    class A2015_5_2
    {
        static string input = Input.input;
        static int pocetStringu = 0;


        static void A2()
        {
            foreach (var item in input.Split("\n", StringSplitOptions.RemoveEmptyEntries))
            {
                if (StejnyObJedno(item) && DvaPáry(item))
                    pocetStringu++;
            }
            System.Console.WriteLine(pocetStringu);
        }
        static bool StejnyObJedno(string item)
        {
            for (int i = 0; i < item.Length - 2; i++)
            {
                if (item[i] == item[i + 2])
                    return true;
            }
            return false;
        }
        static bool DvaPáry(string item)
        {
            for (int i = 2; i < item.Length; i++)
            {
                if (item.Substring(i).Contains(item.Substring(i - 2, 2)))
                    return true;
            }
            return false;
        }
    }
}