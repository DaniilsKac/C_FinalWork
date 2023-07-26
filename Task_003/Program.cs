Console.Clear();
Console.WriteLine($"Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.\nm = 2, n = 3 -> A(m,n) = 9\nm = 3, n = 2 -> A(m,n) = 29");

Console.Write($"\nВведите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int AkkermanNumber(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AkkermanNumber(m - 1, 1);
    else return AkkermanNumber(m - 1, AkkermanNumber(m, n - 1));
}

Console.WriteLine($"\nРезультат: {AkkermanNumber(m,n)}");