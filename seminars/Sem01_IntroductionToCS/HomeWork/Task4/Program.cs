// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Например:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое целое число: ");
int firstnumber = int.Parse(Console.ReadLine()!);
int max = firstnumber;
Console.Write("Введите второе целое число: ");
int secondnumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье целое число: ");
int thirdnumber = int.Parse(Console.ReadLine()!);
if (secondnumber > max) max = secondnumber;
if (thirdnumber > max) max = secondnumber;
Console.WriteLine($"Вами были введены числа: {firstnumber}, {secondnumber} и {thirdnumber}. Из них {max} больше.");
