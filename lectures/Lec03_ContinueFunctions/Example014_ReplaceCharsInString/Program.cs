/*
Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими "с".
*/


string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";

    }
    return result;
}


string text = "– Я думаю, – сказал князь, улыбаясь, – что, "
            + "ужели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string  s = "qwerty"
//       index: 012345
// s[3] == "r"

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
System.Console.WriteLine();