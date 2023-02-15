/*
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно,
программа должна вывести сообщение для пользователя.
1   2   3
4   5   6
7   8   9
*/


int[,] TrasportMatrix(int[,] matrix)
{
    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);

    int[,] resultMatrix = new int[rowCount, colCount];

    for (int column = 0; column < colCount; column++)
    {

        for (int row = 0; row < rowCount; row++)
        {
            resultMatrix[row, column] = matrix[column, row];
        }
    }

    return resultMatrix;
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


int[,] GetFilledRandInt2DArray(int rows = 4, int columns = 4, int minValue = 0, int maxValue = 16)
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
    int[,] myMatrix = GetFilledRandInt2DArray();
    Print2DArray(myMatrix);
    if (myMatrix.GetLength(0) != myMatrix.GetLength(1))
    {
        Console.WriteLine("Не удасться транспонировать не квадратную матрицу");
        return;
    }
    int[,] transpMatrix = TrasportMatrix(myMatrix);
    Print2DArray(transpMatrix);

}


Main();