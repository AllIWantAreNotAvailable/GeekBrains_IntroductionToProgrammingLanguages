/*
Задача №37
Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/


void PrintResult(int[] randomArray, int[] sumOfPairs)
{
    System.Console.WriteLine($"Сумма пар элементов в массиве [{String.Join(", ", randomArray)}] -> [{String.Join(", ", sumOfPairs)}]");
}


int[] SumOfArraysPairs(int[] randomArray)
{
    int lengthOfResult = 0;

    if (randomArray.Length % 2 == 0) 
    {
        lengthOfResult = randomArray.Length / 2;
    }
    else
    {
        lengthOfResult = randomArray.Length / 2 + 1;
    }

    int[] resultArray = new int[lengthOfResult];
    for (int index = 0; index < randomArray.Length / 2; index++)
    {
        resultArray[index] = randomArray[index] * randomArray[randomArray.Length - 1 - index];
    }
    if (resultArray[resultArray.Length - 1] == 0) resultArray[resultArray.Length - 1] = randomArray[randomArray.Length / 2];

    return resultArray;
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
    int[] myRandomArray = MakeMeArray(minValue: 0, maxValue: 10, length: 4);

    int[] resultOfPairsSum = SumOfArraysPairs(myRandomArray);
    PrintResult(myRandomArray, resultOfPairsSum);
}


main();