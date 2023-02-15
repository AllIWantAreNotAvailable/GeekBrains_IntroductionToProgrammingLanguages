/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetSumOfDigits(int userNumber)
{
    if (userNumber == 0) return 0; // Если пользователь ввел 0, то сразу возвращаем 0, выполнять тело функции нет смысла

    bool negativeNumber = false; // Тригер отрицательного числа
    
    if (userNumber < 0) // Если пользователь ввел отрицательное число, то
    {
        negativeNumber = true; // - во-первых, поднимаем тригер
        userNumber *= -1; // - во-вторых, преобразуем число в положительное, для корректного сложения значений разрядов
    }

    int sum = userNumber % 10;

    while (userNumber > 0)
    {
        sum += (userNumber / 10 % 10);
        userNumber /= 10;
    }

    if (negativeNumber) sum *= -1; // Если тригер поднят, то переводим сумму цифр разрядов в отрицательное число

    return sum;
}


void UserDialogs(int diaologCode, int inputedNumber = 0, int sumOfDigits = 0)
{
    string userDialog = "";

    switch(diaologCode)
    {
        case 0:
            userDialog = "Введите число: ";
            break;
        case 1:
            userDialog = $"Мы сложили все цифры числа {inputedNumber} и получили результат {sumOfDigits}";
            break;
        default:
            userDialog = "Ошибка выбора диалога с пользователем";
            break;
    }
    Console.WriteLine(userDialog);
}


int UserInput()
{
    UserDialogs(0);
    int userNumber = int.Parse(Console.ReadLine()!);
    
    return userNumber;
}


void main()
{
    int number = UserInput();
    int sum = GetSumOfDigits(number);
    UserDialogs(diaologCode: 1, inputedNumber: number, sumOfDigits: sum);
}


main();