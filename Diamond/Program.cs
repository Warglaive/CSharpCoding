using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            Console.WriteLine("the numbers are: ");
            for (int i = 0; i <= n; i=i+3)
            {
                Console.WriteLine(num);
                num = num + 3;
            }
        }
    }
}
