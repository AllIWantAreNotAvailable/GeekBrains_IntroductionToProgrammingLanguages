/*
Задача №33
Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/


bool FindValueInArray((int[] array, int value) args)
{
    for (int index = 0; index < args.array.Length; index++)
    {
        if (args.array[index] == args.value) return true;
    }
    return false;
}


(bool, int) UserInput()
{
    (bool check, int value) userInput;
    Console.WriteLine("Введите целочисленное значение для поиска в массиве:\n>>> ");
    userInput.check = int.TryParse(Console.ReadLine()!, out userInput.value);
    return userInput;
}


void PrintArray(int[] arrayToPrint)
{
    Console.WriteLine($"[{String.Join(", ", arrayToPrint)}]");
}


int[] GetRandIntArray((int length, int minValue, int maxValue) args)
{
    int[] array = new int[args.length];
    Random randInt = new Random();
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = randInt.Next(args.minValue, args.maxValue + 1);
    }
    return array;
}


int GetDefaultValues(int caseIndex)
{
    int value;
    switch (caseIndex)
    {
        case 0:
            value = 5;
            break;
        case 1:
            value = 0;
            break;
        case 2:
            value = 999;
            break;
        default:
            value = 0;
            break;
    }
    return value;
}


(int, int, int) GetUserSettings()
{
    (int length, int minValue, int maxValue) userSettings;
    userSettings.length = GetDefaultValues(0);
    userSettings.minValue = GetDefaultValues(1);
    userSettings.maxValue = GetDefaultValues(2);

    Console.Write("Настроить генерацию массива?\n"
                 + "(Press Y for \"yes\" or any key for \"no\")\n"
                 + ">>> ");
    switch (Console.ReadKey().Key)
    {
        case ConsoleKey.Y:
            bool flag;
            Console.WriteLine();
            Console.Write("Введите желаемую длину массива:\n>>> ");
            flag = int.TryParse(Console.ReadLine()!, out userSettings.length);
            if (!flag)
            {
                Console.WriteLine("Не удалось преобразовать строку в число.\n"
                                + "Будет использовано значение по умолчанию.");
                userSettings.length = GetDefaultValues(0);
            }

            Console.Write("Введите минимальное значение для заполнения массива:\n>>> ");
            flag = int.TryParse(Console.ReadLine()!, out userSettings.minValue);
            if (!flag)
            {
                Console.WriteLine("Не удалось преобразовать строку в число.\n"
                                + "Будет использовано значение по умолчанию.");
                userSettings.minValue = GetDefaultValues(1);
            }

            Console.Write("Введите максимальное значение для заполнения массива:\n>>> ");
            flag = int.TryParse(Console.ReadLine()!, out userSettings.maxValue);
            if (!flag)
            {
                Console.WriteLine("Не удалось преобразовать строку в число.\n"
                                + "Будет использовано значение по умолчанию.");
                userSettings.maxValue = GetDefaultValues(2);
            }
            break;
    }
    return userSettings;
}


void Main()
{
    (int length, int minValue, int maxValue) userSettings = GetUserSettings();
    int[] usersArray = GetRandIntArray(userSettings);
    PrintArray(usersArray);
    (bool flag, int searchValue) userInput = UserInput();
    if (userInput.flag)
    {
        string resultOutput = FindValueInArray((array: usersArray,
                                                value: userInput.searchValue))
                            ? "есть в массиве"
                            : "отсутстсвует в массиве";
        System.Console.WriteLine($"{userInput.searchValue} {resultOutput}");
    }
    else
    {
        Console.WriteLine("Не удалось преобразовать строку к числу.");
    }
}


Main();