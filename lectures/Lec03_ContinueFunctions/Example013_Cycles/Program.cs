void NewMethod()
{
    for (int i = 0; i < 10; i++)
    {
        for (int j = 2; j < 10; j++)
        {
            Console.WriteLine($"{i} x {j} = {i * j}");
        }
        Console.WriteLine();
    }
}


NewMethod();
