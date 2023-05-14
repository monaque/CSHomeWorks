// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int UserEnter()
{
    Console.WriteLine("Введите трёхзначное число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int input = UserEnter();

if (input >= 100 && input <= 999)
{
    int result = input / 10 % 10;
    System.Console.WriteLine($"{input} -> {result}");
}
else 
{
    Console.WriteLine("Вы ввели не трёхзначное число");
    input = UserEnter();
}