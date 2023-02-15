/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

/*
if (numberForFibonacci == 1 || numberForFibonacci == 2) return 1;
    else return ReturnFibonacciNumber(numberForFibonacci - 1) + ReturnFibonacciNumber(numberForFibonacci - 2);
*/
int UserInput()
{
    Console.Write("Введите число: ");
    return int.Parse(Console.ReadLine()!);
}

void fibonacci(int number)
{
    int A = 0;
    int B = 1;
    for (int i = 0; i < number; i++)
    {
        Console.Write($"{A} ");
        int temp = A + B;
        A = B;
        B = temp;
    }
}

void Main()
{
    fibonacci(UserInput());
}

Main();