﻿/*
Задача №9
Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
Например:

78 -> 8
12 -> 2
85 -> 8
*/

int randInt = new Random().Next(10, 100); // – полуинтервал [1, 2...100) (10, 11...99)
int dec = randInt / 10;
int num =  randInt % 10;

int max = dec;
if (max < num) max = num;
Console.WriteLine($"Наибольшая цифра числа {randInt} – {max}");