using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Advent_of_code
{
    class A2015_2_1
    {
        static int i = 0;
        static string input = Input.input;
        static int délka = 0;
        static int šířka = 0;
        static int výška = 0;
        static int výsledek = 0;
        void A1()
        {
            string[] čísla = Regex.Split(input, @"\D+");
            foreach (var cislo in čísla)
            {
                i++;
                if (i == 1)
                    délka = int.Parse(cislo);
                if (i == 2)
                    šířka = int.Parse(cislo);
                if (i == 3)
                {
                    výška = int.Parse(cislo);
                    výsledek = výsledek + (VetsiMensi(délka, šířka, výška)) + 2 * délka * výška + 2 * šířka * výška + 2 * délka * šířka;
                    délka = 0;
                    šířka = 0;
                    výška = 0;
                    i = 0;
                    System.Console.WriteLine(výsledek);
                }
            }
            System.Console.WriteLine(výsledek);
        }

        static int VetsiMensi(int d, int š, int v)
        {
            int[] array = { d * š, š * v, d * v };
            return array.Min();
        }
    }

    class A2015_2_2
    {
        static int i = 0;
        static string input = Input.input;
        static int délka = 0;
        static int šířka = 0;
        static int výška = 0;
        static int výsledek = 0;
        
        void A2()
        {
            string[] čísla = Regex.Split(input, @"\D+");
            foreach (var cislo in čísla)
            {
                i++;
                if (i == 1)
                    délka = int.Parse(cislo);
                if (i == 2)
                    šířka = int.Parse(cislo);
                if (i == 3)
                {
                    výška = int.Parse(cislo);
                    výsledek = výsledek + VetsiMensi(délka, šířka, výška) + (délka * výška * šířka);
                    délka = 0;
                    šířka = 0;
                    výška = 0;
                    i = 0;
                }
            }
            System.Console.WriteLine(výsledek);
        }

        static int VetsiMensi(int d, int š, int v)
        {
            int[] array = { d, š, v };
            Array.Sort(array);
            return 2 * array[0] + 2 * array[1];
        }
    }
}