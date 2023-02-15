/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного
копирования.
*/


void PrintArrayAndItsCopy((int[] originalArray, int[] copyOfArray) args)
{
    Console.WriteLine($"[{String.Join(", ", args.originalArray)}] –> [{String.Join(", ", args.copyOfArray)}]");
}


int[] GetIterativeCopyOfArray(int[] arrayToCopy)
{
    int[] copyOfArray = new int[arrayToCopy.Length];
    for (int index = 0; index < copyOfArray.Length; index++)
    {
        copyOfArray[index] = arrayToCopy[index];
    }
    return copyOfArray;
}


int[] GetFilledRandIntArray((int length, int minValue, int maxValue) args)
{
    int[] array = new int[args.length];
    Random randInt = new Random();
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = randInt.Next(args.minValue, args.maxValue + 1);
    }
    return array;
}


int GetDefaultValues(int valueIndex)
{
    int value;
    switch (valueIndex)
    {
        case 0:
            value = 5;
            break;
        case 1:
            value = 0;
            break;
        case 2:
            value = 10;
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
    bool flag = false;

    Console.Write("Настроить генерацию случайного массива?\n"
                + "(Y for \"yes\" or Any key for \"no\")\n");
    switch (Console.ReadKey().Key)
    {
        case ConsoleKey.Y:
            Console.WriteLine();
            Console.Write("Введите длину массива:\n");
            flag = int.TryParse(Console.ReadLine()!, out userSettings.length);
            if (!flag)
            {
                Console.WriteLine("Не удалось преобразовать строку к числу, \n"
                                + "будет использовано значение по умолчанию.");
                userSettings.length = GetDefaultValues(0);
            }
            Console.Write("Введите минимальное значение для заполнения массива:\n");
            flag = int.TryParse(Console.ReadLine()!, out userSettings.minValue);
            if (!flag)
            {
                Console.WriteLine("Не удалось преобразовать строку к числу, \n"
                                + "будет использовано значение по умолчанию.");
                userSettings.minValue = GetDefaultValues(1);
            }
            Console.Write("Введите максимальное значение для заполнения массива:\n");
            flag = int.TryParse(Console.ReadLine()!, out userSettings.maxValue);
            if (!flag)
            {
                Console.WriteLine("Не удалось преобразовать строку к числу, \n"
                                + "будет использовано значение по умолчанию.");
                userSettings.maxValue = GetDefaultValues(2);
            }
            break;
    }
    return userSettings;

}


void Main()
{
    (int length, int minValue, int maxValue) userSettings = GetUserSettings();
    int[] usersArray = GetFilledRandIntArray(userSettings);
    int[] copyOfUsersArray = GetIterativeCopyOfArray(usersArray);
    PrintArrayAndItsCopy(
                         (
                            originalArray: usersArray,
                            copyOfArray: copyOfUsersArray
                         )
                        );
}


Main();
