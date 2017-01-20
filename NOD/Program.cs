using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Взимаш 2 входа, докато b не е 0, в цикъл b = a % b, a = стара стойност на b.
            // Печатаме a ;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            while(b!=0)
            {
                var oldB = b;
                b = a % b;
                a = oldB;
            }
            Console.WriteLine(a);
        }
    }
}
