using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)

        {
            var n = int.Parse(Console.ReadLine());
            var starsCount = 1;
            //Roof
            var roofRows = (n + 1) / 2;
            if (n % 2 == 0) 
            {
                starsCount = 2;
            }
            for (int row = 0; row < roofRows; row++)
            {
                var linesCount = (n - starsCount) / 2;
                Console.Write(new string('-', linesCount));
                Console.Write(new string('*', starsCount));
                Console.WriteLine(new string('-', linesCount));
                starsCount = starsCount + 2;
            }
            //Base
            for (int row = 0; row < n / 2; row++) 
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.WriteLine("|");
            }
        }
    }
}
