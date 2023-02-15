/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


void UserDialogs(int diaologCode, params double[] paramsArray)
{
    string userDialog = "";

    switch (diaologCode)
    {
        case 0:
            userDialog = "Введите значение для k1: ";
            break;
        case 1:
            userDialog = "Введите значение для b1: ";
            break;
        case 2:
            userDialog = "Введите значение для k2: ";
            break;
        case 3:
            userDialog = "Введите значение для b2: ";
            break;
        case 4:
            userDialog = $"По указанным Вами параметрам: k1 = {paramsArray[0]} b1 = {paramsArray[1]} и k2 = {paramsArray[2]} b2 = {paramsArray[3]}\n"
                       + "ответ будет: Прямые совпадают друг с другом.";
            break;
        case 5:
            userDialog = $"По указанным Вами параметрам: k1 = {paramsArray[0]} b1 = {paramsArray[1]} и k2 = {paramsArray[2]} b2 = {paramsArray[3]}\n"
                       + "ответ будет: Прямые будут параллельны.";
            break;
        case 6:
            userDialog = $"Две прямые, заданных уравнениями\n\ny = {paramsArray[0]} * {paramsArray[4]} + {paramsArray[1]}\ny = {paramsArray[2]} * {paramsArray[4]}"
                       + $" + {paramsArray[3]}\n\nимеют точку пересечения ({paramsArray[4]:F2}, {paramsArray[5]:F2})";
            break;
        default:
            userDialog = "Ошибка выбора диалога с пользователем";
            break;
    }
    Console.WriteLine(userDialog);
}


bool Validation(double paramK1, double paramB1, double paramK2, double paramB2)
{
    bool validated = false;

    if (paramK1 == paramK2)
    {
        if (paramB1 == paramB2)
        {
            UserDialogs(4, new double[4] { paramK1, paramB1, paramK2, paramB2 });
        }
        else
        {
            UserDialogs(5, new double[4] { paramK1, paramB1, paramK2, paramB2 });
        }
    }
    else
    {
        validated = true;
    }
    return validated;
}


double[] CalculateCrossingPoint(double k1, double b1, double k2, double b2)
{
    // y = k1 * x + b1,
    // y = k2 * x + b2,
    // k1 * x + b1 = k2 * x + b2

    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    return new double[2] { x, y };

}


double[] UserInput()
{
    double[] usersValues = new double[4];
    for (int i = 0; i < usersValues.Length; i++)
    {
        UserDialogs(i);
        usersValues[i] = double.Parse(Console.ReadLine()!);
    }

    return usersValues;
}


void Main()
{
    double[] userInput = UserInput();
    if (Validation(paramK1: userInput[0], paramB1: userInput[1], paramK2: userInput[2], paramB2: userInput[3]))
    {
        double[] dot = CalculateCrossingPoint(k1: userInput[0], b1: userInput[1], k2: userInput[2], b2: userInput[3]);
        UserDialogs(6, new double[6]{userInput[0], userInput[1], userInput[2], userInput[3], dot[0], dot[1]});
    }
}


Main();