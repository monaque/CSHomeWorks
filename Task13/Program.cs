// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


int UserEnter()
{
    Console.WriteLine("Введите трёхзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Remainder(int rem)
{
    return rem % 10;
}

int ThreeDigit(int inp)
{
    while (inp > 999)
    {
        inp /= 10;
    }
    return inp;
}

// bool CheckTreeDigit(int userEnter)
// {
//     if (userEnter > 100 && userEnter < 1000)
//     {
//         return true;                                       тут хотел тоже сделать через метод, но понял, что придётся                                                  
//     }                                                         почти всё переделывать, поэтому не стал выпендриваться))
//     else return false;
// }

int input = UserEnter();

if (input > 100 && input < 1000)
{
    int remainder = Remainder(input);
    System.Console.WriteLine($"{input} -> {remainder}");
}

else if (input < 100)
{
    System.Console.WriteLine("Третьей цифры нет!");
}

else
{
    int threeDigit = ThreeDigit(input);
    int result = Remainder(threeDigit);
    System.Console.WriteLine($"{input} -> {result}");
}