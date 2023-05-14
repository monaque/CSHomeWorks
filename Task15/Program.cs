// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


int UserEnter()
{
    Console.WriteLine("Введите порядковый номер дня недели: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int userEnter = UserEnter();
if (userEnter > 0 && userEnter <= 5)
{
    System.Console.WriteLine("Будний день.");
}
else if (userEnter > 5 && userEnter <= 7)
{
    System.Console.WriteLine("Выходной!");
}
else 
{
    System.Console.WriteLine("Нет такого дня.");
}