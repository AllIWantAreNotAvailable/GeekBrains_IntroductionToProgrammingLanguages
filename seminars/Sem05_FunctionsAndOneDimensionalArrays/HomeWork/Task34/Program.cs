/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int EvenCounter(int[] array)
{
    int evenCount = 0;
    foreach (int elem in array)
    {
        if (elem % 2 == 0) evenCount++;
    }
    return evenCount;
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


int[] GetRand3DigitsArray()
{
    UserDialogs(0);
    int arrayLeght = int.Parse(Console.ReadLine()!);
    int[] arrayOfRandInts = new int[arrayLeght];
    for (int index = 0; index < arrayOfRandInts.Length; index++)
    {
        arrayOfRandInts[index] = new Random().Next(100, 999 + 1);
    }
    return arrayOfRandInts;
}


void main()
{
    int[] myArray = GetRand3DigitsArray();
    string argMeArray = $"[{string.Join(", ", myArray)}]";
    int evenNumberCounter = EvenCounter(myArray);
    UserDialogs(1, argMeArray, evenNumberCounter);
}


main();