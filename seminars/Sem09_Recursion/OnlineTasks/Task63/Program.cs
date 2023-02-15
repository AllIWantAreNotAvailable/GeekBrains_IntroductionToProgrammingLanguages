/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
*/


string GetString(int usersNumber)
{

    if (usersNumber > 1) return GetString(usersNumber - 1) + ", " + usersNumber;
    else return "1, ";
}

Console.Write("Введите число:\n>>> ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine(GetString(number));