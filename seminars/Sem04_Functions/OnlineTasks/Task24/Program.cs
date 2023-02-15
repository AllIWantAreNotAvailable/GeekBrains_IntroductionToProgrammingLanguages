/*
Задача №24
Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

7 -> 28
4 -> 10
8 -> 36
*/


(bool, int) UserInput()
{
    (bool check, int number) userInput;
    Console.Write("Введите целое натуральное число:\n>>> ");
    userInput.check = int.TryParse(Console.ReadLine()!, out userInput.number);
    return userInput;
}


int GetResult(int upperBound)
{
    int sum = 0;
    for (int i = 1; i <= upperBound; i++)
    {
        sum += i;
    }
    return sum;
}


void Main()
{
    (bool flag, int number) userInput = UserInput();
    if (userInput.flag)
    {
        int sumOfRange = GetResult(userInput.number);
        Console.WriteLine($"Сумма чисел от 1 до {userInput.number} = {sumOfRange}");
    }
    else
    {
        Console.WriteLine("Не удалось преобразовать введенную строку к числу.");
    }
}


Main();