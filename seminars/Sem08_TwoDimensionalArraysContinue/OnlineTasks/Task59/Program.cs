/*
Задача №59
Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
на пересечении которых расположен наименьший элемент массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Наименьший элемент - 1, на выходе получим следующий массив:
9 4 2
2 2 6
3 4 7
*/


int[,] DelRowAndColWithMinValue(int[,] usersMatrix, (int row, int col) args)
{
    int[,] newMatrix = new int[usersMatrix.GetLength(0) - 1, usersMatrix.GetLength(1) - 1];
    int newMatrixRow = 0, newMatrixCol = 0;

    for (int usersMatrixRow = 0; usersMatrixRow < usersMatrix.GetLength(0); usersMatrixRow++)
    {
        if (usersMatrixRow == args.row) continue;
        for (int usersMatrixCol = 0; usersMatrixCol < usersMatrix.GetLength(1); usersMatrixCol++)
        {
            if (usersMatrixCol == args.col) continue;
            newMatrix[newMatrixRow, newMatrixCol] = usersMatrix[usersMatrixRow, usersMatrixCol];
            newMatrixCol++;
        }
        newMatrixCol = 0;
        newMatrixRow++;
    }

    return newMatrix;
}


(int, int) GetCoordinatesOfMinValue(int[,] matrix)
{
    (int row, int col) coordinates = (0, 0);
    int minValue = matrix[coordinates.row, coordinates.col];

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 1; col < matrix.GetLength(1); col++)
        {
            int element = matrix[row, col];
            if (element < minValue)
            {
                minValue = element;
                coordinates = (row, col);
            }
        }
    }

    return coordinates;
}


void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("\nТаблица значений:");
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write($"|\t{matrix[row, col]}\t");
        }
        Console.WriteLine("|");
    }
}


int[,] GetRandIntArray((int rowLength, int colLength, int minValue, int maxValue) args)
{
    int[,] matrix = new int[args.rowLength, args.colLength];
    Random randInt = new Random();

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            matrix[row, col] = randInt.Next(args.minValue, args.maxValue);
        }
    }

    return matrix;
}


int GetDefaultValues(int valueIndex)
{
    int value;
    switch (valueIndex)
    {
        case 0: // Кол-во строк
            value = 4;
            break;
        case 1: // Кол-во столбцов
            value = 4;
            break;
        case 2: // Минимальное значение
            value = 0;
            break;
        case 3: // Максимальное значение
            value = 16;
            break;
        default:
            value = 0;
            break;
    }
    return value;
}


(int, int, int, int) UserSettings()
{
    (int rowLength, int colLength, int minValue, int maxValue) userSettings;
    userSettings.rowLength = GetDefaultValues(0);
    userSettings.colLength = GetDefaultValues(1);
    userSettings.minValue = GetDefaultValues(2);
    userSettings.maxValue = GetDefaultValues(3);
    bool check = false;

    Console.Write("Настроить генерацию матрицы?\n"
                + "(Y for \"yes\" or Any key for \"no\")\n"
                + ">>> ");
    switch (Console.ReadKey().Key)
    {
        case ConsoleKey.Y:
            Console.WriteLine();

            Console.Write($"Задайте необходимое кол-во строк таблицы:\n>>> ");
            check = int.TryParse(Console.ReadLine()!, out userSettings.rowLength);
            if (!check)
            {
                Console.WriteLine("Не удалось преобразовать строку к числу."
                                + "Будет использовано значение по умолчанию.");
                userSettings.rowLength = GetDefaultValues(0);
            }

            Console.Write($"Задайте необходимое кол-во столбцов таблицы:\n>>> ");
            check = int.TryParse(Console.ReadLine()!, out userSettings.colLength);
            if (!check)
            {
                Console.WriteLine("Не удалось преобразовать строку к числу."
                                + "Будет использовано значение по умолчанию.");
                userSettings.colLength = GetDefaultValues(1);
            }

            Console.Write($"Задайте минимальное значение для заполнения таблицы:\n>>> ");
            check = int.TryParse(Console.ReadLine()!, out userSettings.minValue);
            if (!check)
            {
                Console.WriteLine("Не удалось преобразовать строку к числу."
                                + "Будет использовано значение по умолчанию.");
                userSettings.minValue = GetDefaultValues(2);
            }

            Console.Write($"Задайте максимальное значение для заполнения таблицы:\n>>> ");
            check = int.TryParse(Console.ReadLine()!, out userSettings.maxValue);
            if (!check)
            {
                Console.WriteLine("Не удалось преобразовать строку к числу."
                                + "Будет использовано значение по умолчанию.");
                userSettings.maxValue = GetDefaultValues(3);
            }


            break;
    }
    Console.WriteLine();
    return userSettings;
}


void Main()
{
    (int rowLength, int colLength, int minValue, int maxValue) userSettings = UserSettings();
    int[,] usersMatrix = GetRandIntArray(userSettings);
    PrintMatrix(usersMatrix);
    (int row, int col) minimumValueCoordinates = GetCoordinatesOfMinValue(usersMatrix);
    Console.WriteLine("\nМинимальное значение находится по координатам "
                   + $"({minimumValueCoordinates.row + 1}, {minimumValueCoordinates.col + 1})");
    int[,] newMatrix = DelRowAndColWithMinValue(usersMatrix, minimumValueCoordinates);
    PrintMatrix(newMatrix);
}


Main();