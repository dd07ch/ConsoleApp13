using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Reverse(int n, int result = 0)
            {
                // Базов случай: ако числото е 0, връщаме резултата
                if (n == 0)
                {
                    return result;
                }

                // Вземаме последната цифра на числото и добавяме към резултата
                return Reverse(n / 10, result * 10 + n % 10);
            }
        }

        private static void Main1()
        {
            // Пример
            int number = 1234;
            int reversed = Reverse(number);
            Console.WriteLine(reversed);  // Изход: 4321
        }

        private static int Reverse(int number)
        {
            throw new NotImplementedException();
        }
    }
}
        

        

