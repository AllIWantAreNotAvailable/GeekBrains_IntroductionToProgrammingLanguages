/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (35)
A = 2; B = 3 -> 8
*/


int GetPow(int numA, int numB)
{
    if (numB == 0) return 1;
    else
    {
        return numA * GetPow(numA, numB-1);
    }
}


Console.Write("Введите основание степени:\n>>> ");
int basePow = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень:\n>>> ");
int pow = int.Parse(Console.ReadLine()!);

Console.WriteLine(GetPow(basePow, pow));