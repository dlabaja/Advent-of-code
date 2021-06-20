using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;


namespace Advent_of_code
{
    static class A2015_7_1
    {
        static string input = Input.input;
        public static Dictionary<string, int> promenne = new Dictionary<string, int>();
        public static int A1()
        {
            while (!promenne.ContainsKey("a"))
            {
                foreach (var item in input.Split("\n", StringSplitOptions.RemoveEmptyEntries))
                {
                    GetValue(item);
                }
            }

            foreach (var item in promenne)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("-------------");
            System.Console.WriteLine("a === " + promenne["a"]);
            return promenne["a"];
        }

        static void GetValue(string item)
        {
            var slova = item.Split(new[] { " ", "\n", "\r", "->" }, StringSplitOptions.RemoveEmptyEntries);
            var vysledek = slova.Last();


            if (item.Contains("AND"))
            {
                int i0;
                int i2;
                if (!EntryExist(slova[0]))
                {
                    var b = int.TryParse(slova[0], out i0);
                    if (!b)
                        return;
                }
                else
                    i0 = promenne[slova[0]];

                if (!EntryExist(slova[2]))
                {
                    var b = int.TryParse(slova[2], out i2);
                    if (!b)
                        return;
                }
                else
                    i2 = promenne[slova[2]];

                var mezivypocet = i0 & i2;
                UpdateEntry(vysledek, mezivypocet);
                return;
            }


            if (item.Contains("OR"))
            {
                int i0;
                int i2;

                if (!EntryExist(slova[0]))
                {
                    var b = int.TryParse(slova[0], out i0);
                    if (!b)
                        return;
                }
                else
                    i0 = promenne[slova[0]];

                if (!EntryExist(slova[2]))
                {
                    var b = int.TryParse(slova[2], out i2);
                    if (!b)
                        return;
                }
                else
                    i2 = promenne[slova[2]];

                var mezivypocet = i0 | i2;
                UpdateEntry(vysledek, mezivypocet);
                return;
            }


            if (item.Contains("LSHIFT"))
            {
                if (!EntryExist(slova[0]))
                    return;

                var mezivypocet = promenne.GetValueOrDefault(slova[0]) << int.Parse(slova[2]);
                UpdateEntry(vysledek, mezivypocet);
                return;
            }


            if (item.Contains("RSHIFT"))
            {
                if (!EntryExist(slova[0]))
                    return;

                var mezivypocet = promenne.GetValueOrDefault(slova[0]) >> int.Parse(slova[2]);
                UpdateEntry(vysledek, mezivypocet);
                return;
            }


            if (item.Contains("NOT"))
            {
                if (!EntryExist(slova[1]))
                    return;

                var mezivypocet = (UInt16)~promenne.GetValueOrDefault(slova[1]);
                UpdateEntry(vysledek, mezivypocet);
                return;
            }


            if (slova.Length == 2) //výsledek
            {
                int i;
                if (!int.TryParse(slova[0], out i) && !int.TryParse(vysledek, out i))
                {
                    try
                    {
                        promenne.Add(vysledek, promenne[slova[0]]);
                    }
                    catch (KeyNotFoundException) { }
                }

            }


            foreach (var word in slova)
            {
                if (word.All(char.IsNumber))
                {
                    UpdateEntry(vysledek, int.Parse(word));
                    return;
                }
            }
        }

        static bool EntryExist(string key)
        {
            if (promenne.ContainsKey(key))
            {
                return true;
            }
            return false;
        }

        static void UpdateEntry(string key, int hodnota)
        {
            if (!EntryExist(key))
                promenne.Add(key, hodnota);
            else
                promenne[key] = hodnota;
        }
    }

    static class A2015_7_2
    {
        static void A2()
        {
            //k inputu jsem přidal "vinputu jsem našel b a přepsal jeho hodnotu na to co mi vyšlo u 7a lul"
            A2015_7_1.A1();
        }
    }
}
