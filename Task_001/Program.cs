Console.Clear();
Console.WriteLine($"Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.\nN = 5 -> 5, 4, 3, 2, 1\nN = 8 -> 8, 7, 6, 5, 4, 3, 2, 1");

Console.Write($"\nВведите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return start + ", " + PrintNumbers(start - 1, end);
}

Console.WriteLine($"Числа от {N} до 1: {PrintNumbers(N,1)}");