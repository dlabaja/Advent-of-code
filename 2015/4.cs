using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Advent_of_code
{
    class A2015_4_1
    {
        static string input = Input.input;
        static void A1()
        {
            using (var md5Hash = MD5.Create())
            {
                for (long i = 0; i < 100000000000000; i++)
                {
                    var sourceBytes = Encoding.UTF8.GetBytes(input + "" + i);
                    var hashBytes = md5Hash.ComputeHash(sourceBytes);
                    var hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
                    if (hash.StartsWith("00000"))
                    {
                        System.Console.WriteLine(hash);
                        System.Console.WriteLine(i);
                        return;
                    }
                }
            }
        }
    }

    class A2015_4_2
    {
        static string input = Input.input;
        static void A2()
        {
            using (var md5Hash = MD5.Create())
            {
                for (long i = 0; i < 100000000000000; i++)
                {
                    var sourceBytes = Encoding.UTF8.GetBytes(input + "" + i);
                    var hashBytes = md5Hash.ComputeHash(sourceBytes);
                    var hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
                    if (hash.StartsWith("000000"))
                    {
                        System.Console.WriteLine(hash);
                        System.Console.WriteLine(i);
                        return;
                    }
                }
            }
        }
    }
}