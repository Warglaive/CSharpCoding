using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10x10Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                Console.Write("$");
                for (int col = 0; col < row - 1; col++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }
        }
    }
}