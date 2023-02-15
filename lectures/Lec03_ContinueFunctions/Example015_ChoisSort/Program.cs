/*
Суть алгоритма сортировки:
1) Найти позицию минимального (максимального) элемента в неотсортированной части массива.
2) Произвести обмен значения со значением первой неотсортированной позиции.
3) Повторять пока есть не отсортированные элементы.
*/


void SelectionSort(int[] arrayToSort, bool minToMax = true)
{
    for (int i = 0; i < arrayToSort.Length - 1; i++)
    {
        int position = i;

        for (int j = i + 1; j < arrayToSort.Length; j++)
        {
            if (minToMax)
            {
                if (arrayToSort[j] < arrayToSort[position]) position = j;
            }
            else
            {
                if (arrayToSort[position] < arrayToSort[j]) position = j;
            }
        }

        int temporary = arrayToSort[i];
        arrayToSort[i] = arrayToSort[position];
        arrayToSort[position] = temporary;
    }
}


void PrintArray(int[] arrayToPrint)
{
    Console.WriteLine($"[{String.Join(", ", arrayToPrint)}]");
}


int[] array = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
PrintArray(array);
SelectionSort(array);
PrintArray(array);
SelectionSort(array, false);
PrintArray(array);