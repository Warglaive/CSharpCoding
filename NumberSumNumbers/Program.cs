using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int newNum = 0;
            int totalNum = 0;
            int delLastNUm = 0;
            for (int row = 0; row < num; row++)
            {
                newNum = num % 10;
                delLastNUm = num / 10;
            }
            totalNum = totalNum + newNum;
            Console.WriteLine(newNum);
        }
    }
}
