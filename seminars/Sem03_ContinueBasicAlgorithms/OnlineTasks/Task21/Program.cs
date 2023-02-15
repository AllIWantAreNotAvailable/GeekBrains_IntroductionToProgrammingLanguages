/*
Задача №21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21

d = √ (х А – х В) 2 + (у А – у В) 2
*/

// Начало Объявления 1-й точки A
Console.WriteLine("Введите x1");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y1");
int y1 = int.Parse(Console.ReadLine()!);
// Конец Объявления 1-й точки

// Начало Объявления 2-й точки B
Console.WriteLine("Введите x2");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y2");
int y2 = int.Parse(Console.ReadLine()!);
// Конец Объявления 2-й точки

int ab = x1 - x2;// Катет 1
int ac = y1 - y2;// Катет 2

// d = √ (АВ)2 + (АС)2
double bcPow2 = Math.Pow(ac, 2) + (ab * ab); // Гипотенуза в квадрате
double bc = Math.Sqrt(bcPow2);
bc = Math.Round(bc, 2, MidpointRounding.ToZero);
Console.WriteLine($"Растояние между точками ({x1}, {y1}) и ({x2}, {y2}) равняется {bc}.");