/*
 Задача 64: 
Задайте значение N. Напишите программу, которая выведет все натуральные 
числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
Пример:
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.WriteLine("Программа вывода натуральных чисел от от N до 1");
Console.WriteLine("Введите натуральное число N (больше 1)");
int n = int.Parse(Console.ReadLine());
if (n < 1)
{
    Console.WriteLine("Введено не натуральное число");
}
else
{
    Console.WriteLine($"Ряд от {n} до 1: ");
    Console.WriteLine(NumbersPrintFromNTo1Recursion(1, n));
}

#region
string NumbersPrintFromNTo1Recursion(int a, int n)
{
    if (a <= n)
    {
        return NumbersPrintFromNTo1Recursion(a + 1, n) + $"{a} ";
    }
    else
    {
        return String.Empty;
    }
}

#endregion