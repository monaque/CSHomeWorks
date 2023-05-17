// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты первой точки по оси X: ");
int aX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки по оси Y: ");
int aY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки по оси Z: ");
int aZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки по оси X: ");
int bX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки по оси Y: ");
int bY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки по оси Z: ");
int bZ = Convert.ToInt32(Console.ReadLine());

double distance = Distance (aX, aY, aZ, bX, bY, bZ);

Console.WriteLine(Math.Round(distance, 2 , MidpointRounding.ToZero));

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
int cathetus1 = x2 - x1;
int cathetus2 = y2 - y1;
int cathetus3 = z2 - z1;
double distanceIn3D = Math.Sqrt(cathetus1 * cathetus1 + cathetus2 * cathetus2 + cathetus3 * cathetus3);
return distanceIn3D;
}