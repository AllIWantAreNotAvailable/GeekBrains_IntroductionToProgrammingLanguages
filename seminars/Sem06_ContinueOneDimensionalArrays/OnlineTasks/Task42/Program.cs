/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101 
3 -> 11
2 -> 10
*/


int ConvertDecimalToBinary(int decimalNumber)
{
    int binaryNumber = 0;
    int pow = 0;

    while (decimalNumber > 0)
    {
        binaryNumber += decimalNumber % 2 * Convert.ToInt32(Math.Pow(10, pow));
        pow++;
        decimalNumber /= 2;
    }

    return binaryNumber;
}


(bool, int) UserInput()
{
    (bool check, int decimalNumber) userInput;
    Console.Write("Введите число в десятичной системе исчисления:\n>>> ");
    userInput.check = int.TryParse(Console.ReadLine()!, out userInput.decimalNumber);
    return userInput;
}


void Main()
{
    (bool flag, int decimalNumber) userinput = UserInput();
    if (userinput.flag)
    {
        Console.WriteLine($"{userinput.decimalNumber} –> {ConvertDecimalToBinary(userinput.decimalNumber)}");
    }
    else
    {
        Console.WriteLine("Не удалось преобразовать строку в число.");
    }
}


Main();