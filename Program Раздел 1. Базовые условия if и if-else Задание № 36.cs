using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program36
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Двузначное число: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n >= 10 && n <= 99)
            {
                int tens = n / 10;
                int ones = n % 10;

                if (tens > ones)
                    Console.WriteLine($"Больше цифра десятков: {tens}");
                else if (ones > tens)
                    Console.WriteLine($"Больше цифра единиц: {ones}");
                else
                    Console.WriteLine("Цифры равны.");
            }
            else
            {
                Console.WriteLine("Ошибка: введите двузначное число (10–99).");
            }
        }
    }
}