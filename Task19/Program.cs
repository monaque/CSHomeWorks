// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

int userEnter = UserEnter();
bool checkCorrect = CheckCorrect(userEnter);
if (checkCorrect)
{
    Division();
}
else 
{
    System.Console.WriteLine("Вы ввели не пятизначное число!");
}

int UserEnter()
{
    Console.WriteLine("Введите пятизначное число для проверки на палиндром: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool CheckCorrect(int input)
{
    if (input >= 10000 && input <= 99999) return true;
    else return false;
}

void Division()
{
    int number5 = userEnter % 10;
    int number4 = userEnter / 10 % 10;
    int number2 = userEnter / 1000 % 10;
    int number1 = userEnter / 10000 % 10;

    if (number1 == number5 && number2 == number4)
    {
        System.Console.WriteLine($"{userEnter} -> Да");
    }
    else
    {
        System.Console.WriteLine($"{userEnter} -> Нет");
    }
}