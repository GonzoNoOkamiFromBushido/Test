﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            String stroka = Console.ReadLine().ToLower();

            int length = stroka.Length;

            for (int i = 0; i < length; i++)
            {
                if (stroka.Remove(i, 1).IndexOf(stroka[i]) >= 0)
                    Console.Write(')');
                else
                    Console.Write('(');
            }

            Console.Read();
        }
    }
}
