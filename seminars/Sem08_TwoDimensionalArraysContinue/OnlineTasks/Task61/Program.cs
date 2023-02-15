/*
Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
*/


void PrintPaskalTriangle(int triangleHeigth)
{
    for (int row = 0; row < triangleHeigth; row++)
    {
        for (int col = 0; col <= row; col++)
        {
            if (!(col == 0)) Console.Write(" \\ ");
            Console.Write(Factorial(row) / (Factorial(col) * Factorial(row - col)));
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}


int Factorial(int uBound)
{
    int result = 1;
    for (int number = 1; number < uBound; number++)
    {
        result *= number;
    }
    return result;
}


(bool, int) GetHeightTriangleFromUser()
{
    (bool check, int heigth) userInput;
    Console.Write("Укажите высоту треугольника Паскаля:\n>>> ");
    userInput.check = int.TryParse(Console.ReadLine()!, out userInput.heigth);
    return userInput;
}


void Main()
{
    (bool flag, int heigth) userInput = GetHeightTriangleFromUser();
    if (userInput.flag)
    {
        PrintPaskalTriangle(userInput.heigth);
    }
    else
    {
        Console.WriteLine("Не удалось преобразовать строку к числу.");
    }
}


Main();