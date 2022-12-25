// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.WriteLine("Введите значение n: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Натуральные числа от {N} до 1 равна ");
Numbers(N);




void Numbers(int N)
{
    if (N == 0) return;
    System.Console.Write($"{N} ");
    Numbers(N - 1);
}


