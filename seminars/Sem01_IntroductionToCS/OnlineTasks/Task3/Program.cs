/*
Задача №3
Напишите программу, которая будет выдавать название дня недели по заданному номеру.
Например:
3 -> Среда
5 ->  Пятница
*/


Console.Write("Введите номер дня недели: ");
int daynumber = int.Parse(Console.ReadLine()!);
if (daynumber == 1) Console.WriteLine("Выбран Понедельник");
if (daynumber == 2) Console.WriteLine("Выбран Вторник");
if (daynumber == 3) Console.WriteLine("Выбран Среда");
if (daynumber == 4) Console.WriteLine("Выбран Четверг");
if (daynumber == 5) Console.WriteLine("Выбран Пятница");
if (daynumber == 6) Console.WriteLine("Выбран Суббота");
if (daynumber == 7) Console.WriteLine("Выбран Воскресенье");
if (daynumber < 1 || daynumber > 7) Console.WriteLine("Введены некорректные данные, дни недели имеют порядковые номера от 0 до 7!");