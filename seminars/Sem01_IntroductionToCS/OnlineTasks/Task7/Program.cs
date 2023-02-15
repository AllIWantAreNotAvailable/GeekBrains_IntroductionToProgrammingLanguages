/*
Задача №7
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
*/


Console.Write("Введите 3-х значное число: ");
int number = int.Parse(Console.ReadLine()!);
int lastnumber = number % 10;
Console.WriteLine($"Последняя цифра введенного числа {number} – это {lastnumber}");