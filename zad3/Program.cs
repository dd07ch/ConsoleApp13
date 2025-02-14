using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число:");
            int n = int.Parse(Console.ReadLine());

            if (IsPowerOfTwo(n))
            {
                Console.WriteLine($"{n} е степен на 2.");
            }
            else
            {
                Console.WriteLine($"{n} не е степен на 2.");
            }
        }

        static bool IsPowerOfTwo(int n)
        {
            if (n == 1)
            {
                return true;
            }

            if (n <= 0 || n % 2 != 0)
            {
                return false;
            }

            return IsPowerOfTwo(n / 2);
        }
    }
}
  
