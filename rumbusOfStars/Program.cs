using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rumbusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Up
            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', n - row));
                Console.Write("*");
                for (int col = 0; col < row - 1; col++) 
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            //Bot
            for (int row = 1; row < n; row++)
            {
                Console.Write(new string(' ', row));
                for (int i = 1; i <= n - row; i++)
                {
                    Console.Write("* ");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
