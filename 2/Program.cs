/*
Задача 4: Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.
*/
Console.Write("Введите число А:");
int A = Convert.ToInt32(Console.ReadLine( ));

Console.Write("Введите число В:");
int B = Convert.ToInt32(Console.ReadLine( ));

Console.Write("Введите число C:");
int C = Convert.ToInt32(Console.ReadLine( ));

int max = A;

if (A > max) max = A;
if (B > max) max = B;
if (C > max) max = C;

Console.Write ("Максимальное из этих чисел =  ");
Console.WriteLine(max);