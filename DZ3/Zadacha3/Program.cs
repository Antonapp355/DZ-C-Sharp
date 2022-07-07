// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введи число: ");
int N = Convert.ToInt32(Console.ReadLine());
int n = 0;
Cube(N,n);

void Cube(int N, int n)
{
for (n=1; n<N; n++)
{
    Console.WriteLine(n*n*n); 
}

Console.WriteLine(N*N*N);
}