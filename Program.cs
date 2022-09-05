﻿//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
void cross_coordinates(double k1, double b1, double k2, double b2)
{
double x = (b1-b2) / (k2-k1);
double y = (k2*b1-k1*b2) / (k2-k1);
if( k1 == k2 ) Console.Write("Заданные прямые не пересекаются!");
else Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
}
Console.WriteLine("Введите координату b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
cross_coordinates(k1,b1,k2,b2);