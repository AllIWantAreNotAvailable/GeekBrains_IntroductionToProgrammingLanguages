Console.WriteLine("Введите Ваше имя пользователя:");
Console.Write(">>> ");
string username = Console.ReadLine()!;
string favoriteuser = "Tom";
if(username.ToLower() == favoriteuser.ToLower())
{
    Console.Write("Мой любимчик ");
    Console.Write(favoriteuser);
    Console.WriteLine(", снова тут? Привет!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
    Console.WriteLine("!");
};
