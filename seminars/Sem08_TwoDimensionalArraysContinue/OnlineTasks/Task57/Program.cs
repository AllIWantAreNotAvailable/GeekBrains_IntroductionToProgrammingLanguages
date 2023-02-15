/*
Задача 57: Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
*/


// {0, 1, 1, 4, 8}  -> 0 встретился 1 раз
// 1 2 3 4 5 0 -> 1 2 3 4 0 5

int[,] GetRandomMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int[] MatrixToArray(int[,] matrix)
{
    int count = 0;
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count++] = matrix[i, j];
        }
    }
    return array;
}

void SortArray(int[] array)
{
    int temp;
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}

void CountElemets(int[] array)
{
    int count = 1;
    for (int i = 0; i < array.Length-1; i++)
    {
        if (array[i] != array[i+1])
        {
            Console.WriteLine($"элемент {array[i]} встречается {count} раз");
            count = 1;
        }
        else count++;
    }
    Console.WriteLine($"элемент {array[array.Length - 1]} встречается {count} раз");
}

Console.Clear();
int[,] matrix = GetRandomMatrix(m: 4, n: 4, minValue: 1, maxValue: 10);
PrintArray(matrix);
Console.WriteLine();

int[] array = MatrixToArray(matrix);
Console.WriteLine(string.Join(" ", array));

SortArray(array);
Console.WriteLine(string.Join(" ", array));

CountElemets(array);