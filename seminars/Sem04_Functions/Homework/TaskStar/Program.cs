/*
Задача “со звездочкой”: Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками. (Пример см. презентацию)
*/


string makeTree(int height, int span)
{
    string tree = "";
    int trunk = span / 2;
    for (int heightIncrement = 0; heightIncrement < height; heightIncrement++)
    {
        for (int spanIncrement = 0; spanIncrement < span + 1; spanIncrement++)
        {
            if (spanIncrement < trunk - heightIncrement)
            {
                tree += UserDialogs(1);
            }
            else if (trunk + heightIncrement < spanIncrement)
            {
                tree += UserDialogs(1);
            }
            else if (trunk - heightIncrement < spanIncrement)
            {
                tree += UserDialogs(2);
            }
            else if (spanIncrement == trunk)
            {
                tree += UserDialogs(2);
            }
            else
            {
                tree += UserDialogs(2);
            }
        }
        tree += "\n";
    }

    return tree;
}

void DrawingTree(int treeHeight)
{
    int branchSpan = treeHeight * 2 + 1;
    string tree = makeTree(treeHeight, branchSpan);
    Console.WriteLine(tree);
}

string UserDialogs(int caseNum)
{
    string userDialog = "";

    switch(caseNum)
    {
        case 0:
            userDialog = "Введите высоту Ёлочки: ";
            break;
        case 1:
            userDialog = " ";
            break;
        case 2:
            userDialog = "*";
            break;
        default:
            userDialog = "Ошибка выбора диалога с пользователем";
            break;
    }

    return userDialog;
}


int UserInput()
{
    Console.Write(UserDialogs(0));
    int HeightsOfYolka = int.Parse(Console.ReadLine()!);
    return HeightsOfYolka;
}


void main()
{
    Console.Clear();
    int height = UserInput();
    DrawingTree(height);
}

main();