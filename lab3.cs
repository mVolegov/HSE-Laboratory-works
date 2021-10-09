using System;

namespace ConsoleApp1
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа 3, вариант 3");

            // Задание констант Эпсилон и n (задаются в условии к задаче)
            const double EPS = 0.0001;
            const int N = 10;
            
            // Вычисление шага изменения X
            const int K = 10;
            double a = 0.1;
            double b = 1.0;
            double step = (b - a) / K;

            for (double x = 0.1; x < 1.0; x += step)
            {
                // Перменные для вычисления радя Маклорена
                // Для заданной точности Эпсилон
                double se = 0;
                int znak = 1;
                double term = x;
                
                // Цикл для заданной точности Эпсилон
                for (int k = 1; ;k++)
                {
                    se += term;
                    term *= -znak * x * x / ((2 * k) * (2 * k + 1));

                    if (Math.Abs(term) < EPS)
                    {
                        break;
                    }
                }
                
                // Перменные для вычисления ряда Маклорена
                // Для заданного N
                double sn = 0;
                term = x;
                znak = 1;

                // Цикл для заранее заданного N
                for (int i = 1; i < N; i++)
                {
                    sn += term;
                    term *= -znak * x * x / ((2 * i) * (2 * i + 1));
                }

                Console.WriteLine($"X={x:f6} SE={se:f6} SN={sn:f6} Y={Math.Sin(x):f6}");
            }
        }
    }
}