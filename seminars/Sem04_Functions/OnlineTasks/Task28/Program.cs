/*
Задача №28
Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

4 -> 24 
5 -> 120
*/


int GetResult(int number)
{
    int result = 1;
    int upperBound = number;
    for (int i = 1; i <= upperBound; i++)
    {
        result *= i;
    }

    return result;
}


(bool, int) UserInput()
{
    (bool check, int number) userInput;
    Console.WriteLine("Введите целое натуральное число: ");
    userInput.check = int.TryParse(Console.ReadLine()!, out userInput.number);
    return userInput;
}


void Main()
{
    (bool flag, int number) userInput = UserInput();
    if (userInput.flag)
    {
        Console.WriteLine($"Произведение чисел от 1 до {userInput.number} = {GetResult(userInput.number)}");
    }
    else
    {
        Console.WriteLine("Не удалось преобразовать введенную строку к числу.");
    }
}


Main();