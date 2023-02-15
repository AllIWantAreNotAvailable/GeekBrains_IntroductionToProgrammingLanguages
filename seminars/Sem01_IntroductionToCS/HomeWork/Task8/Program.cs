// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите верхнюю границу для вывода чисел: ");
int ubound = int.Parse(Console.ReadLine()!);
int increment = 1;

while (increment <= ubound)
{
    if (increment % 2 == 0)
    {
        Console.Write($"{increment}");
        if (increment < ubound - 1) Console.Write(", ");
    }
    increment ++;
}