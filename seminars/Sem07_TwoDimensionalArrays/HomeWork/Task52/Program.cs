/*
Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
{
{1,  4,  7,  2},
{5,  9,  2,  3},
{8,  4,  2,  4}
}
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


void ShowAverageColumnValue(int[,] matrixOfValues)
{
    double avg = 0.0;
    double sumValuesOfColumn;
    int numberOfRows = matrixOfValues.GetLength(0);

    Console.WriteLine("Среднее значение по колонкам:");
    for (int column = 0; column < matrixOfValues.GetLength(1); column++)
    {   
        sumValuesOfColumn = 0;
        for (int row = 0; row < numberOfRows; row++)
        {
            sumValuesOfColumn += matrixOfValues[row, column];
        }
        avg = sumValuesOfColumn / numberOfRows;
        Console.Write($"{avg:F1}\t");
    }
    Console.WriteLine();
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
    int[,] usersArray = SetingsMenu();
    Print2DArray(usersArray);
    ShowAverageColumnValue(usersArray);
}

Main();