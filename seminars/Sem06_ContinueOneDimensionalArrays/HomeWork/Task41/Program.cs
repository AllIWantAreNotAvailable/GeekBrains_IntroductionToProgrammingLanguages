/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223 -> 3
*/


int CountGreaterZero(int[] valueToCount)
{
    int count = 0;

    foreach (int digit in valueToCount) if (0 < digit) count++;

    return count;
}


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


int[] SplitString(string userNumbers)
{
    int[] userArray = new int[StringLengh(userNumbers)];
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
        int.TryParse(newArrayElem, out userArray[userArrayIndex]);
        newArrayElem = "";
    }

    return userArray.Where(elem => elem != 0).ToArray();
}


void UserDialogs(int diaologCode, string inputedArray = "", string textOut = "")
{
    string userDialog = "";

    switch (diaologCode)
    {
        case 0:
            userDialog = "Введите подряд n чисел: ";
            break;
        case 1:
            userDialog = $"Выввели {inputedArray}, из них {textOut}";
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
    return Console.ReadLine()!;
}


void Main()
{
    string userString = UserInput();
    int[] userInputedArray = SplitString(userString);
    int numbersGreaterZero = CountGreaterZero(userInputedArray);
    string textResult = ($"{numbersGreaterZero} чисел больше чем 0");
    UserDialogs(1, $"[{String.Join(", ", userInputedArray)}]", textResult);
}


Main();