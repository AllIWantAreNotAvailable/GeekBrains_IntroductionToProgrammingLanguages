/*
Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
m = 3, n = 4. 0 1 23
1 2 34
2 3 45
*/


int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[row, column] = row + column;
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
Print2DArray(GetArray(rowNum, colNum));
