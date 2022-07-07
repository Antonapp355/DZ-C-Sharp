// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе выводит перевёрнутое число.

Console.WriteLine("Введите трёхзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
PerevorotChisla(N);


void PerevorotChisla(int current_number)
{
    int a3 = current_number%10;
    int a2 = (current_number%100-a3)/10;
    int a1 = (current_number%1000-a2)/100;
    Console.WriteLine(a3 + "" + a2 + "" + a1);
}

