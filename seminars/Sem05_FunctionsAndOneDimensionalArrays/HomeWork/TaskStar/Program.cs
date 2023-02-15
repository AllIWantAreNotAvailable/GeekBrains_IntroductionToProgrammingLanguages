/*
Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сортировку.
[3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1] 
[1,2,2,3,2] -> [3, 2, 2, 2, 1]
*/


void ReverseBubleSort(int[] array)
{
    int upperBound = array.Length; // Инициализируем переменную со значением длины массива
    int indexOfMinValue = 0;
    for (int index = 1; index <= upperBound; index++) // Указываем нестрогое равество переменной index для последней перестановки ведущей пары элементов
    {
        for (int curIndex = 1; curIndex < upperBound; curIndex++) // Вложенный цикл оставляем со строгим равенством для curIndex
        {
            int prevIndex = curIndex - 1;
            if (array[prevIndex] < array[curIndex])
            {
                indexOfMinValue = array[prevIndex];
                array[prevIndex] = array[curIndex];
                array[curIndex] = indexOfMinValue;
            }
        }
        upperBound -= 1; // Уменьшаем длину массива после каждой итерации ведущего цикла, нет смысла проверять крайние элементы, они уже на своих местах
    }
}

void UserDialogs(int caseDialog, string usersStringArray = "", string sorted = "")
{
    string userDialog;

    switch(caseDialog)
    {
        case 0:
            userDialog = "Укажите длину массива: ";
            Console.Write(userDialog);
            break;
        case 1:
            userDialog = $"{usersStringArray} -> [{sorted}]";
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
    ReverseBubleSort(myArray);
    string sortedArray = $"[{string.Join(", ", myArray)}]";
    UserDialogs(1, argMeArray, sortedArray);
}


main();