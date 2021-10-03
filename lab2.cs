using System;

namespace ConsoleApp1
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nЛабораторная работа 2, вариант 3");


            Console.WriteLine("\nЗадача 1 (3)");
            
            int sum = 0;
            
            int nTask1 = CheckInputSequenceLenght("n=");
            
            int _a = CheckInputElementInSequence("a1=");
            
            for (int i = 2; i <= nTask1; i++)
            {
                _a = CheckInputElementInSequence($"a{i}=");
            
                if (i % 2 == 0) sum += _a;
            }
            
            Console.WriteLine($"Сумма элементов с четными номерами={sum}");
            
            
            Console.WriteLine("\nЗадача 2 (32)");
            
            int counter = 0;
            int j = 1;
            
            int _b = CheckInputElementInSequence("1 элемент в последовательности=");
            
            int firstElem = _b;
            
            while (_b != 0)
            {
                j++;
            
                _b = CheckInputElementInSequence($"{j} элемент в последовательности=");
            
                if (_b % firstElem == 0 && _b != 0)
                {
                    counter++;
                }
            }
            
            Console.WriteLine($"Количество элементов, кратных первому элементу={counter}");

            
            Console.WriteLine("\nЗадача 3 (37)");

            int item = 0;
            int row = 0;

            int nTask3 = CheckInputSequenceLenght("n=");

            Console.Write("S=");

            do
            {
                item++;

                if (item % 3 == 0)
                {
                    row -= item;
                    Console.Write("-" + item);
                }
                else
                {
                    row += item;
                    Console.Write("+" + item);
                }
            } while (item < nTask3);

            Console.WriteLine($"={row}");
        }

        static int CheckInputSequenceLenght(string message)
        {
            bool isValidInput;
            int n;

            do
            {
                Console.Write(message);
                isValidInput = int.TryParse(Console.ReadLine(), out n);

                if (!isValidInput)
                {
                    Console.WriteLine("Вы ввели некорректные данные!");
                }
                else if (n < 0)
                {
                    Console.WriteLine("Количество элементов в последовательности не может быть отрицательным!");
                    isValidInput = false;
                }
                else if (n == 0)
                {
                    Console.WriteLine("Пустая последовательность!");
                    isValidInput = false;
                }
            } while (!isValidInput);

            return n;
        }

        static int CheckInputElementInSequence(string message)
        {
            bool isValidInput;
            int _element;

            do
            {
                Console.Write(message);
                isValidInput = int.TryParse(Console.ReadLine(), out _element);

                if (!isValidInput)
                {
                    Console.WriteLine("Вы ввели некорректные данные!");
                }
            } while (!isValidInput);

            return _element;
        }
    }
}
