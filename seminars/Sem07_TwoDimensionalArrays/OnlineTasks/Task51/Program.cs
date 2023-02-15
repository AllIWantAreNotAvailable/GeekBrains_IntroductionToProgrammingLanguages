/*
Задача 51: Задайте двумерный массив.
Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
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

int SumOfElements(int[,] numbersTable)
{
    int summOfElem = 0;
    int lenght = numbersTable.GetLength(0) < numbersTable.GetLength(1) ? numbersTable.GetLength(0) : numbersTable.GetLength(1);
    for (int i = 0; i < lenght; i++)
    {
        summOfElem += numbersTable[i,i];
    }
    return summOfElem;
}

int[,] ourArray = Get2DArray(3, 5, 0, 10);
Print2DArray(ourArray);
System.Console.WriteLine($"Сумма элементов расположенных на главной диагонали –> {SumOfElements(ourArray)}");