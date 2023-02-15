/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double DifferenceOfMaximumMinValues(double[] array)
{
    double differenceOfMaximumMinValues;
    double maxValue = array[0]; // Принимаем за максимальное значение первый элемент массива
    double minValue = array[0]; // Принимаем за минимальное значение первый элемент массива
    foreach (double elem in array)
    {
        if (maxValue < elem) maxValue = elem;
        if (elem < minValue) minValue = elem;
    }
    differenceOfMaximumMinValues = maxValue - minValue;
    return Math.Round(differenceOfMaximumMinValues, 2, MidpointRounding.ToZero);
}

void UserDialogs(int caseDialog, string usersStringArray = "", double difference = 0)
{
    string userDialog;

    switch(caseDialog)
    {
        case 0:
            userDialog = "Укажите длину массива: ";
            Console.Write(userDialog);
            break;
        case 1:
            userDialog = $"{usersStringArray} -> {difference}";
            Console.WriteLine(userDialog);
            break;
        default:
            userDialog = "Ошибка выбора диалога с пользователем";
            Console.WriteLine(userDialog);
            break;
    }
}


double[] GetRandFloatingPointArray()
{
    UserDialogs(0);
    int arrayLeght = int.Parse(Console.ReadLine()!);
    double[] arrayOfRandDoubles = new double[arrayLeght];
    for (int index = 0; index < arrayOfRandDoubles.Length; index++)
    {
        int intPart = new Random().Next(0, 99 + 1);
        double fractPart = new Random().NextDouble();
        arrayOfRandDoubles[index] = Math.Round(intPart + fractPart, 2, MidpointRounding.ToZero);
    }
    return arrayOfRandDoubles;
}


void main()
{
    double[] myArray = GetRandFloatingPointArray();
    string argMeArray = $"[{string.Join(", ", myArray)}]";
    double differenceOfMaxMin = DifferenceOfMaximumMinValues(myArray);
    UserDialogs(1, argMeArray, differenceOfMaxMin);
}


main();