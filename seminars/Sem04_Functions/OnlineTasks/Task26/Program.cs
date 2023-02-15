/* 
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

456 -> 3
78 -> 2
89126 -> 5
*/


int SumOfDigits(int number)
{
    int sumOfDigits = 0;
    while (0 < number)
    {
        sumOfDigits += number % 10;
        number /= 10;
    }
    return sumOfDigits;
}


(bool, int) UserInput()
{
    (bool check, int number) userInput;
    Console.Write("Введите число:\n>>> ");
    userInput.check = int.TryParse(Console.ReadLine()!, out userInput.number);
    return userInput;
}


void Main()
{
    (bool flag, int number) userInput = UserInput();
    if (userInput.flag)
    {
        Console.WriteLine($"Сумма цифр в числе {userInput.number} = {SumOfDigits(userInput.number)}");
    }
    else
    {
        Console.WriteLine("Не удалось преобразовать введенную строку к числу.");
    }
}


Main();