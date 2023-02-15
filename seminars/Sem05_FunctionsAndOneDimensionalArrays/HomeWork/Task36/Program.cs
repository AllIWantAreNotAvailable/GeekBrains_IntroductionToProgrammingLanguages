/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int SumOfOddPositions(int[] array)
{
    int oddPositionSum = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (index % 2 != 0) oddPositionSum += array[index];
    }
    return oddPositionSum;
}

void UserDialogs(int caseDialog, string usersStringArray = "", int evenArrayCount = 0)
{
    string userDialog;

    switch(caseDialog)
    {
        case 0:
            userDialog = "Укажите длину массива: ";
            Console.Write(userDialog);
            break;
        case 1:
            userDialog = $"{usersStringArray} -> {evenArrayCount}";
            Console.WriteLine(userDialog);
            break;
        default:
            userDialog = "Ошибка выбора диалога с пользователем";
            Console.WriteLine(userDialog);
            break;
    }
}


int[] GetRandIntArray()
{
    UserDialogs(0);
    int arrayLeght = int.Parse(Console.ReadLine()!);
    int[] arrayOfRandInts = new int[arrayLeght];
    for (int index = 0; index < arrayOfRandInts.Length; index++)
    {
        arrayOfRandInts[index] = new Random().Next(0, 99 + 1);
    }
    return arrayOfRandInts;
}


void main()
{
    int[] myArray = GetRandIntArray();
    string argMeArray = $"[{string.Join(", ", myArray)}]";
    int numberInOddPosSum = SumOfOddPositions(myArray);
    UserDialogs(1, argMeArray, numberInOddPosSum);
}


main();