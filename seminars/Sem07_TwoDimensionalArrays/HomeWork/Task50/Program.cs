/*
Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив: 

{
  {1,  4,   7,   2},
  {5,  9,   2,   3},
  {8,  4,   2,   4}
}

17 -> такого числа в массиве нет
*/


void FindElemIn2DArray(int[,] arraySearch)
{
    int countOfRows = arraySearch.GetLength(0);
    int countOfColums = arraySearch.GetLength(1);

    Console.Write("Укажите параметры поиска через запятую или пробел.\n"
                    + "(Например: 2, 3 или 2 3; где первое число – номер строки, второе число – номер столбца)\n"
                    + $"В матрице: строк {countOfRows}; столбцов {countOfColums}.\n>>> ");
    string userInput = Console.ReadLine()!;

    if (userInput.Length == 0)
    { // Если строка пустая (длина строки == 0), то это вызовет отказ программы
        Console.WriteLine("Строка ввода осталась пустой, вы забыли ввести данные? ;(");
        return;
    }

    char[] seporators = new char[] { ',', ' ' };
    string[] userInputSubStrings = userInput.Split(seporators, StringSplitOptions.RemoveEmptyEntries);

    int searchParamsInSubstrings = userInputSubStrings.Length;
    if (searchParamsInSubstrings < 2 || 2 < searchParamsInSubstrings)
    { // Нам необходимо получить от пользователя именно 2 параметра, иначе это вызовет отказ программы
        Console.WriteLine("Для поиска необходимо 2 параметра: номер строки; номер столбца. "
                        + "Введены некорректные данные.");
        return;
    }

    int rowPos, columnPos;
    bool rowParseValid = int.TryParse(userInputSubStrings[0], out rowPos);
    bool columnParseValid = int.TryParse(userInputSubStrings[1], out columnPos);

    if (!rowParseValid || !columnParseValid)
    { // Параметры должны быть указаны цифрами(числами), иначе это вызовет отказ программы
        Console.WriteLine($"Не удалось преобразовать введенные параметры поиска к числу –> ({userInput})");
        return;
    }

    bool outOfIndex = !(0 < rowPos && rowPos < countOfRows)
                    || !(0 < columnPos && columnPos < countOfColums); // Условие вхождения указанных параметров в границы индексов

    // Пользователь не вкурсе правил индексации, от введенных им чисел отнимаем 1
    string outPut = outOfIndex ? "Такого элемента в матрице нет ;(" : "Значение элемента "
                    + $"({rowPos}, {columnPos}) –> {arraySearch[rowPos - 1, columnPos - 1]}";

    Console.WriteLine(outPut);

}


void Print2DArray(int[,] arrayToPrint)
{
    Console.WriteLine();
    Console.WriteLine("Таблица значений:");
    for (int row = 0; row < arrayToPrint.GetLength(0); row++)
    {
        for (int column = 0; column < arrayToPrint.GetLength(1); column++)
        {
            Console.Write($"{arrayToPrint[row, column]}\t");
        }
        Console.WriteLine();
    }
}


int[,] GetFilledRandInt2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] int2DArray = new int[rows, columns];
    Random randInt = new Random();
    for (int row = 0; row < int2DArray.GetLongLength(0); row++)
    {
        for (int column = 0; column < int2DArray.GetLongLength(1); column++)
        {
            int2DArray[row, column] = randInt.Next(minValue, maxValue + 1);
        }
    }
    return int2DArray;
}


int GetDefaultValues(int valueCode)
{
    int defaultValue;
    switch (valueCode)
    {
        case 0:
            defaultValue = 3;
            break;
        case 1:
            defaultValue = 3;
            break;
        case 2:
            defaultValue = -10;
            break;
        case 3:
            defaultValue = 10;
            break;
        default:
            defaultValue = 0;
            break;
    }
    return defaultValue;
}


int[,] SetingsMenu()
{
    int[,] usersSetupsArray;
    Console.Write("Настроить создаваемый двумерный массив?\n(Y for Yes, Any key for No)\n>>> ");
    switch (Console.ReadKey().Key)
    {
        case ConsoleKey.Y:
            Console.WriteLine();
            Console.Write("Введите количество строк двумерного массива:\n>>> ");
            bool rowsValid = int.TryParse(Console.ReadLine()!, out int rows);

            Console.Write("Введите количество столбцов двумерного массива:\n>>> ");
            bool columnsValid = int.TryParse(Console.ReadLine()!, out int columns);

            Console.Write("Введите минимальное значение для заполнения двумерного массива:\n>>> ");
            bool minValid = int.TryParse(Console.ReadLine()!, out int min);

            Console.Write("Введите максимальное значение для заполнения двумерного массива:\n>>> ");
            bool maxValid = int.TryParse(Console.ReadLine()!, out int max);

            if (!rowsValid)
            {
                Console.WriteLine("Не удалось преобразовать введенное количество строк к числу.\n"
                                + "Будет использовано значение по умолчанию");
                rows = GetDefaultValues(0);
            }

            if (!columnsValid)
            {
                Console.WriteLine("Не удалось преобразовать введенное количество столбцов к числу.\n"
                                + "Будет использовано значение по умолчанию");
                columns = GetDefaultValues(1);
            }

            if (!minValid)
            {
                Console.WriteLine("Не удалось преобразовать введенное минимальное значение для заполнения к числу.\n"
                                + "Будет использовано значение по умолчанию");
                min = GetDefaultValues(2);
            }

            if (!maxValid)
            {
                Console.WriteLine("Не удалось преобразовать введенное максимальное значение для заполнения к числу.\n"
                                + "Будет использовано значение по умолчанию");
                max = GetDefaultValues(3);
            }

            usersSetupsArray = GetFilledRandInt2DArray(rows, columns, min, max);

            break;
        default:
            rows = GetDefaultValues(0);
            columns = GetDefaultValues(1);
            min = GetDefaultValues(2);
            max = GetDefaultValues(3);
            usersSetupsArray = GetFilledRandInt2DArray(rows, columns, min, max);
            break;
    }
    return usersSetupsArray;
}


void Main()
{
    int[,] users2DArray = SetingsMenu();
    Print2DArray(users2DArray);
    FindElemIn2DArray(users2DArray);
}


Main();