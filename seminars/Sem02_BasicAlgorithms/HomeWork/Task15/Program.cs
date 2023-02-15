/*  Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите порядковый номер дня недели: ");
int daynumber = int.Parse(Console.ReadLine()!);
if (daynumber < 1 || daynumber > 7) Console.WriteLine("Введены некорректные данные, дни недели имеют порядковые номера от 1 до 7!");
else if (daynumber == 6 || daynumber == 7) Console.WriteLine($"{daynumber} –> Да");
else Console.WriteLine($"{daynumber} -> Нет");