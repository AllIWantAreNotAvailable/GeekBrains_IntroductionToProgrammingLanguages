

double ReturnFactorial(int inputedNumber)
{
    if (inputedNumber == 0 || inputedNumber == 1) return 1; // По определению факториала установлено, что 0! = 1, а 1! логичнее вернуть сразу.
    return inputedNumber * ReturnFactorial(inputedNumber - 1);
}

for (int numFuctorial = 0; numFuctorial < 40 + 1; numFuctorial++)
{
    Console.WriteLine($"{numFuctorial}! = {ReturnFactorial(numFuctorial)}");
}