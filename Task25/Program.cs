// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


int inputNumberA = UserEnter("Введите первое чило: ");
int inputNumberB = UserEnter("Введите второе чило: ");

if (ValidateExponent(inputNumberB))
{
    Console.WriteLine($"Число {inputNumberA} в степени {inputNumberB} ровно {Exponentiation(inputNumberA, inputNumberB)}");
}

int UserEnter(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Exponentiation(int inputNumberA, int inputNumberB)
{
    int numA = 1;
    for (int i = 0; i < inputNumberB; i++)
    {
        numA *= inputNumberA;
    }
    return numA;
}

bool ValidateExponent(int inputNumberB)
{
    if (inputNumberB < 0)
    {
        Console.WriteLine("Число должно быть больше нуля!");
        return false;
    }
    return true;
}

