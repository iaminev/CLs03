/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B(2, 1, -7), -> 15.84
A(7, -5, 0); B(1, -1, 9)-> 11.53*/

double Distance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double d = 0;
    d = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
    return d;
}

Console.Write("Enter X1: ");
int x1 = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Enter Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Enter Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Enter X2: ");
int x2 = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Enter Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Enter Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine()!);


System.Console.WriteLine($"{Distance3D(x1, y1, z1, x2, y2, z2)}");