/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

// Начало Координаты точки A
Console.WriteLine("Введите координату x точки А: ");
int xA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y точки A: ");
int yA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату z точки A: ");
int zA = int.Parse(Console.ReadLine()!);
// Конец Координаты точки A

// Начало Координаты точки B
Console.WriteLine("Введите координату x точки B: ");
int xB = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y точки B: ");
int yB = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату z точки B: ");
int zB = int.Parse(Console.ReadLine()!);
// Конец Координаты точки b

double line = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA-zB, 2));
Console.WriteLine($"Растояние между точками ({xA}, {yA}, {zA}) и ({xB}, {yB}, {zB}) составляет {Math.Round(line, 2, MidpointRounding.ToZero)}");