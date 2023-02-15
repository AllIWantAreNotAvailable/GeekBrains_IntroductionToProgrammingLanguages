/*
Задача №14
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

14 -> нет
46 -> нет
161 -> да
*/


Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int y = a % 7;
int x = a % 23;

if (y == 0 && x == 0)
{
    Console.WriteLine($"число {a} кратно 7 и 23");
}
else
{
    Console.WriteLine($"число {a} не кратно");
}