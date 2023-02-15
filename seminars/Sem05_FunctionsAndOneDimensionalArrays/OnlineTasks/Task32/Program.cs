/*
Задача №32
Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/


void PrintResult(string randomarray, int[] someArrayOfInt)
{
    Console.WriteLine(randomarray + $"\nМассив с преобразованными значениями [{String.Join(",", someArrayOfInt)}]");
}


void ReverseValues(int[] arrayToReverse)
{
    for (int index = 0; index < arrayToReverse.Length; index++)
    {
        arrayToReverse[index] *= -1;
    }
}


int[] MakeMeArray(int length, int minValue, int maxValue)
{
    int[] randIntArray = new int[length];

    for (int elem = 0; elem < randIntArray.Length; elem++)
    {
        randIntArray[elem] = new Random().Next(minValue, maxValue + 1);
    }

    return randIntArray;
}


void main()
{
    int[] myRandomArray = MakeMeArray(maxValue: 12, length: 15, minValue: -12);
    string usersArray = $"Исходный массив [{string.Join(", ", myRandomArray)}]";
    ReverseValues(myRandomArray);
    PrintResult(usersArray, myRandomArray);
}

main();