using System;

namespace Lab4Var3modified
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа 4, вариант 3");
            
            int[] arr;
            int size = 0;

            /*Создание массива*/
            Create(out arr, out size);
            PrintArray(arr, "Созданный массив");

            bool isExit = false;

            do {
                int choice;
                bool isValidInput;

                do
                {
                    Console.Write("Действия: \n"
                    + "1. Удалить элементы с заданным номером \n"
                    + "2. Добавить \n"
                    + "3. Сдвинуть циклически на M элементов влево \n"
                    + "4. Последовательный поиск элемента \n"
                    + "5. Сортировка + Бинарный поиск \n"
                    + "6. Быстрая сортирока\n"
                    + "7. Сортировка подсчетом\n"
                    + "8. Выход \n"
                    + " : ");

                    isValidInput = int.TryParse(Console.ReadLine(), out choice);

                    if (!isValidInput)
                    {
                        Console.WriteLine("Вы ввели некорректные данные!");
                    }
                    else if (!(choice >= 1 && choice <=8))
                    {
                        Console.WriteLine("Такой опции нет!");
                    }
                } while (!isValidInput);

                switch (choice)
                {
                    case 1:
                        /*Удаление элемента с заданным номером*/
                        Console.Clear();
                        PrintArray(arr, "Исходный массив:");
                        Delete(ref arr, ref size);
                        PrintArray(arr, "Массив после удалений:");

                        break;
                    case 2:
                        /*Добавление N элементов, начиная с номера K*/
                        Console.Clear();
                        PrintArray(arr, "Исходный массив:");
                        Add(ref arr, ref size);
                        PrintArray(arr, "Массив после добавлений:");

                        break;
                    case 3:
                        /*Циклический сдвиг на M элементов влево*/
                        Console.Clear();
                        PrintArray(arr, "Исходный массив:");
                        Rearrange(ref arr, ref size);
                        PrintArray(arr, "Массив после перестановок");

                        break;
                    case 4:
                        /*Поиск элемента с заданным ключом (значением)*/
                        Console.Clear();
                        PrintArray(arr, "Исходный массив:");
                        Console.WriteLine(SequentialSearch(arr, size));

                        break;
                    case 5:
                        /*Сортировка простым включенем*/
                        Console.Clear();
                        PrintArray(arr, "Исходный массив:");
                        InsertionSort(ref arr, ref size);
                        PrintArray(arr, "Массив после сортировки простой вставкой:");

                        /*Бинарный поиск*/
                        Console.WriteLine(BinarySearch(arr, size));

                        break;
                    case 6:
                        /*Быстрая сортировка*/
                        Console.Clear();
                        PrintArray(arr, "Исходный массив:");
                        QuickSort(ref arr, 0, size - 1);
                        PrintArray(arr, "Массив после быстрой сортировки:");

                        break;
                    case 7:
                        /*Сортировка подсчетом*/
                        Console.Clear();
                        PrintArray(arr, "Исходный массив:");
                        CountingSort(ref arr, ref size);
                        PrintArray(arr, "Массив после сортировки подсчетом:");

                        break;
                    case 8:
                        isExit = true;

                        break;
                }
            } while (!isExit);
        }

        static void Create(out int[] arr, out int size)
        {
            bool isValidInput;
            
            Console.WriteLine("Создание массива");
            
            /*Ввод длины массива*/
            do   
            {
                Console.Write("Введите размер массива: ");
                isValidInput = int.TryParse(Console.ReadLine(), out size);

                if (!isValidInput)
                {
                    Console.WriteLine("Вы ввели некорректные данные!");
                }
                else if (size <= 0)
                {
                    Console.WriteLine("Массив не должен иметь отрицательную или нулевую длину!");
                    isValidInput = false;
                }
            } while (!isValidInput);

            arr = new int[size];
            
            Console.WriteLine("Варианты создания массива:\n1. С клавиатуры\n2. ДСЧ");

            int option;
            
            /*Ввод варианта формирования массива*/
            do   
            {
                Console.Write("Вариант ввода: ");
                isValidInput = int.TryParse(Console.ReadLine(), out option);

                if (!isValidInput)
                {
                    Console.WriteLine("Вы ввели некорректные данные!");
                } 
                else if (!(option == 1 || option == 2))
                {
                    Console.WriteLine("Такого варианта нет! ");
                    isValidInput = false;
                }
            } while (!isValidInput);
            
            switch (option)
            {
                case 1:
                    for (int i = 0; i < size; i++)
                    {
                        arr[i] = CheckInputElementArray(i);
                    }

                    break;
                case 2:
                    Random rnd = new Random();
                    
                    for (int i = 0; i < size; i++)
                    {
                        arr[i] = rnd.Next(0, 10);
                    }

                    break;
            }
        }

        static void Delete(ref int[] arr, ref int size)
        {
            int elementIndexToDelete;
            bool isValidInput;
            
            // /*Удалить*/
            // if (size == 0)
            // {
            //     Console.WriteLine("Массив пустой!");
            //     return ;
            // }
            // /*Удалить*/

            /*Ввод индекса элемента на удаление*/
            do   
            {
                Console.Write("Введите индекс элемента на удаление: ");
                isValidInput = int.TryParse(Console.ReadLine(), out elementIndexToDelete);

                if (!isValidInput)
                {
                    Console.WriteLine("Вы ввели некорректные данные");
                }
                else if (elementIndexToDelete > size - 1 || elementIndexToDelete < 0)
                {
                    Console.WriteLine("Элемента с таким индексом нет в массиве!");
                    isValidInput = false;
                }
            } while (!isValidInput);

            for (int i = elementIndexToDelete; i < size - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            arr[size - 1] = 0;

            int[] arrModified = new int[size - 1];

            for (int i = 0; i < size - 1; i++)
            {
                arrModified[i] = arr[i];
            }

            arr = arrModified; 

            size--;
        }
        
        static void Add(ref int[] arr, ref int size)
        {
            int n;
            int k;
            bool isValidInput;

            /*Ввод n*/
            do 
            {
                Console.Write("Введите n: ");
                isValidInput = int.TryParse(Console.ReadLine(), out n);

                if (!isValidInput)
                {
                    Console.WriteLine("Вы ввели некорректные данные!");
                }
                else if (n < 0)
                {
                    Console.WriteLine("Вы хотите добавить отрицательное количество элементов!");
                    isValidInput = false;
                }
            } while (!isValidInput);
            
            /*Ввод k*/
            do 
            {
                Console.Write("Введите k: ");
                isValidInput = int.TryParse(Console.ReadLine(), out k);

                if (!isValidInput)
                {
                    Console.WriteLine("Вы ввели некорректные данные!");
                }
                else if (k < 0 || k > size)
                {
                    Console.WriteLine("Такого номера элемента нет в массиве!");
                    isValidInput = false;
                }
            } while (!isValidInput);

            int[] arrSupplemented = new int[size + n];

            /*Копирование старых элементов*/
            for (int i = 0; i < size; i++)   
            {
                arrSupplemented[i] = arr[i];
            }

            /*Сдвиг массива*/
            for (int cnt = 0; cnt < n; cnt++)   
            {
                int tmp = arrSupplemented[size + n - 1];

                for (int j = size + n - 1; j > k; j--)
                {
                    arrSupplemented[j] = arrSupplemented[j - 1];
                }

                arrSupplemented[k] = tmp;
            }

            for (int i = k; i < (k + n); i++)
            {
                arrSupplemented[i] = CheckInputElementArray(i);
            }

            size += n;

            arr = arrSupplemented;
        }
        
        static void Rearrange(ref int[] arr, ref int size)
        {
            int m;
            int tmp;
            bool isValidInput;

            /*Ввод M*/
            do 
            {
                Console.Write("Введите m: ");
                isValidInput = int.TryParse(Console.ReadLine(), out m);

                if (!isValidInput)
                {
                    Console.WriteLine("Вы ввели некорректные данные!");
                }
                else if (m < 0)
                {
                    Console.WriteLine("m - отрицательное число!");
                    isValidInput = false;
                }
            } while (!isValidInput);
            
            for (int i = 0; i < m; i++)
            {
                tmp = arr[0];

                for (int j = 0; j < size - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }

                arr[size - 1] = tmp;
            }
        }
        
        static string SequentialSearch(int[] arr, int size)
        {
            int key;
            bool isValidInput;

            /*Ввод ключа для поиска*/
            do 
            {
                Console.Write("Введите ключ: ");
                isValidInput = int.TryParse(Console.ReadLine(), out key);

                if (!isValidInput)
                {
                    Console.WriteLine("Вы ввели некорректные данные!");
                }
            } while (!isValidInput);

            int iterationCounter = 0;

            for (int i = 0; i < size; i++)
            {
                iterationCounter++;

                if (arr[i] == key)
                {
                    return "Элемент " + key + " находится на " + i + " позиции" + "\n"
                            + "Для нахождения элемента понадобилось " + iterationCounter + " итераций";
                }
            }
            
            return "Элемента нет в последовательности";
        }
        
        static void InsertionSort(ref int[] arr, ref int size)
        {
            for (int i = 1; i < size; i++)
            {
                int current = arr[i];
                int j = i;
                
                while (j > 0 && arr[j - 1] > current)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }

                arr[j] = current;
            }
        }  /*O(n^2)*/

        static string BinarySearch(int[] arr, int size) 
        {
            bool isValidInput;
            int key;

            do {
                Console.Write("Введите ключ: ");
                isValidInput = int.TryParse(Console.ReadLine(), out key);

                if (!isValidInput)
                {
                    Console.WriteLine("Вы ввели некорректные данные!");
                }
            } while (!isValidInput);

            int iterationCounter = 0;

            int high = size - 1;
            int low = -1;

            while (high - low > 1)
            {
                iterationCounter++;

                int mid = (high + low) / 2;

                if (arr[mid] >= key)
                {
                    high = mid;
                }
                else
                {
                    low = mid;
                } 
            }

            if (arr[high] == key)
            {
                return "Элемент " + key + " находится на " + high + " позиции" + "\n"
                    + "Для нахождения элемента понадобилось " + iterationCounter + " итераций";
            }
            else
            {
                return "В последовательности нет элемента " + key;
            }
        }

        static void QuickSort(ref int[] arr, int leftBorder, int rightBorder)
        {
            int leftMarker = leftBorder;
            int rightMarker = rightBorder;
            int pivot = arr[(leftMarker + rightMarker) / 2];

            do
            {
                while (arr[leftMarker] < pivot)
                {
                    leftMarker++;
                }

                while (arr[rightMarker] > pivot)
                {
                    rightMarker--;
                }

                if (leftMarker < rightMarker)
                {
                    int tmp = arr[leftMarker];
                    arr[leftMarker] = arr[rightMarker];
                    arr[rightMarker] = tmp;
                }

                leftMarker++;
                rightMarker--;
            } while (leftMarker <= rightMarker);

            if (leftMarker < rightBorder)
            {
                QuickSort(ref arr, leftMarker, rightBorder);
            }

            if (leftBorder < rightMarker)
            {
                QuickSort(ref arr, leftBorder, rightMarker);
            }
        }  /*O(n * log n)*/

        static void CountingSort(ref int[] arr, ref int size)
        {
            int maxValue = arr[0];

            for (int i = 0; i < size; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
            }

            int[] count = new int[maxValue + 1];

            for (int i = 0; i < size; i++)
            {
                count[arr[i]]++;
            }

            int arrIndex = 0;

            for (int i = 0; i < maxValue + 1; i++)
            {
                for (int j = 0; j < count[i]; j++)
                {
                    arr[arrIndex] = i;
                    arrIndex++;
                }
            }
        }  /*O(n + k), n - кол-во эл. в массиве, k - макс. значение эл.*/

        static void PrintArray(int[] arr, string str)
        {
            Console.WriteLine(str);
            
            foreach (var element in arr)
            {
                Console.Write(element + " ");
            }
            
            Console.WriteLine("");
        }

        static int CheckInputElementArray(int cnt)
        {
            int _a;
            bool isValidInput;

            do
            {
                Console.Write($"Введите {cnt} элемент: ");
                isValidInput = int.TryParse(Console.ReadLine(), out _a);

                if (!isValidInput)
                {
                    Console.WriteLine("Вы ввели некорректные данные!");
                }
            } while (!isValidInput);
            
            return _a;
        }
    }
}