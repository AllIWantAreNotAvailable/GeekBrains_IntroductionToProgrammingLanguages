/*
Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Нельзя использовать библиотеку Math!
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


int Pow(int number, int power)
{
    int result = 1;
    for (int i = 1; i <= power; i++) // Счетчик i инициализируем значением 1, так как по условию задачи степень должна быть "натуральной", а 0 – не является натуральным числом.
    {
        result *= number;
    }
    return result;
}


void UserDialogs(int diaologCode, int resultNumber = 0, params int[] inputedVariables)
{
    string userDialog = "";

    switch(diaologCode)
    {
        case 0:
            userDialog = "Введите число для возведения в степень: ";
            break;
        case 1:
            userDialog = "Введите натуральную степень для вычисления: ";
            break;
        case 2:
            int inputedNumber = inputedVariables[0]; // В первом элементе массива храним введенное пользователем число
            int inputedPower = inputedVariables[1]; // Во втором параметре массива храним введенную пользователем степень числа
            userDialog = $"Мы возвили число {inputedNumber} в степень {inputedPower} и получили результат – {resultNumber}";
            break;
        default:
            userDialog = "Ошибка выбора диалога с пользователем";
            break;
    }
    Console.WriteLine(userDialog);
}


int[] UserInput()
{
    int[] arrayOfUserInputs = new int[2];
    for (int i = 0; i < arrayOfUserInputs.Length; i++)
    {
        UserDialogs(i);
        arrayOfUserInputs[i] = int.Parse(Console.ReadLine()!);
    }
    return arrayOfUserInputs;
}


void main()
{
    int[] numbers = UserInput();
    int result = Pow(number: numbers[0], power: numbers[1]);
    UserDialogs(diaologCode: 2, inputedVariables: numbers, resultNumber: result);
}


main();
