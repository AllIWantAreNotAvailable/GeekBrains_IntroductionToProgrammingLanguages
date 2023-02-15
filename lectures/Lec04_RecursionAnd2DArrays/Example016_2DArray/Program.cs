

void initString2DArray()
{
    // В объявлении и в дальнейшем при обращении в [строка, столбец]
    string[,] table = new string[4, 5]; // defult String.Empty
    // table[0, 0]      table[0, 1]      table[0, 2]      table[0, 3]      table[0, 4]
    // table[1, 0]      table[1, 1]      table[1, 2]      table[1, 3]      table[1, 4]

    table[0, 0] = " Заголовок1 "; table[0, 1] = " Заголовок2 "; table[0, 2] = " Заголовок3 "; table[0, 3] = " Заголовок4 "; table[0, 4] = " Заголовок5 ";
    table[1, 0] = "------------"; table[1, 1] = "------------"; table[1, 2] = "------------"; table[1, 3] = "------------"; table[1, 4] = "------------";
    table[2, 0] = "  Данные1   "; table[2, 1] = "  Данные1   "; table[2, 2] = "  Данные1   "; table[2, 3] = "  Данные 1  "; table[2, 4] = "  Данные1   ";
    table[3, 0] = "------------"; table[3, 1] = "------------"; table[3, 2] = "------------"; table[3, 3] = "------------"; table[3, 4] = "------------";

    for (int row = 0; row < table.GetLength(0); row++) // table.GetLength(0) – Возвращает кол-во строк двумерного массива
    {
        Console.Write("|");
        for (int column = 0; column < table.GetLength(1); column++) // table.GetLength(1) – Возвращает кол-во столбцов двумерного массива
        {
            Console.Write($"{table[row, column]}");
            if (0 <= column && column < table.GetLength(1) - 1) Console.Write("|");
        }
        Console.WriteLine("|");
    }
}


initString2DArray();