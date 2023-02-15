/*
Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты.
Например, изначально массив выглядел вот так:
1 47 2
5 92 3
8 42 4

Новый массив будет выглядеть вот так:

1   4   49  2
5   81  2  9
64  4   4   4

*/

int[,] Get2DArray(int rows, int colums, int minVal, int maxVal)
{
    int[,] array = new int[rows, colums];
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[row, column] = new Random().Next(minVal, maxVal + 1);
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

void ChangeEvenElemToPowOfTwo(int[,] someArray)
{
    for (int row = 2; row < someArray.GetLength(0); row += 2)
    {
        for (int column = 2; column < someArray.GetLength(1); column += 2)
        {
            someArray[row, column] = Convert.ToInt32(Math.Pow(someArray[row,column], 2));
        }
    }
}

int[,] ourRandArray = Get2DArray(8, 8, 0, 4);
Print2DArray(ourRandArray);
ChangeEvenElemToPowOfTwo(ourRandArray);
Console.WriteLine();
Print2DArray(ourRandArray);