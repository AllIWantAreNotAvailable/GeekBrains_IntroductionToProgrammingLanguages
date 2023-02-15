/*
Задача №1.
Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

a = 25, b = 5 -> да
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да
a = -3 b = 9 -> нет
*/


bool flag;
Console.Write("Введите первое число:\n>>> ");
flag = int.TryParse(Console.ReadLine()!, out int firstNumber);
if (!flag) Console.WriteLine("Не удалось преобразовать строку к числу");
else
{
    Console.Write("Введите второе число:\n>>> ");
    flag = int.TryParse(Console.ReadLine()!, out int secondNumber);
    if (!flag) Console.WriteLine("Не удалось преобразовать строку к числу");
    else
    {
        bool isPow = firstNumber == secondNumber * secondNumber;
        string result = isPow
                      ? "является квадратом"
                      : "не является квадратом";
        Console.WriteLine($"Число {firstNumber} {result} {secondNumber}");
    }
}