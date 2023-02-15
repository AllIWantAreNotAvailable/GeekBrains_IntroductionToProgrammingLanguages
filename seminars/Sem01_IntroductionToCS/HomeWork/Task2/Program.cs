// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Примеры:
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое целое число: ");
int firstnumber = int.Parse(Console.ReadLine()!);
int max = firstnumber;
Console.Write("Введите второе целое число: ");
int secondnumber = int.Parse(Console.ReadLine()!);
if (secondnumber > max) max = secondnumber;
Console.WriteLine($"Вами были введены числа: {firstnumber} и {secondnumber}. Из них {max} больше.");
