//                             Урок 1. Знакомство с языком программирования С#


//   Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*Console.Write("Введите число №1- ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите число №2- ");
int numberB = int.Parse(Console.ReadLine()!);

if (numberA > numberB)
{
    Console.WriteLine($"максимальное число {numberA}, минимальное число {numberB}");
}
else
{
    if (numberB > numberA)
    {
        Console.WriteLine($"максимальное число {numberB}, минимальное число {numberA}");
    }
    else
    {
        Console.WriteLine($"число {numberB} равно числу {numberA}");
    }
}
*/



//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Clear();
Console.Write("Введите число №1 - ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите число №2 - ");
int numberB = int.Parse(Console.ReadLine()!);
Console.Write("Введите число №3 - ");
int numberC = int.Parse(Console.ReadLine()!);
int max = 0;
if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;
Console.WriteLine($"максимальное число {max}");
*/


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Clear();
Console.WriteLine("введите число");
int num = int.Parse(Console.ReadLine()!);
if (num%2==0)
{
    Console.WriteLine($"{num} четное");
}
else
{
    Console.WriteLine($"{num} нечетное");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//Первое решение
/*
Console.Clear();
Console.Write("Entered number N-");
int N = int.Parse(Console.ReadLine()!);
int L = 1;
while (L <= N)
{
    if (L % 2 == 0)
    {
        Console.Write($"{L} ");
    }
    L++;
}
*/
//Второе решение
/*
Console.Clear();
Console.Write("Entered number N-");
int N = int.Parse(Console.ReadLine()!);
for (int L = 1; L <= N; L++)
    if (L % 2 == 0)
    {
        Console.Write($"{L} ");
    }
*/
