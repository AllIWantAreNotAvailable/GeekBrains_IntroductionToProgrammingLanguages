/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/


bool IsSuchTriangle((int ab, int bc, int ac) triangleSides)
{
    return triangleSides.ab < triangleSides.bc + triangleSides.ac
        && triangleSides.bc < triangleSides.ab + triangleSides.ac
        && triangleSides.ac < triangleSides.bc + triangleSides.ab;
}


(bool, int, int, int) GetSidesOfTriangle()
{
    (bool  error, int ab, int bc, int ca) triangle;
    triangle.error = false;
    
    Console.WriteLine("Укажите стороны треугольника ABC:");
    Console.Write("- введите сторону AB:\n>>> ");
    triangle.error = !int.TryParse(Console.ReadLine(), out triangle.ab);
    Console.Write("- введите сторону BC:\n>>> ");
    triangle.error = !int.TryParse(Console.ReadLine(), out triangle.bc);
    Console.Write("- введите сторону CA:\n>>> ");
    triangle.error = !int.TryParse(Console.ReadLine(), out triangle.ca);

    return triangle;
}


void Main()
{
    (bool  error, int ab, int bc, int ac) triangle = GetSidesOfTriangle();
    if (triangle.error)
    {
        Console.WriteLine("Не удалось преобразовать строку к числу.");
        return;
    }
    string resultOutput = IsSuchTriangle((ab: triangle.ab,
                                          bc: triangle.bc,
                                          ac: triangle.ac
                                         )
                                        )
                        ? "Существует!"
                        : "Не существует ;(";
    Console.WriteLine("Треугольник ABC со сторонами:\n"
                    +$"- AB = {triangle.ab};\n"
                    +$"- BC = {triangle.bc};\n"
                    +$"- CA = {triangle.ac};\n"
                    +$"{resultOutput}");

}


Main();