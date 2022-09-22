/*
Задача 2:Напишите программу, которая на вход принимает 
2 числа и выдает, какое число больше, а какое меньше
*/



Console.Write("Введите число А:");
int A = Convert.ToInt32(Console.ReadLine( ));
Console.Write("Введите число В:");
int B = Convert.ToInt32(Console.ReadLine( ));

if (A > B)
{
    Console.WriteLine("{0} наибольшее число", A);
    Console.WriteLine("{0} наименьшее число", B);
}
else
{
    Console.WriteLine("{0} наибольшее число", B);
    Console.WriteLine("{0} наименьшее число", A);  
}