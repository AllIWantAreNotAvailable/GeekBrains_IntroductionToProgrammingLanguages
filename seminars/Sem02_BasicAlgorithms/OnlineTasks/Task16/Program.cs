/*
Задача №16
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/


Console.WriteLine("Введите первое число: ");
int a1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int a2 = int.Parse(Console.ReadLine()!);

if (a1 == a2 * a2 || a2 == a1 * a1)
{
    Console.WriteLine(" да ");
}
else
{
    Console.WriteLine(" нет ");
}