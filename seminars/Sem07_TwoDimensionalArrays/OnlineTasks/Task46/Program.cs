/*
Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4. 1 4 8 19
5 -2 33 -2 77 3 8 1
*/

int[,] Get2DArray(int rows, int colums, int minVal, int maxVal)
{
    int[,] array = new int[rows, colums];
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[row, column] = new Random().Next(minVal, maxVal+1);
        }
    }
    return array;
}

void Print2DArray(int[,] arrayToPrint)
{
    for (int row = 0; row < arrayToPrint.GetLength(0); row++)
    {
        for (int column = 0; column < arrayToPrint.GetLength(1); column++)
        {
            Console.Write($"{arrayToPrint[row, column]}\t ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int rowNum = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int colNum = int.Parse(Console.ReadLine()!);
Console.Write("Введите мин значение для заполнения: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите макс значение для заполнения: ");
int max = int.Parse(Console.ReadLine()!);

int[,] myArray = Get2DArray(rowNum, colNum, min, max);
Print2DArray(myArray);