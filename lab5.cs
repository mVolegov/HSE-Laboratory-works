using System;

namespace Lab5 
{
    public static class Programm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа 5, вариант 3");

            bool isExit = false;

            do 
            {
                int choice = CheckInput("Действия: \n"
                    + "1. Работа с двумерным массивом \n"
                    + "2. Работа с рваным массивом \n"
                    + "3. Выход \n"
                    + " : ", 
                    "Такой опции нет!", 
                    input => (input >= 1 && input <= 3));

                switch (choice)
                {
                    case 1:
                        /*Создание двумерного массива*/
                        int rows = CheckInput("Введите количество строк: ", 
                            "Массив не должен иметь отрицательное или нулевое количество строк!", 
                            input => input > 0);

                        int columns = CheckInput("Введите количество столбцов: ", 
                            "Массив не должен иметь отрицательное или нулевое количество столбцов!", 
                            input => input > 0);

                        int[,] twoDimensionArray = Create(rows, columns);
                        Print(twoDimensionArray, "Созданный двумерный массив:");

                        /*Добавление строки в конец матрицы*/
                        int[,] twoDimensionArraySupplemented = Work(twoDimensionArray);
                        Print(twoDimensionArraySupplemented, "Массив после добавлений:");

                        break;
                    case 2:
                        /*Создание рваного массива*/
                        int[][] juggedArray = Create();
                        Print(juggedArray, "Созданный рваный массив:");

                        /*Удаление всех строк, в которых встречаются нули*/
                        int[][] juggedArrayModified = Work(juggedArray);
                        Print(juggedArrayModified, "Рваный массив после удалений: ");
                        
                        break;
                    case 3:
                        isExit = true;

                        break;
                }
            } while (!isExit);
        }

        public static int[,] Create(int sizeRow, int sizeColumn)
        {
            Console.WriteLine("Создание двумерного массива:");
            
            int[,] arr = new int[sizeRow, sizeColumn];

            int option = CheckInput("Варианты: \n"
            + "1. С клавиатуры \n"
            + "2. ДСЧ \n"
            + " : ", 
            "Такого варианта нет!", 
            input => (input == 1 || input == 2));

            switch (option)
            {
                case 1:
                    for (int i = 0; i < sizeRow; i++)
                    {
                        for (int j = 0; j < sizeColumn; j++)
                        {
                            arr[i, j] = CheckInput("Элемент[" + i + "]" + "[" + j + "] : ", 
                            "",
                            input => true);
                        }
                    }

                    break;
                case 2:
                    Random rnd = new Random();

                    for (int i = 0; i < sizeRow; i++)
                    {
                        for (int j = 0; j < sizeColumn; j++)
                        {
                            arr[i, j] = rnd.Next(0, 10);
                        }
                    }

                    break;
            }

            return arr;
        }

        public static int[][] Create()  // Jagged
        {
            /*Инициализация массива*/ 
            int rowsJagged = CheckInput("Введите количество строк: ", 
            "Массив не должен иметь отрицательную или нулевую длину!", 
            input => input > 0);

            int[][] arrJagged = new int[rowsJagged][];

            for (int i = 0; i < rowsJagged; i++)
            {
                int columnsJagged = CheckInput("Введите количество столбцов для " + i + " строки: ", 
                "Размер внутреннего массива не должен иметь отрицательную или нулевую длину!", 
                input => input > 0);

                arrJagged[i] = new int[columnsJagged];  
            }

            /*Заполнение массива*/
            int option = CheckInput("Варианты: \n"
            + "1. С клавиатуры \n"
            + "2. ДСЧ \n"
            + " : ", 
            "Такого варианта нет!", 
            input => (input == 1 || input == 2));

            switch (option)
            {
                case 1:
                    for (int i = 0; i < rowsJagged; i++)
                    {
                        for (int j = 0; j < arrJagged[i].Length; j++)
                        {
                            arrJagged[i][j] = CheckInput("Элемент[" + i + "]" + "[" + j + "] : ", 
                            "",
                            input => true);
                        }
                    }

                    break;
                case 2:
                    Random rnd = new Random();

                    for (int i = 0; i < rowsJagged; i++)
                    {
                        for (int j = 0; j < arrJagged[i].Length; j++)
                        {
                            arrJagged[i][j] = rnd.Next(0, 10);
                        }
                    }

                    break;
            }

            return arrJagged;
        }

        public static int[,] Work(int[,] arr)
        {
            int[,] arrSupplemented = new int[(arr.GetLength(0) + 1), arr.GetLength(1)];

            // Копирование старых элементов
            Array.Copy(arr, arrSupplemented, arr.Length);

            // Выбор варианта ввода новой строки
            int option = CheckInput("Варианты: \n"
            + "1. С клавиатуры \n"
            + "2. ДСЧ \n"
            + " : ", 
            "Такой опции нет!", 
            input => (input == 1 || input == 2));

            // Добавление новой строки
            Random rnd = new Random();

            for (int i = arr.GetLength(0); i < arr.GetLength(0) + 1; i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (option == 1) 
                    {
                        arrSupplemented[i, j] = CheckInput("Элемент[" + i + "]" + "[" + j + "] : ", 
                            "",
                            input => true);
                    }
                    else 
                    {
                        arrSupplemented[i, j] = rnd.Next(0, 10);
                    }
                }
            }

            return arrSupplemented;
        }

        public static int[][] Work(int[][] arr)
        {
            int[][] temp = new int[arr.Length][];
            int tempIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (!(arr[i].Contains(0)))
                {
                    temp[tempIndex] = arr[i];
                    tempIndex++;
                }
            }

            int[][] arrJaggedMod = new int[tempIndex][];

            for (int i = 0; i < tempIndex; i++)
            {
                arrJaggedMod[i] = temp[i];
            }

            return arrJaggedMod;
        }

        public static void Print(int[,] arr, string str)  // Matrix
        {
            Console.WriteLine(str);

            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                
                Console.WriteLine();
            }
        }

        public static void Print(int[][] arr, string str)
        {
            Console.WriteLine(str);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }

                Console.WriteLine();
            }
        }

        public static int CheckInput(string message, string errorMessage, Predicate<int> func)
        {
            int num;
            bool isValidInput;

            do
            {
                Console.Write(message);
                isValidInput = int.TryParse(Console.ReadLine(), out num);

                if (!isValidInput)
                {
                    Console.WriteLine("Вы ввели некорректные данные!");
                }
                else if (!(func(num)))
                {
                    Console.WriteLine(errorMessage);
                    isValidInput = false;
                }
            } while (!isValidInput);

            return num;
        }
    }
}