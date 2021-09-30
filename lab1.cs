using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Лабораторная работа 1, вариант 3");


                Console.WriteLine("\nЗадача 1:");

                bool isValidInput = false;
                double n;

                do
                {
                    Console.Write("n?");
                    isValidInput = double.TryParse(Console.ReadLine(), out n);
                    if (!isValidInput) Console.WriteLine("Вы ввели некорректные данные! Попробуйте снова");
                } while (!isValidInput);

                double m;

                do
                {
                    Console.Write("m?");
                    isValidInput = double.TryParse(Console.ReadLine(), out m);
                    if (!isValidInput) Console.WriteLine("Вы ввели некорректные данные! Попробуйте снова");
                } while (!isValidInput);

                Console.WriteLine($"m={m} n={n} m--n={m-- - n}");
                Console.WriteLine($"m={m} n={n} m++<n={m++ < n}");
                Console.WriteLine($"m={m} n ={n} n++>m={n++ > m}");

                double x;

                do
                {
                    Console.Write("x?");
                    isValidInput = double.TryParse(Console.ReadLine(), out x);
                    if (!isValidInput)
                    {
                        Console.WriteLine("Вы ввели некорректные данные! Попробуйте снова");
                    }
                    else if (x > 1 || x < -1)
                    {
                        Console.WriteLine("Область определения y = arcsin(x): -1 <= x <= 1");
                        isValidInput = false;
                    }
                } while (!isValidInput);

                Console.WriteLine($"x={x} x^4 - cos(arcsin(x))={Math.Pow(x, 4) - Math.Cos(Math.Asin(x)):0.0000}");


                Console.WriteLine("\nЗадача 2:");

                double xPoint;
                double yPoint;

                do
                {
                    Console.Write("x?");
                    isValidInput = double.TryParse(Console.ReadLine(), out xPoint);
                    if (!isValidInput) Console.WriteLine("Вы ввели некорректные данные! Попробуйте снова");
                } while (!isValidInput);

                do
                {
                    Console.Write("y?");
                    isValidInput = double.TryParse(Console.ReadLine(), out yPoint);
                    if (!isValidInput) Console.WriteLine("Вы ввели некорректные данные! Попробуйте снова");
                } while (!isValidInput);

                Console.WriteLine($"Результат={(Math.Abs(xPoint) / 2 + Math.Abs(yPoint) / 2) <= 1}");


                Console.WriteLine("\nЗадача 3:");

                const int A = 100;
                const double B = 0.001;

                double a1Double = Math.Pow((A + B), 3);
                double a2Double = Math.Pow(A, 3) + 3 * Math.Pow(A, 2) * B;
                double a3Double = 3 * A * Math.Pow(B, 2);
                double a4Double = Math.Pow(B, 2);
                double resDouble = (a1Double - a2Double) / (a3Double + a4Double);
                Console.WriteLine($"Результат для double={resDouble:0.00000000}");

                float a1Float = (float)Math.Pow((A + B), 3);
                float a2Float = (float)(Math.Pow(A, 3) + 3 * Math.Pow(A, 2) * B);
                float a3Float = (float)(3 * A * Math.Pow(B, 2));
                float a4Float = (float)Math.Pow(B, 2);
                float resFloat = (a1Float - a2Float) / (a3Float + a4Float);
                Console.WriteLine($"Результат для float={resFloat}");
            }
        }
    }
}
