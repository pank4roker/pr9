using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1

            //int count = 0;
            //for(int x=10;x<=99;x++)
            //{
            //    if(x % 2 == 0)
            //    {
            //        Console.WriteLine(x);
            //        count++;
            //    }
            //}
            //Console.WriteLine($"кол-во={count}");

            //2

            //int s = 0;
            //for (int i = 10; i <= 99; i++)
            //{
            //    if (i % 25 == 0)
            //    {
            //        s += i;
            //    }
            //}
            //Console.WriteLine($"S={s}");
            //5

            //for(int i=0;i<=11;i++)
            //{
            //    if (i % 2 != 0 && i !=3)
            //    {
            //        Console.Write($" { i}");
            //    }
            //}

            //3

            //for (int i = 1; i < 11; i++)
            //{
            //    for (int j = 3; j < 4; j++)
            //    {
            //        int result = i * j;
            //        Console.Write("{0}*{1}={2}", i, j, result);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            //4
            Console.Write($"y:");
            for (int x=1;x<=20;x=x+2)
            {
                int y = 5 * x - 2;
                Console.Write($"|{y}|");
            }
             for(int i=1;i<=2;i++)
            {
                Console.WriteLine("");
            }
            Console.Write($"x:");
            for (int x = 1; x <= 20; x = x + 2)
            {
                Console.Write($"|{x}|");
            }

                Console.ReadKey();
        }
    }
}
