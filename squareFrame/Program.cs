using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Top
            Console.Write("+ ");
            for (int row = 0; row < n-2; row++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");
            //Mid
            for (int row = 0; row < n - 2; row++)
            {
                Console.Write("| ");
                for (int i = 0; i < n-2; i++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("|");
            }
            //Bot
            Console.Write("+ ");
            for (int row = 0; row < n - 2; row++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");
        }
    }
}
