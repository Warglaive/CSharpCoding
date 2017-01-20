using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberInRange1To100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Еnter a number in the range [1...100]: ");
            int newNumber = 0;
            int enteredNumber = int.Parse(Console.ReadLine());
            while (enteredNumber < 1 || enteredNumber > 100)
            {
                Console.WriteLine("invalid number!");
                newNumber = int.Parse(Console.ReadLine());
                if (newNumber >= 1 && newNumber <= 100)
                {
                    Console.WriteLine("entered number: {0}", newNumber);
                    break;
                }
            }
            if (enteredNumber >= 1 && enteredNumber <= 100)
            {
                Console.WriteLine("entered number: {0}", enteredNumber);
                
            }
        }
    }
}
