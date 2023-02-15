/*
Задача со звездочкой: Пользователь вводит скобочные последовательности. В последовательности могут встретиться скобки вида: {}, (), [].
Правильная скобочная последовательность - символьная последовательность, составленная в алфавите, состоящем из символов, сгруппированных
в упорядоченные пары.
Пример правильной скобочной последовательности: (), ()[]{} Пример неправильной: (], ({)}
Написать программу, которая определяет правильная ли скобочная последовательность была введена
*/


char[] DelLast(char[] array)
{
    char[] resizedArray = new char[array.Length - 1];
    for (int index = 0; index < resizedArray.Length; index++)
    {
        resizedArray[index] = array[index];
    }
    return resizedArray;
}


char[] AppEnd(char[] array, char symbol)
{

    char[] resizedArray = new char[array.Length + 1];
    for (int index = 0; index < array.Length; index++)
    {
        resizedArray[index] = array[index];
    }
    resizedArray[resizedArray.Length - 1] = symbol;
    return resizedArray;
}


(Dictionary<char, char>, Dictionary<char, char>) GetBracketsPairs()
{
    Dictionary<char, char> openClosePair = new Dictionary<char, char>
                                          {
                                            {'(', ')'},
                                            {'[', ']'},
                                            {'{', '}'}
                                          };
    Dictionary<char, char> closeOpenPair = new Dictionary<char, char>
                                          {
                                            {')', '('},
                                            {']', '['},
                                            {'}', '{'}
                                          };
    return (openClosePair, closeOpenPair);
}


bool IsSequenceValid(string usersString)
{
    (Dictionary<char, char> openPair, Dictionary<char, char> closePair) brackets = GetBracketsPairs();
    char[] stack = new char[0];
    char bracket;

    for (int charIndex = 0; charIndex < usersString.Length; charIndex++)
    {
        char charElem = usersString[charIndex];
        if (brackets.openPair.TryGetValue(charElem, out bracket))
        {
            stack = AppEnd(stack, charElem);
        }
        else if (brackets.closePair.TryGetValue(charElem, out bracket))
        {
            if (stack.Length == 0) return false;
            if (stack[stack.Length -1] == bracket) stack = DelLast(stack);
            else return false;
        }
        else continue;
    }
    return true;
}


void Main()
{
    Console.Write("Введите скобочную последовательность:\n>>> ");
    string usersSequence = Console.ReadLine()!;
    bool flag = IsSequenceValid(usersSequence);
    string result = flag ? "правильная" : "неправильная";
    System.Console.WriteLine($"Введена {result} скобочная последовательность");
}


Main();