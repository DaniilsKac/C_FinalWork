Console.Clear();
Console.WriteLine($"Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.\nM = 1; N = 15 -> 120\nM = 4; N = 8. -> 30");

Console.Write($"\nВведите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int start, int end)
{
    if (start > end) return 0;
    return start + SumNumbers(start + 1, end);
}

Console.WriteLine($"Сумма чисел в промежутке от {M} до {N}: {SumNumbers(M,N)}");