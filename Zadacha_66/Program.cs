// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} равна {Sum(N, M)}");

int Sum(int N, int M)
{
    if (N < M)
    {
        return sum = N + Sum(N + 1, M);
    }
    if (N > M)
    {
        return sum = N + Sum(N - 1, M);
    }
    else return sum = N;
}
