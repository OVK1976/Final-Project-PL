/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3->A(m, n) = 9
m = 3, n = 2->A(m, n) = 29 */
Console.WriteLine("Введите положительное число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите положительное число n");
int n = int.Parse(Console.ReadLine());
if (m<0 || n<0)
{
    Console.WriteLine("Введено отрицательное число. Повторите ввод");
}
else
{
    Console.Write($"Функция Аккермана равна: {AkkermanFunction(m, n)}");
}


// функция Аккермана
int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (n == 0 && m > 0)
        {
            return AkkermanFunction(m - 1, 1);
        }
        else
        {
            return (AkkermanFunction(m - 1, AkkermanFunction(m, n - 1)));
        }
    }
}
