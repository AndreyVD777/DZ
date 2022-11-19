/*                                          Урок 2. Базовые алгоритмы
   Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
   Обязательна проверка на ввод чисел больше/меньше 3-х знаков   */
/*
Console.Write("Entered number ");
string N2 = Console.ReadLine()!;
if (N2.Length != 3)
{
    Console.WriteLine("invalid entered numbers");
}
else
{
    Console.WriteLine($"entered numbers {N2[1]}");
}
*/

/*   Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет. Берем числа до 100000   */

/*
Console.Clear();
Console.Write("Entered number ");
string N2 = Console.ReadLine()!;
if (N2.Length < 3 || N2.Length > 5)
{
    Console.WriteLine("Третьей цифры нет или введено число более 100000");
}
else
{
    Console.WriteLine($"третья цифра {N2[2]}");
}
*/


/*   Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
     является ли этот день выходным. Обязательна проверка на ввод числа <1 и 7>   */
/*
Console.Clear();
Console.Write("Entered number ");
int num = int.Parse(Console.ReadLine()!);
int v1 = 6;
int v2 = 7;
if (num >= 1 && num < 8)
    {
    if (v1 == num || v2 == num)
    {
        Console.Write("выходной");
    }
    else
        Console.Write($"ВВеденое число {num} не является выходным днем недели");
    }
else
        Console.Write($"Ошибка, введите число от <1 до 7>");
*/
