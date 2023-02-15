void FillArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = new Random().Next(1, 10);
    }
}


void PrintArray(int[] collection)
{
    string outputText = "[";
    for (int index = 0; index < collection.Length; index++)
    {
        if (index < collection.Length - 1)
        {
            outputText += Convert.ToString(collection[index]) + ", ";
        }
        else
        {
            outputText += Convert.ToString(collection[index]);
        }
        
    }
    outputText += "]";
    Console.WriteLine(outputText);
}


int FindIndexOfElement(int[] collection, int ElementValue)
{
    int foundedIndex = -1;
    for (int index = 0; index < collection.Length; index++)
    {
        if (collection[index] == ElementValue)
        {
            foundedIndex = index;
            break;
        }
    }
    return foundedIndex;
}


int[] array = new int[10];
FillArray(array);
PrintArray(array);

int find = 4;
int founded = FindIndexOfElement(array, find);
if (founded != -1) // Не факт что искомое значение будет в массиве заполненном случайными, исключения еще обрабатывать не умеем ;(
{
    Console.WriteLine($"Значение элемента массива равное {find} имеет индекс {founded}");
}
else
{
    Console.WriteLine("Искомое значение не найдено в массиве!");
}