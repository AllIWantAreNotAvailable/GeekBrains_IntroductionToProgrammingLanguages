/*
Задача со звездочкой: Написать программу для перевода римских чисел в десятичные арабские.

III -> 3
LVIII -> 58
MCMXCIV -> 1994
MDCLXVI -> 1666
MCMXC -> 1990
MMVIII –> 2008
*/


string UserInput()
{
    Console.Write("Введите число Римскими цифрами:\n>>> ");
    string inputed = Console.ReadLine()!;
    return inputed.ToUpper();
}


int ConvertRomanToArabic(string argUsersRomanNumber)
{
    Dictionary<string, int> romanToArabic = new Dictionary<string, int>()
    { {"I", 1}, {"V", 5}, {"X", 10}, {"L", 50}, {"C", 100}, {"D", 500}, {"M", 1000} };

    char[] stringToReverse = argUsersRomanNumber.ToCharArray();
    Array.Reverse(stringToReverse);
    string reversedRoman = new string(stringToReverse);

    int previousNumber = 0, convertedToArabic = 0;

    foreach (char romanNumeral in reversedRoman)
    {
        if (romanToArabic.TryGetValue(romanNumeral.ToString(), out int arabicNumeral))
        {
            convertedToArabic += arabicNumeral < previousNumber ? -arabicNumeral : arabicNumeral;
            previousNumber = arabicNumeral;
        }
    }

    return convertedToArabic;
}

void Main()
{
    string usersRomanNumber = UserInput();
    int convertedarabicNumber = ConvertRomanToArabic(usersRomanNumber);
    System.Console.WriteLine($"{usersRomanNumber} –> {convertedarabicNumber}");
}

Main();