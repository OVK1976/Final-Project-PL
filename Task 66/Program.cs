/*
 Задача 66: 

Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите значение M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение N");
int n = int.Parse(Console.ReadLine());

    if (m < n)
    {
        Console.WriteLine($"Сумма элементов от {m} до {n} равна: {SumFromMToN(m, n)}");
    }
    else
    {
        Console.WriteLine($"Сумма элементов от {n} до {m} равна:{SumFromMToN(n, m)}");
    }

#region Сумма элементов от M до N
int SumFromMToN(int m, int n)
{
    int SumNum = 0;
    for (int i = m; i <= n; i++)
    {
        SumNum += i;
    }
    return SumNum;
}
#endregion