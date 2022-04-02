public static class Program
{
    public static void Main(string[] args)
    {   
        Console.WriteLine("Лабораторная работа 6, вариант 3"); 

        bool isExit = false;

        do {
            int choice = Handler.CheckInput("\nДействия: \n"    
                            + "1. Задача 1 \n"
                            + "2. Задача 2 \n"
                            + "3. Дополнительная задача \n"
                            + "4. Выход \n"
                            + " : ", 
                            "Такой опции нет!", 
                            input => (input >= 1 && input <= 4));

            switch(choice)
            {
                case 1:
                    char[][] arr = Task1.CreateArray();
                    Task1.PrintArray(arr, "Созданный массив");
                    Task1.Delete(ref arr);
                    Task1.PrintArray(arr, "\nМассив после удалений");

                    break;
                case 2:
                    String data = Task2.CreateString();
                    string identifier = Task2.Find(data);
                    
                    if (identifier.Equals("")) Console.WriteLine("\nВ строке нет идентификатора!");
                    else Console.WriteLine("\nСамый длинный идентификатор: " + identifier);

                    break;
                case 3:
                    String[] urlsToCheck = {"http://www.zcontest.ru", 
                                    "http://zcontest.ru",
                                    "http://zcontest.com",
                                    "https://zcontest.ru",
                                    "https://sub.zcontest-ru.com:8080",
                                    "http://zcontest.ru/dir%201/dir_2/program.ext?var1=x&var2=my%20value",
                                    "zcon.com/index.html#bookmark",
                                    "Just Text.",
                                    "http://a.com",
                                    "http://www.domain-.com"};
                    
                    foreach (string url in urlsToCheck)
                        if (AdditionalTask.IsMatchUrl(url)) Console.WriteLine(url + " : да");
                        else Console.WriteLine(url + " : нет");

                    break;
                case 4:
                    isExit = true;

                    break;
            }
        } while (!isExit);
    }
}