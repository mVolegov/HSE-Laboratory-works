public static class Handler
{
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
                Console.WriteLine("\nВы ввели некорректные данные!");
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