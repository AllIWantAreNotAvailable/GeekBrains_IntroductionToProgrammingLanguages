

void Fill2DArray(int[,] arrayToFill, int minFillingValue = 1, int maxFillingValue = 10)
{
    Random randInt = new Random();

    for ( int row = 0; row < arrayToFill.GetLength(0); row++)
    {
        for (int column = 0; column < arrayToFill.GetLength(1); column++)
        {
            arrayToFill[row, column] = randInt.Next(minFillingValue, maxFillingValue);
        }
    }
}


void Print2DArray(int[,] users2DArray)
{
    for (int row = 0; row < users2DArray.GetLength(0); row++) // users2DArray.GetLength(0) – Возвращает кол-во строк двумерного массива
    {
        Console.Write("|");
        for (int column = 0; column < users2DArray.GetLength(1); column++) // users2DArray.GetLength(1) – Возвращает кол-во столбцов двумерного массива
        {
            Console.Write($"{users2DArray[row, column]}");
            if (0 <= column && column < users2DArray.GetLength(1) - 1) Console.Write("|");
        }
        Console.WriteLine("|");
    }
}


int[,] Initializing2DArrayOfIntegers(int numberOfRows = 2, int numberOfColumns = 2)
{
    int[,] matrix = new int[numberOfRows, numberOfColumns];
    return matrix;
}


void Main()
{
    int[,] table = Initializing2DArrayOfIntegers(3, 4);
    Print2DArray(table);
    Console.WriteLine();
    Fill2DArray(table);
    Print2DArray(table);
}


Main();