/*
Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/


int[] RandInitArray(int length, int minValue, int maxValue)
{
    int[] randIntArray = new int[length];

    for (int i = 0; i < randIntArray.Length; i++)
    {
        randIntArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return randIntArray;
}


void ReverseArray(int[] someArray)
{
    for (int i = 0; i < someArray.Length / 2; i++)
    {
        int temp = someArray[i];
        someArray[i] = someArray[someArray.Length - 1 - i];
        someArray[someArray.Length - 1 - i] = temp;
    }
}


int[] ReverseAndReturnArray(int[] someMoreArray)
{
    int arrayLength = someMoreArray.Length;
    int[] result = new int[arrayLength];

    for (int i = 0; i < arrayLength; i++)
    {
        result[i] = someMoreArray[arrayLength - 1 - i];
    }

    return result;
}


void Main()
{
    int[] myRandAray = RandInitArray(5, 0, 10);
    Console.Write($"[{String.Join(", ", myRandAray)}] –> ");
    ReverseArray(myRandAray);
    Console.Write($"[{String.Join(", ", myRandAray)}] => ");
    int[] reversedCopyOfMyRandArray = ReverseAndReturnArray(myRandAray);
    Console.WriteLine($"[{String.Join(", ", reversedCopyOfMyRandArray)}]");
}

Main();