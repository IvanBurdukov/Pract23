using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Pract23
{
    class Program
    {
        static async Task<BigInteger> CalculateFactorialAsync(int n)
        {
            if (n < 0)
                throw new ArgumentException("Факториал определен только для неотрицательных целых чисел.");

            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                // Имитация длительной операции
                await Task.Delay(100); // Подождать 100 миллисекунд
            }
            return factorial;
        }

        static async Task Main(string[] args)
        {
            int n = 10; // Число, для которого будем вычислять факториал

            try
            {
                Console.WriteLine($"Вычисление факториала числа {n}...");
                BigInteger result = await CalculateFactorialAsync(n);
                Console.WriteLine($"Факториал числа {n} равен: {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}