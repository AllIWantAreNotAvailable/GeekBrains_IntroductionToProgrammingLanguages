/*
Задача №30
Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/


void PrintArray(int[] array)
{
    Console.WriteLine($"[{String.Join(", ", array)}]");
}


int[] GetArray()
{
    int[] intArray = new int[8];
    
    for (int i = 0; i < intArray.Length; i++)
    {
        int randInd = new Random().Next(0, 1 + 1);
        intArray[i] = randInd;
    }
    return intArray;
}


void Main()
{
    int[] array = GetArray();
    PrintArray(array);
}


Main();