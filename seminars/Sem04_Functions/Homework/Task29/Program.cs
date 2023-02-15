/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


bool IsDigitOrNot(char charToCheck)
{
    return int.TryParse(charToCheck.ToString(), out int digit) || charToCheck == '-';
}


int StringLengh(string userString)
{
    int increment = 0;
    userString.Trim();

    for (int index = 0; index < userString.Length; index++)
    {
        char elem = userString[index];
        if (!IsDigitOrNot(elem)) increment += 1;
    }
    return increment + 1;
}


string[] SplitString(string userNumbers)
{
    string[] userArray = new string[StringLengh(userNumbers)];
    string newArrayElem = "";
    int checkIndex = 0;

    for (int userArrayIndex = 0; userArrayIndex < userArray.Length; userArrayIndex++)
    {
        while (checkIndex < userNumbers.Length)
        {
            char stringPosition = userNumbers[checkIndex];
            if (IsDigitOrNot(stringPosition))
            {
                newArrayElem += stringPosition;
                checkIndex++;
            }
            else
            {
                checkIndex++;
                break;
            }
        }
        userArray[userArrayIndex] = newArrayElem;
        newArrayElem = "";
    }

    return userArray.Where(elem => elem != "").ToArray();
}


void UserDialogs(int diaologCode, params string[] array)
{
    string userDialog = "";

    switch (diaologCode)
    {
        case 0:
            userDialog = "Введите подряд n чисел: ";
            break;
        case 1:
            userDialog = $"Вот и Наш массив – [{String.Join(", ", array)}]";
            break;
        default:
            userDialog = "Ошибка выбора диалога с пользователем";
            break;
    }
    Console.WriteLine(userDialog);
}


string UserInput()
{
    UserDialogs(0);
    string userNumber = Console.ReadLine()!;

    return userNumber;
}


void main()
{
    string numbers = UserInput();
    string[] numberArray = SplitString(numbers);
    UserDialogs(diaologCode: 1, numberArray);
}


main();