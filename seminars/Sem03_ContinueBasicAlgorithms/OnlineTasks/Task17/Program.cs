/*
Задача №17
Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

Console.WriteLine("Введите координату X: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y: ");
int y = int.Parse(Console.ReadLine()!);

if (y > 0)
{
    if (x > 0) Console.WriteLine("I четверть");
    else Console.WriteLine("II четверть");
}
else
{
    if (x > 0) Console.WriteLine("VI четверть");
    else Console.WriteLine("III четверть");
}