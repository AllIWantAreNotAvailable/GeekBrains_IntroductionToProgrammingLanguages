Console.Clear();
// Console.SetCursorPosition(10,4);
// Console.WriteLine("+");

int xA = 50, yA = 1;
int xB = 1, yB = 30;
int xC = 99, yC = 30;

Console.SetCursorPosition(xA, yA);
Console.WriteLine("+");
Console.SetCursorPosition(xB, yB);
Console.WriteLine("+");
Console.SetCursorPosition(xC, yC);
Console.WriteLine("+");

int XDot = xA, YDot = yA;
int increment = 0;

while (increment < 10000)
{
    int randint = new Random().Next(0, 3); // [0, 3) -> [0, 1, 2]

    if (randint == 0)
    {
        XDot = (XDot + xA) / 2;
        YDot = (YDot + yA) / 2;
    }
    if (randint == 1)
    {
        XDot = (XDot + xB) / 2;
        YDot = (YDot + yB) / 2;
    }
    if (randint == 2)
    {
        XDot = (XDot + xC) / 2;
        YDot = (YDot + yC) / 2;
    }
    
    Console.SetCursorPosition(XDot, YDot);
    Console.WriteLine("+");
    increment++;
}