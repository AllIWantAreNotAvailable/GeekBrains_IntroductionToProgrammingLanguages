/*
Задача No22
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/


Console.Write("Введите верхнюю границу таблицы квадратов:\n>>> ");
bool flag = int.TryParse(Console.ReadLine()!, out int upperBound);
if (flag)
{
    int number = 1;
    while (number <= upperBound)
    {
        Console.Write($"{number * number}");
        if (number != upperBound) Console.Write(", ");
        else Console.WriteLine();
        number++;
    }
}
else
{
    Console.WriteLine("Неудалось преобразовать введенную строку к числу.");
}