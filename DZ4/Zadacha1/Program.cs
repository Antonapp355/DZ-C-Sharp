// Задача 25: Напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень в которую его возвести: ");
int stepen = Convert.ToInt32(Console.ReadLine());
STEPEN(number, stepen);

void STEPEN(int number, int stepen)
{
    int N = 1;
    for (int i = 1; i<=stepen; i++)
    {
    N = N*number;
    }
Console.WriteLine(N);
}