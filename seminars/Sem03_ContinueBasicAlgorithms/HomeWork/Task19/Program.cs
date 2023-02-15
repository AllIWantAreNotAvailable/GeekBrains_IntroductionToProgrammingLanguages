﻿/*
Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом(*).
14212 -> нет
23432 -> да
12821 -> да

(*)Числовой палиндром – это натуральное число, которое читается слева направо и справа налево одинаково. Иначе говоря, отличается
симметрией записи (расположения цифр), причем число знаков может быть как четным, так и нечетным.
Примерами являются все однозначные числа, двузначные вида αα, такие как 11 и 99, трехзначные числа вида αβα, например 535 и т.д.
*/

// PS Очень увлекла задача, захотелось нестандартное решение. Так как оно способно решать задачу с большим кол-вом разрядов числа,
// проверку на 5-тизначное не проводим. Для полного сатисфэкшена не хватает только try cath finally.... и функций... и массивов...

Console.Clear(); // Из вежливости, очищаем предыдущие выводы в консоль.

bool gotResult = false; // Переменная тригер наличия положительного результата

int ten = 10; // Переменная для вычисления степени числа 10

Console.WriteLine("Введите 5-тизначное число: ");
int number = int.Parse(Console.ReadLine()!); // Объявляем переменную для считывания данных из консоли.
int digits = 0; // Кол-во разрядов введенного числа
int temp = number; // Временная переменная для определения кол-ва разрядов

while (temp > 0) // Считаем кол-во разрядов
{
    temp /= 10;
    digits++;
}

if (number <= 0) // (-∞, 0] Числовой палиндром – это натуральное число, Наименьшее натуральное число: 1
{
    Console.WriteLine($"Введены некорректные данные, число {number} не может являть полиндромом.");
}
else if (number < 10) // [1, 10) Числовыми палиндромами являются все однозначные числа из определения.
{
    gotResult = true; 
}
else
{
    for (int i = 1; i <= digits / 2; i++) // Инициализируем цикл For от 1 до среднего разряда числа (digit – общее кол-во разрядов)
    {
        int upperDigit = number / Convert.ToInt32(Math.Pow(ten, digits - i)); // Переменная хранит старший просматриваемый разряд, слева от ср. симв.
        int lowerDigit = number % Convert.ToInt32(Math.Pow(ten, i)); // Переменная хранит младший просматриваемый разряд, справа от ср. симв.
        upperDigit %= ten;
        lowerDigit /= Convert.ToInt32(Math.Pow(ten, i - 1));
       
        if (upperDigit != lowerDigit) // Если старший разряд не равен младшему, то это не полидром
        {
            gotResult = false;
            break; // А значит, продолжать анализ введенного числа смысла более нет.
        }
        else
        {
            gotResult = true; // Иначе, все старшие разряды соответсвуют младшим и число является полидромом.
        }
    }
}
Console.WriteLine($"{number} – является полидромом == {gotResult}");