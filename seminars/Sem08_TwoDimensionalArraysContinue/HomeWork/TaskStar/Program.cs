/*
Написать функцию Sqrt(x) - квадратного корня, которая принимает на вход целочисленное значение x
и возвращает целую часть квадратного корня от введенного числа.
4 -> 2 28 -> 5
Нельзя использовать встроенные функции библиотеки Math!
*/


void PrintResult((int digitsCount, int usersSqrt, int root, int iterations) args)
{
    string prettyRoot = "_";
    for (int i = 0; i < args.digitsCount; i++)
    {
        prettyRoot += "_";
    }
    double logarithmOnBaseTwo = Math.Log2(Convert.ToDouble(args.usersSqrt));
    bool testPassed = args.iterations <= logarithmOnBaseTwo;

    System.Console.WriteLine($" {prettyRoot}\n"
                           + $"{'\u221a'} {args.usersSqrt} = {args.root}{'\u00b2'}\n"
                           + "Время выполнения алгоритма:\n"
                           + $"– требуемое log{'\u2082'}({args.usersSqrt}) = {logarithmOnBaseTwo:F2};\n"
                           + $"- фактическое {args.iterations}\n"
                           + $"Алгоритм выполнил расчет за оптимальное время – {testPassed}");
}

(int, int) ExtractTheRoot(int usersValue)
{
    int root = usersValue / 2;
    double accuracy = 0.1;
    int iterations = 0;

    while (root - usersValue / root > accuracy)
    {
        ++iterations;
        root = (root + usersValue / root) / 2;
    }

    return (root, iterations);
}


(int, int) UserInput()
{
    System.Console.Write("Введите квадратный корень для извлечения:\n"
                      + $" ____\n{'\u221a'} ");
    string usersString = Console.ReadLine()!;
    usersString = usersString.Replace(" ", "");
    int digitsOfUsrsSqrt = usersString.Length;
    bool validInput = int.TryParse(usersString, out int usersSqrt);

    if (!validInput)
    {
        Console.Clear();
        Console.WriteLine("Не удалось преобразовать значение к числу, повторите попытку.");
        return UserInput();
    }
    else
    {
        return (digitsOfUsrsSqrt, usersSqrt);
    }
}


void Main()
{
    (int digits, int sqrt) inputed = UserInput();
    (int sqrtBase, int iterations) result = ExtractTheRoot(inputed.sqrt);
    PrintResult((digitsCount: inputed.digits,
                 usersSqrt: inputed.sqrt,
                 root: result.sqrtBase,
                 iterations: result.iterations));
}


Main();