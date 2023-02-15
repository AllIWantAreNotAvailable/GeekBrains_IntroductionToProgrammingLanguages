/*
Задача №0
Напишите программу, которая на вход принимает число и выводит его квадрат (число умноженное на само себя)
*/


Console.Write("Введи число: ");
int number = int.Parse(Console.ReadLine()!);
int pow = number * number; // Математический метод
Console.WriteLine($"Квадрат числа {number} = {pow}");
pow = Convert.ToInt32(Math.Pow(number, 2)); // С использованием библиотеки Math
Console.WriteLine($"Квадрат числа {number} = {pow}");