/*
Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 

5 -> 1, 8, 27, 64, 125
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число большее чем 0: ");
int number = int.Parse(Console.ReadLine()!);

switch (number)
{
    case > 0:
    {
        string result = "";
        for (int i = 1; i <= number; i++)
        {
            result += $"{Math.Pow(i, 3)}";
            if (i < number) result += (", ");
        }
        Console.WriteLine(result);
        break;
    }
    default:
    {
        Console.WriteLine("Введено некорректное число, введите число большее 1.");
        break;
    }
}