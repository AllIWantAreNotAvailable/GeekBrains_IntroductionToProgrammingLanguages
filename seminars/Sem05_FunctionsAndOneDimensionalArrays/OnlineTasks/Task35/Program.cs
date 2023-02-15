/*
Задача №35
Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].

Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
bool ReturnTasskRool(int elementArray)
{
    if (10 <= elementArray && elementArray <= 99) return true;
    else return false;
}


int CountElements(int[] ourArray)
{
    int count = 0;

    foreach (int elem in ourArray)
    {
        if (ReturnTasskRool(elem)) count++;
    }

    return count;
}


void PrintResult(int[] array, int count)
{
    Console.WriteLine($"В массиве [{String.Join(", ", array)}] на отрезке значений 0–99 лежит {count} элементов");
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
    int[] myRandomArray = MakeMeArray(minValue: 0, maxValue: 150, length: 123);
    int elemetsCounted = CountElements(myRandomArray);
    PrintResult(myRandomArray, elemetsCounted);
}

main();