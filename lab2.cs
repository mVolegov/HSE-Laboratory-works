using System;

namespace ConsoleApp1
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа 2, вариант 3");
            
            
            Console.WriteLine("\nЗадача 1 (3)");

            int nTask1;
            double _a;
            double sum = 0;
            bool isValidInput;
            
            do
            {
                Console.Write("Введите n:");
                isValidInput = int.TryParse(Console.ReadLine(), out nTask1);
                
                if (!isValidInput)
                {
                    Console.WriteLine("Вы ввели некорректные данные!");
                }
                else if (nTask1 < 0)
                {
                    Console.WriteLine("Количество элементов в последовательности не может быть отрицательным!");
                    isValidInput = false;
                } else if (nTask1 == 0)
                {
                    Console.WriteLine("Пустая последовательность!");
                    isValidInput = false;
                }
            } while (!isValidInput);
            
            do
            {
                Console.Write($"a1=");
                isValidInput = double.TryParse(Console.ReadLine(), out _a);

                if (!isValidInput)
                {
                    Console.WriteLine("Вы ввели некорректные данные!");
                }
            } while (!isValidInput);
            
            for (int i = 2; i <= nTask1; i++)
            {
                do
                {
                    Console.Write($"a{i}=");
                    isValidInput = double.TryParse(Console.ReadLine(), out _a);

                    if (!isValidInput)
                    {
                        Console.WriteLine("Вы ввели некорректные данные!");
                    }
                } while (!isValidInput);

                if (i % 2 == 0) sum += _a;
            }
            
            Console.WriteLine($"Сумма элементов с четными номерами={sum:0.00}");

            
            Console.WriteLine("\nЗадача 2 (32)");

            double _b;
            int counter = 0;
            int j = 1;
            
            do
            {
                Console.Write("1 число в последовательности=");
                isValidInput = double.TryParse(Console.ReadLine(), out _b);

                if (!isValidInput)
                {
                    Console.WriteLine("Вы ввели некорректные данные!");
                }
            } while (!isValidInput);

            double firstElem = _b;
            
            while (_b != 0)
            {
                j++;
                
                do
                {
                    Console.Write($"{j} элемент в последовательности=");
                    isValidInput = double.TryParse(Console.ReadLine(), out _b);

                    if (!isValidInput)
                    {
                        Console.WriteLine("Вы ввели некорректные данные!");
                    }
                } while (!isValidInput);

                if (_b % firstElem == 0 && _b != 0)
                {
                    counter++;
                }
            }
            
            Console.WriteLine($"Количество элементов, кратных первому элементу={counter}");
            
                
            Console.WriteLine("\nЗадача 3 (37)");

            int nTask3;
            int itemCounter = 0;
            int itemGenerator = 0;
            int row = 0;

            do
            {
                Console.Write("Введите n:");
                isValidInput = int.TryParse(Console.ReadLine(), out nTask3);

                if (!isValidInput)
                {
                    Console.WriteLine("Вы ввели некорректные данные!");
                } else if (nTask3 < 0)
                {
                    Console.WriteLine("Количество элементов в последовательности не может быть отрицательным!");
                    isValidInput = false;
                } else if (nTask3 == 0)
                {
                    Console.WriteLine("Пустая последовательность!");
                    isValidInput = false;
                }
            } while (!isValidInput);
            
            do
            {
                itemCounter++;
                itemGenerator++;
                
                if (itemCounter % 3 == 0)
                {
                    row -= itemGenerator;
                }
                else
                {
                    row += itemGenerator;
                }
            } while (itemCounter < nTask3);
            
            Console.WriteLine($"Последовательность={row}");
        }
    }
}