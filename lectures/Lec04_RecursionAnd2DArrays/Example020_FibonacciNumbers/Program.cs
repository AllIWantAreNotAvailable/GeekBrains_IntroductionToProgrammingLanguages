/*
f(1) = 1
f(2) = 1
f(n) = f(n-1) + f(n-2)
*/


int ReturnFibonacciNumber(int numberForFibonacci)
{
    if (numberForFibonacci == 1 || numberForFibonacci == 2) return 1;
    else return ReturnFibonacciNumber(numberForFibonacci - 1) + ReturnFibonacciNumber(numberForFibonacci - 2);
}


for (int fibonacciNumber = 1; fibonacciNumber < 50 + 1; fibonacciNumber++)
{
    Console.WriteLine($"F({fibonacciNumber}) = {ReturnFibonacciNumber(fibonacciNumber)}");
}