int a1 = 15, b1 = 21, c1 = 39;
int a2 = 12, b2 = 23, c2 = 33;
int a3 = 13, b3 = 23, c3 = 33;
int maximumValue = 0;

// <{ Стихийный подход
if (maximumValue < a1) maximumValue = a1;
if (maximumValue < b1) maximumValue = b1;
if (maximumValue < c1) maximumValue = c1;

if (maximumValue < a2) maximumValue = a2;
if (maximumValue < b2) maximumValue = b2;
if (maximumValue < c2) maximumValue = c2;

if (maximumValue < a3) maximumValue = a3;
if (maximumValue < b3) maximumValue = b3;
if (maximumValue < c3) maximumValue = c3;

Console.WriteLine($"Наибольшее значение переменной (Стихийны подход) – {maximumValue}");
// }> Конец Стихийный подход

// <{ Процедурно-функциональный подход
int ReturnMaxOfTreeInt(int a, int b, int c)
{
    int max = a;
    if (max < b) max = b;
    if (max < c) max = c;
    return max;
}
maximumValue = ReturnMaxOfTreeInt(ReturnMaxOfTreeInt(a1, b1, c1),
                                      ReturnMaxOfTreeInt(a2, b2, c2),
                                      ReturnMaxOfTreeInt(a3, b3, c3)); // Сначала отработают вложенные функции, а после главная

Console.WriteLine($"Наибольшее значение переменной (Процедурно-функциональный подход) – {maximumValue}");
// }> Конец Процедурно-функциональный подход

// <{ Подход встроенными методами классов, на примере массива
int[] array = new int[9]; // Инициализация массива длинной 9 с типом данных int, при такой инициализации массив заполне 0-выми значениями
array[0] = a1; array[1] = b1; array[2] = c1;
array[3] = a2; array[4] = b2; array[5] = c2;
array[6] = a3; array[7] = b3; array[8] = c3;
maximumValue = array.Max();
Console.WriteLine($"Наибольшее значение переменной (Подход встроенными методами классов, на примере массива) – {maximumValue}");
// }> Конец Подход встроенными методами классов, на примере массива