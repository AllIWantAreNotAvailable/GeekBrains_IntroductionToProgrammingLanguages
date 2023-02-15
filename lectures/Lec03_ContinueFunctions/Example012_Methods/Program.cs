// Вид 1: Ничего не принимают, ничего не возвращают
void FirstGroupOfMethod()
{
    Console.Write("Первая группа методов...\nAutor: ");
}


// Вид 2: Что-то принимают, но ничего не возвращают
void SecondGroupOfMethod(string autor)
{
    System.Console.WriteLine($"{autor} (c) Имя автора отправлено из второй группы методов...");
}

// Вид 3: Ничего не принимают, но что-то возвращают
int ThirdGroupIfMethod()
{
    return DateTime.Now.Year;
}

// Вид 4: Что-то принимают, что-то возвращают
string[] FourthGroupOfMethods(int count, string phrase)
{
    string[] result = new String[count];
    for (int i = 0; i < count; i++)
    {
        result[i] = phrase + " ";
    }
    return result;
}


FirstGroupOfMethod();
SecondGroupOfMethod(autor: "@ti_prikin"); // Явное указание параметра для передаваемого аргумента
int year = ThirdGroupIfMethod();
Console.WriteLine();
Console.WriteLine($"Сейчас {year} год, его нам вернули из 3-й группы методов");
Console.WriteLine();
string[] ourString = FourthGroupOfMethods(3, "Я собака, ты собака.");
Console.WriteLine($"А тут стишок из 4-й группы методов:\n{String.Join("\n", ourString)}");
