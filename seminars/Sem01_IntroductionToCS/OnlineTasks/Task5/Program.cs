/*
Задача №5
Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Например:
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
*/


Console.Write("Введите число: ");
int ubound = int.Parse(Console.ReadLine()!);
int lbound = -ubound;
while(lbound <= ubound)
{
    if (lbound == ubound)
    {
        Console.Write($"{lbound}");
    }
    else
    {
        Console.Write($"{lbound}, ");
    }
    lbound ++;
}