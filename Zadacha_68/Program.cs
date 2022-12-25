// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Введите значение неотрицательного числа M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение неотрицательного числа N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат вычислений равен: {Akkerman(M, N)}");

int Akkerman(int M, int N)
{
    if (M == 0)
        return (N+ 1);
    else if (N == 0)
        return Akkerman(M - 1, 1);
    return Akkerman(M - 1, Akkerman(M, N - 1));
}


