// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125


System.Console.WriteLine("Введите число: ");
int userEnter = Convert.ToInt32(Console.ReadLine());

Cube(userEnter);

void Cube(int num)
{
    int count = 1;
    System.Console.WriteLine($"{num} ->");
    while (count <= num)
    {
        System.Console.WriteLine($"{count, 3} | {count * count * count}");
        count++;
    }
}