/*
Задача №11
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/


int randInt = new Random().Next(100, 1000); // – полуинтервал [1, 2...100) (10, 11...99)
int hun = randInt / 100;
int num =  randInt % 10;

int newInt = hun * 10 + num;
Console.WriteLine($"{randInt} –> {newInt}");