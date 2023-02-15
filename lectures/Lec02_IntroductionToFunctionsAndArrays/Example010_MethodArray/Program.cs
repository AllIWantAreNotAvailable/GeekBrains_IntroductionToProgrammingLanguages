int[] array = {1, 12, 31, 4, 15, 16, 17, 18};

int find = 4;

for (int index = 0; index < array.Length; index++)
{
    if (array[index] == find)
    {
    Console.WriteLine($"Индекс элемента массива с искомым значением {find} – {index}");
    break;
    }
}
