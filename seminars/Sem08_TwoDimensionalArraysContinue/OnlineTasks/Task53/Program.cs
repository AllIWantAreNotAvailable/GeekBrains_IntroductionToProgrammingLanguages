/*
Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/


void ReplaceFirstAndLastRow(int[,] matrix)
{
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        int temp = matrix[0, column];
        matrix[0, column] = matrix[matrix.GetLength(0)-1, column];
        matrix[matrix.GetLength(0)-1, column] = temp;
    }
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


int[,] GetFilledRandInt2DArray(int rows = 3, int columns = 3, int minValue = 0, int maxValue = 9)
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


void Main()
{
    int[,] tempArray = GetFilledRandInt2DArray();
    Print2DArray(tempArray);
    ReplaceFirstAndLastRow(tempArray);
    Print2DArray(tempArray);
}


Main();