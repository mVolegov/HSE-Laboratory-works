using System.Text;
public static class Task1 
{
    public static char[][] CreateArray()
    {
        // Создание массива
        int rowsJagged = Handler.CheckInput("\nВведите количество строк: ", 
                            "\nМассив не должен иметь отрицательное или нулевое количество строк!",
                            input => input > 0);

        char[][] arrJagged = new char[rowsJagged][];

        // Заполнение массива
        int option = Handler.CheckInput("\nВарианты: \n"
                + "1. С клавиатуры \n"
                + "2. ДСЧ \n"
                + " : ", 
                "Такого варианта нет!", 
                input => (input == 1 || input == 2));

        string chars = "0123456789abcdefghijklmnopqrstuvwxyz";
        StringBuilder builder = new StringBuilder();

        Console.WriteLine();
        switch (option) {
            case 1:
                for (int i = 0; i < rowsJagged; i++)
                {
                    Console.Write(i + " массив : ");
                    string str = Console.ReadLine()!;
                    arrJagged[i] = str.ToCharArray();
                }

                break;
            case 2:
                for (int i = 0; i < rowsJagged; i++)
                {
                    int length = (new Random()).Next(1, 10);

                    for (int j = 0; j < length; j++)
                        builder.Append(chars[(new Random()).Next(chars.Length)]);
            
                    string str = builder.ToString();
                    builder.Clear();
                    arrJagged[i] = str.ToCharArray();
                }
                
                break;
        }

        return arrJagged;
    }

    public static void Delete(ref char[][] arr) 
    {
        // Поиск строки по условию
        int lineIndex = -1;

        for (int i = 0; i < arr.Length; i++)
        {
            int vowelCounter = 0;

            for (int j = 0; j < arr[i].Length; j++)
            {
                arr[i][j] = char.ToLower(arr[i][j]);

                if (arr[i][j] == 'a'
                    || arr[i][j] == 'e'
                    || arr[i][j] == 'i'
                    || arr[i][j] == 'o'
                    || arr[i][j] == 'u'
                    || arr[i][j] == 'y') 
                
                    vowelCounter++;
            }

            if (vowelCounter >= 3)
            {
                lineIndex = i;
                break;
            }
        }

        // Проверка на наличие 
        if (lineIndex == -1) 
        {
            Console.WriteLine("\nВ массиве нет строк, удовлетворяющих условию!");
            return;
        }

        // Удаление строки из массива
        char[][] modifiedArr = new char[arr.Length - 1][];

        // Сдвиг
        int k = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i != lineIndex)
            {
                modifiedArr[k++] = arr[i];
            }
        }

        arr = modifiedArr;
    }

    public static void PrintArray(char[][] arr, string message) {
        Console.WriteLine(message);

        for (int i = 0; i < arr.Length; i++) 
        {
            Console.Write("[");
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write(arr[i][j]);
            }
            Console.WriteLine("]");
        }
    }
}