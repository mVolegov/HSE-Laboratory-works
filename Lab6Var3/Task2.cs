public static class Task2
{
    public static string CreateString()
    {
        string[] strArr = {"He'y bro, ho# __r __u doing? OH!; __U A$$KING ME??  __I _am abs0lutely fine...",
                                "Hello. Obvio:usly, this is the string;   with the smallest identificat*r - A!",
                                "This,, is aaa   sentenc^e... with aaa baaad! wo+d:    0DUMMYBOYYYY0",
                                "1This 2is 3a 4sentence 5without 6normal 7words 8!",
                                "int switch for asdfg"};

        int option = Handler.CheckInput("\nВарианты: \n"
                + "1. С клавиатуры \n"
                + "2. Из существующего набора \n"
                + " : ", 
                "\nТакого варианта нет!", 
                input => (input == 1 || input == 2));
        
        string outputStr = "";

        switch (option)
        {
            case 1:
                Console.Write("Строка: ");
                outputStr = Console.ReadLine()!;

                break;
            case 2:
                int choice = Handler.CheckInput("Введите номер строки: ",
                                                "\nТакого варианта нет!\n", 
                                                input => (input >= 0 && input <= 4));

                outputStr = strArr[choice];

                break;
        }

        return outputStr;
    }

    public static string Find(string input)
    {
        string[] stringArray = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        string maxIdentifier = "";

        for (int i = 0; i < stringArray.Length; i++) 
        {
            if (IsIdentifier(stringArray[i]))
                if (stringArray[i].Length > maxIdentifier.Length)
                    maxIdentifier = stringArray[i];
        }

        return maxIdentifier;
    }

    private static bool IsIdentifier(string word)
    {
        string[] keyWords = {"abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char",
                             "checked", "class", "const", "continue", "decimal", "default", "delegate", 
                             "do", "double", "else", "enum", "event", "explicit", "extern", "false", 
                             "finally", "fixed", "float", "for", "foreach", "goto", "if", "implicit", 
                             "in", "int", "interface", "internal", "is", "lock", "long", "namespace", 
                             "new", "null", "object", "operator", "out", "override", "params", "private", 
                             "protected", "public", "readonly", "ref", "return", "sbyte", "sealed", "short", 
                             "sizeof", "stackalloc", "static", "string", "struct", "switch", "this", "throw", 
                             "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", "using", 
                             "virtual", "void", "volatile", "while"};

        if (keyWords.Contains(word)) return false;

        if (word[0] >= '0' && word[0] <= '9') return false;

        for (int i = 0; i < word.Length; i++)
            if ("!><`;~№:?\"'{}[]=.,/@#$%^&*()-|+".Contains(word[i])) return false;

        return true;
    }
}