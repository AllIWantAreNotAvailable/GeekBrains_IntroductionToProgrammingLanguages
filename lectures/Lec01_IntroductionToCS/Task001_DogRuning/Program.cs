// Задача 1
// Два друга идут навстречу друг гругу. Собака бегает от одного друга к другому. Вопрос, сколько раз собака приодалеет сокращающуюся дистанцию до того как друзья встретяться?
// Дано:
// - Дистанция = 10 000
// - Скорость первого друга = 1
// - Скорость второго друга = 2
// - Скорость собаки = 5
// - Начальное направление – от друга 1 к другу 2 
// <{ Решение
double distance = 10000, FirstFriendSpeed = 1, SecondFriendSpeed = 2, DogSpeed = 5, time = 0;
int direction = 2, count = 0;
while (distance > 10)
{
    if (direction == 2)
    {
        time = distance / (SecondFriendSpeed + DogSpeed);
        direction = 1;
    }
    else
    {
        time = distance / (FirstFriendSpeed + DogSpeed);
        direction = 1;
    }
    distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * time;
    count++;
}
Console.WriteLine($"Собака преодалеет дистанцию {count} раз, до того как друзья встретяться.");
// }>  Конец решения