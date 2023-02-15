/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5" M = 4; N = 8 -> "4, 6, 7, 8"
*/


string GetString(int start, int stop)
{

    if (start < stop) return start  + ", " + GetString(start + 1, stop -1) + ", " + stop;
    else return start.ToString();
}

Console.Write("Введите начало последовательности:\n>>> ");
int lBound = int.Parse(Console.ReadLine()!);
Console.Write("Введите конец последовательности:\n>>> ");
int uBound = int.Parse(Console.ReadLine()!);

Console.WriteLine(GetString(lBound, uBound));