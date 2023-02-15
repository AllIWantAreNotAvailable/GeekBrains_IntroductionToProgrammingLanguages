/*
Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
{
    {0.5,   7,      -2,     -0,2},
    {1,     -3.3,   8,      -9,9},
    {8,     7.8,    -7,1,   9}
}
*/


double[,] GetFilledRandDuble2DArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] double2DArray = new double[rows, columns];
    Random randNum = new Random();
    for (int row = 0; row < double2DArray.GetLongLength(0); row++)
    {
        for (int column = 0; column < double2DArray.GetLongLength(1); column++)
        {
            double2DArray[row, column] = Convert.ToDouble(randNum.Next(minValue, maxValue + 1)) + randNum.NextDouble();
        }
    }
    return double2DArray;
}


void Print2DArray(double[,] arrayToPrint)
{
    Console.WriteLine();
    Console.WriteLine("Таблица значений:");
    for (int row = 0; row < arrayToPrint.GetLength(0); row++)
    {
        for (int column = 0; column < arrayToPrint.GetLength(1); column++)
        {
            Console.Write($"{arrayToPrint[row, column]:F3}\t");
        }
        Console.WriteLine();
    }
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


double[,] SetingsMenu()
{
    double[,] usersSetupsArray;
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

            usersSetupsArray = GetFilledRandDuble2DArray(rows, columns, min, max);

            break;
        default:
            rows = GetDefaultValues(0);
            columns = GetDefaultValues(1);
            min = GetDefaultValues(2);
            max = GetDefaultValues(3);
            usersSetupsArray = GetFilledRandDuble2DArray(rows, columns, min, max);
            break;
    }
    return usersSetupsArray;
}

void Main()
{
    Print2DArray(
            SetingsMenu());
}


Main();