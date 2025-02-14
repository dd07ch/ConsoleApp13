using System;

internal static class ProgramHelpers
{
    static void Main(string[] args)
    {
        static int Reverse(int n, int result = 0)
        {
            // Базов случай: ако числото е 0, връщаме резултата
            if (n == 0)
            {
                return result;
            }

            // Вземаме последната цифра на числото и добавяме към резултата
            return Reverse(n / 10, result * 10 + n % 10);
        }

        static void Main()
        {
            // Пример
            int number = 1234;
            int reversed = Reverse(number);
            Console.WriteLine(reversed);  // Изход: 4321
        }
    }
}