/*
Задача №31
Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/


void SumOfPosAndNegInt(int[] newArray)
{
    int sumOfNegative = 0;
    int sumOfPositive = 0;

    foreach (int elem in newArray)
    {
        // if (elem < 0) sumOfNegative += elem;
        // else sumOfPositive += elem;
        sumOfNegative += elem < 0 ? elem : 0;
        sumOfPositive += 0 < elem ? elem : 0;
    }

    Console.WriteLine($"Сумма отрицательных чисел массива: {sumOfNegative}; \nСумма отрицательных чисел массива {sumOfPositive}");
}


int[] InitArray(int length, int minValue, int maxxValue)
{
    int[] randIntArray = new int[length];

    for (int i = 0; i < randIntArray.Length; i++)
    {
        randIntArray[i] = new Random().Next(minValue, maxxValue + 1);
    }
    return randIntArray;
}


void main()
{
    int[] array = InitArray(12, -9, 9);
    Console.WriteLine(string.Join(" ", array));
    SumOfPosAndNegInt(array);
}


main();