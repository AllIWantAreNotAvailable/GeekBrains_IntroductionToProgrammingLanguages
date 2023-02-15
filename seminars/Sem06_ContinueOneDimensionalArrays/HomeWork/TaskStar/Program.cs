/*
Задача со звездочкой. Напишите программу, которая реализует обход введенного двумерного массива,
начиная с крайнего нижнего левого элемента против часовой стрелки.
1 2 3
4 5 6 -> 7 8 9 6 3 2 1 4 5
7 8 9
*/


int[,] Return2DArray(int rowsCount = 3, int columnsCount = 3, int minValue = 0, int maxValue = 10)
{
    int[,] matrixInt = new int[rowsCount, columnsCount];
    Random randInt = new Random();

    for (int row = 0; row < matrixInt.GetLength(0); row++)
    {
        for (int column = 0; column < matrixInt.GetLength(1); column++)
        {
            matrixInt[row, column] = randInt.Next(minValue, maxValue);
        }
    }

    return matrixInt;
}


void OutputValuesFromBottomLeftCornerCounterclockwise(int[,] twoDemArray)
{
    int upperBoundary = 0;
    int rightBoundary = twoDemArray.GetLength(0) - 1;
    int lowerBoundary = twoDemArray.GetLength(1) - 1;
    int leftBoundary = 0;

    bool right = true;
    bool down = false;
    bool next = true;

    int row = lowerBoundary;
    int column = 0;


    Console.Write($"{twoDemArray[row, column]} ");
    for (int i = 0; i < twoDemArray.Length - 1; i++)
    {
        if (right && next)
        {
            Console.Write($"{twoDemArray[row, ++column]} "); // вправо
            if (column == rightBoundary)
            {
                lowerBoundary--;
                right = !right;
                next = right;
            }
        }
        else if (!down)
        {
            Console.Write($"{twoDemArray[--row, column]} "); // вверх
            if (row == upperBoundary)
            {
                rightBoundary--;
                down = !down;
            }
        }
        else if (!right)
        {
            Console.Write($"{twoDemArray[row, --column]} "); // влево
            if (column == leftBoundary)
            {
                upperBoundary++;
                right = !right;
            }

        }
        else
        {
            Console.Write($"{twoDemArray[++row, column]} "); // вниз
            if (row == lowerBoundary)
            {
                leftBoundary++;
                next = down;
                down = !down;
            }
        }
    }
    Console.WriteLine();
}


void Print2DArray(int[,] users2DArray)
{
    for (int row = 0; row < users2DArray.GetLength(0); row++) // users2DArray.GetLength(0) – Возвращает кол-во строк двумерного массива
    {
        Console.Write("|\t");
        for (int column = 0; column < users2DArray.GetLength(1); column++) // users2DArray.GetLength(1) – Возвращает кол-во столбцов двумерного массива
        {
            Console.Write($"{users2DArray[row, column]}");
            if (0 <= column && column < users2DArray.GetLength(1) - 1) Console.Write("\t|\t");
        }
        Console.WriteLine("\t|");
    }
}


void UserDialogs(int diaologCode)
{
    string userDialog = "";

    switch (diaologCode)
    {
        case 0:
            userDialog = "Настроить создаваемый двумерный массив?\n(Y for Yes, Any key for No)\n>>> ";
            break;
        case 1:
            userDialog = "Введите количество строк двумерного массива: ";
            break;
        case 2:
            userDialog = "Введите количество столбцов двумерного массива: ";
            break;
        case 3:
            userDialog = "Введите минимальное значение для заполнения двумерного массива: ";
            break;
        case 4:
            userDialog = "Введите максимальное значение для заполнения двумерного массива: ";
            break;
        default:
            userDialog = "Ошибка выбора диалога с пользователем";
            break;
    }
    Console.Write($"{userDialog}");

}


int[,] SetingsMenu()
{
    int[,] myRandIntMatrix;
    UserDialogs(0); // Спрашиваем, желают ли задать собственные настройки создаваемого двумерного массива
    switch (Console.ReadKey().Key)
    {
        case ConsoleKey.Y:
            Console.WriteLine();
            UserDialogs(1); // Приглашение ко вводу кол-ва строк
            int rows = int.Parse(Console.ReadLine()!);
            UserDialogs(2); // Приглашение ко вводу кол-ва столбцов
            int columns = int.Parse(Console.ReadLine()!);
            UserDialogs(3); // Приглашение ко вводу мин значения заполнения
            int min = int.Parse(Console.ReadLine()!);
            UserDialogs(4); // Приглашение ко вводу макс значения заполнения
            int max = int.Parse(Console.ReadLine()!);

            myRandIntMatrix = Return2DArray(rows, columns, min, max);
            break;
        default:
            Console.WriteLine();
            myRandIntMatrix = Return2DArray();
            break;
    }
    return myRandIntMatrix;
}


void Main()
{
    int[,] myRandIntMatrix = SetingsMenu();
    Print2DArray(myRandIntMatrix);

    Console.WriteLine();
    OutputValuesFromBottomLeftCornerCounterclockwise(myRandIntMatrix);
}


Main();