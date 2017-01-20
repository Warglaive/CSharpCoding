using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //UpperLine
            for (int row = 1; row <= n * 2; row++)
            {
                Console.Write("*");
            }
            for (int row = 0; row < n; row++)
            {
                Console.Write(" ");
            }
            for (int row = 1; row <= n * 2; row++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            //twoMiddleLines
            for (int i = 0; i < n-2; i++)
            {
                Console.Write("*");
                for (int row = 0; row < 2*n - 2; row++)
                {
                    Console.Write("/");
                }
                Console.Write("*");
                if (i == (n - 1) / 2 - 1)
                {
                    for (int row = 0; row < n; row++)
                    {
                        Console.Write("|");
                    }
                }
                else
                {
                    for (int row = 0; row < n; row++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("*");
                for (int row = 0; row < 2 * n - 2; row++)
                {
                    Console.Write("/");
                }
                Console.Write("*");
                Console.WriteLine();
            }
            //BotLines
            for (int row = 1; row <= n * 2; row++)
            {
                Console.Write("*");
            }
            for (int row = 0; row < n; row++)
            {
                Console.Write(" ");
            }
            for (int row = 1; row <= n * 2; row++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
