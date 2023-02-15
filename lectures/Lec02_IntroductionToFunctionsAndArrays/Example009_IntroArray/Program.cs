//  <{ Массив, инициализация и образение к элементам массива по индексу
int ReturnMaxOfTreeInt(int a, int b, int c)
{
    int max = a;
    if (max < b) max = b;
    if (max < c) max = c;
    return max;
}

int[] array = {11, 21, 31, 41, 15, 61, 17, 18, 19};

int result = ReturnMaxOfTreeInt(ReturnMaxOfTreeInt(array[0], array[1], array[2]),
                                ReturnMaxOfTreeInt(array[3], array[4], array[5]),
                                ReturnMaxOfTreeInt(array[6],array[7], array[8]));
Console.WriteLine($"Максимальный элемент массива – {result}");
// }> Массив, инициализация и образение к элементам массива по индексу